
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using System.Diagnostics;
using System.Text.Json;
using System.Reflection;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace ProgrammaticControlPanel
{
    public partial class ZP : UserControl
    {

        public Settings settings = new();
        List<LessionData> lessionDatas = new List<LessionData>();
        List<RawData> rawData = new List<RawData>();
        public ZP()
        {
            InitializeComponent();

        }
        public CommonInfo CommonInfo { get; set; }
        public Analysis AnalisysInfo { get; set; }
        public Load Load { get; set; }
        public Final Final { get; set; }


        private void load_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV files(*.csv)|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var dt = new DataTable();

                    var csv = new CsvReader(new StreamReader(openFileDialog1.FileName), settings.csvConfig);
                    rawData = csv.GetRecords<RawData>().ToList();
                    rawData.RemoveAt(0);

                    raw_dgw.AutoGenerateColumns = true;

                    raw_dgw.DataSource = new SortableBindingList<RawData>(rawData);
                    foreach (DataGridViewColumn column in raw_dgw.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }

                    //List<Data> data = rawData.GroupBy(x => x.Teacher).Select(g => new Data { Teacher = g.Key }).ToList();

                    //var data = from row in rawData
                    //                  group row by row.Teacher
                    //                  select  ;


                    List<CommonData> data = rawData.GroupBy(x => x.Teacher).Select(
                        g => new CommonData
                        {
                            Teacher = g.Key
                            ,
                            AS = g.Sum(x => (x.Status == "Не проведено" ? 0 : double.Parse(x.AS)))
                            ,
                            AK = g.Sum(x => (x.Status == "Не проведено" ? 0 : double.Parse(x.AK)))
                            ,
                            indCount = g.Sum(x => (x.Status != "Не проведено" && x.Program == "Индивидуальное обучение" ? 1 : 0))
                            ,
                            grCount = g.Sum(x => (x.Status != "Не проведено" && x.Filial == "Основной" ? 1 : 0))
                           ,
                            fullCount = g.Sum(x => (x.Status == "Не проведено" ? 0 : 1))

                        }).ToList();

                    List<GroupRawData> groupRawDatas = rawData.GroupBy(x => new { x.Teacher, x.Program, x.Filial }).Select(
                        g => new GroupRawData
                        {
                            Teacher = g.Key.Teacher,
                            Lession = g.Key.Filial == "Основной" ? g.Key.Program : g.Key.Filial,
                            Count = g.Sum(x => (x.Status == "Не проведено" ? 0 : 1)),
                            LessionType = (LessionType)(g.Key.Filial == "Основной" ? 1 : 0)
                        }
                        ).ToList();

                    List<GroupLoadData> groupLoadDatas = rawData.GroupBy(x => new { x.Teacher, x.Program }).Select(
                        g=> new GroupLoadData
                        {
                            Teacher= g.Key.Teacher,
                            LessionType= g.Key.Program != "Индивидуальное обучение" ? LessionType.Group : LessionType.Ind,
                            Count= g.Select(x => x.Group).Distinct().Count()
                        }
                        ).ToList();

                    var finalData = Costil_GetFinalData(groupRawDatas);



                    CreateLessionList(out lessionDatas);

                    CommonInfo.calculatedData_dgw.DataSource = new SortableBindingList<CommonData>(data);
                    foreach (DataGridViewColumn column in CommonInfo.calculatedData_dgw.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }

                    AnalisysInfo.calculatedData_dgw.DataSource = new SortableBindingList<GroupRawData>(groupRawDatas);
                    foreach (DataGridViewColumn column in AnalisysInfo.calculatedData_dgw.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }

                    Load.load_dgw.DataSource = new SortableBindingList<GroupLoadData>(groupLoadDatas);
                    foreach (DataGridViewColumn column in Load.load_dgw.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }

                    Final.calculatedData_dgw.DataSource = new SortableBindingList<FinalData>(finalData);
                    foreach (DataGridViewColumn column in AnalisysInfo.calculatedData_dgw.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }
                    Final.FinalData = finalData;
                    Final.calculatedData_dgw.Columns[0].Frozen = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public List<List<string>> GetFinalData(List<GroupRawData> groupRawDatas)
        {
            return null;
        }


        public List<FinalData> Costil_GetFinalData(List<GroupRawData> groupRawDatas)
        {
            List<FinalData> finalData = groupRawDatas.GroupBy(x => new { x.Teacher }).Select(g => new FinalData
            {
                Teacher = g.Key.Teacher,
                g_cpp = g.Sum(x => (x.Lession == FinalDataStrings.g_cpp ? x.Count : 0)),
                i_cpp = g.Sum(x => (x.Lession == FinalDataStrings.i_cpp ? x.Count : 0)),
                g_op = g.Sum(x => (x.Lession == FinalDataStrings.g_op ? x.Count : 0)),
                i_op = g.Sum(x => (x.Lession == FinalDataStrings.i_op ? x.Count : 0)),
                g_java = g.Sum(x => (x.Lession == FinalDataStrings.g_java ? x.Count : 0)),
                i_java = g.Sum(x => (x.Lession == FinalDataStrings.i_java ? x.Count : 0)),
                g_web = g.Sum(x => (x.Lession == FinalDataStrings.g_web ? x.Count : 0)),
                i_web = g.Sum(x => (x.Lession == FinalDataStrings.i_web ? x.Count : 0)),
                g_pys = g.Sum(x => (x.Lession == FinalDataStrings.g_pys ? x.Count : 0)),
                i_pys = g.Sum(x => (x.Lession == FinalDataStrings.i_pys ? x.Count : 0)),
                g_pym = g.Sum(x => (x.Lession == FinalDataStrings.g_pym ? x.Count : 0)),
                i_pym = g.Sum(x => (x.Lession == FinalDataStrings.i_pym ? x.Count : 0)),
                g_pyp = g.Sum(x => (x.Lession == FinalDataStrings.g_pyp ? x.Count : 0)),
                i_pyp = g.Sum(x => (x.Lession == FinalDataStrings.i_pyp ? x.Count : 0)),
                g_ro = g.Sum(x => (x.Lession == FinalDataStrings.g_ro ? x.Count : 0)),
                i_ro = g.Sum(x => (x.Lession == FinalDataStrings.i_rop ? x.Count : 0)),
                g_rop = g.Sum(x => (x.Lession == FinalDataStrings.g_rop ? x.Count : 0)),
                i_rop = g.Sum(x => (x.Lession == FinalDataStrings.i_ro ? x.Count : 0)),
                g_sc = g.Sum(x => (x.Lession == FinalDataStrings.g_sc ? x.Count : 0)),
                i_sc = g.Sum(x => (x.Lession == FinalDataStrings.i_sc ? x.Count : 0)),
                g_og = g.Sum(x => (x.Lession == FinalDataStrings.g_og ? x.Count : 0)),
                i_og = g.Sum(x => (x.Lession == FinalDataStrings.i_og ? x.Count : 0)),
                g_int = g.Sum(x => (x.Lession.ToLower().Contains(FinalDataStrings.g_int.ToLower()) ? x.Count : 0)),
                Unknown = g.Sum(x => (!FinalDataStrings.CheckAll(x.Lession) ? x.Count : 0))

            }).ToList();

            return finalData;
        }

        private void saveLessions_btn_Click(object sender, EventArgs e)
        {
            if (rawData.Count == 0)
            {
                MessageBox.Show(
       "Подгрузите файл с данными",
       "Ошибка",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information,
       MessageBoxDefaultButton.Button1);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveLessions(saveFileDialog.FileName);
            }
        }

        private void loadLessions_btn_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadLessions(openFileDialog.FileName);
            }


        }

        public bool LoadLessions(string path = null)
        {
            path = path == null ? (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\lessions.json") : path;
            Debug.WriteLine("LL " + path);
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {

                    lessionDatas.AddRange(JsonSerializer.Deserialize<List<LessionData>>(fs));
                    lessionDatas = lessionDatas.Distinct(new LessionsComparer()).ToList();

                    return true;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{ex.Message} \n{ex.StackTrace}");
                MessageBox.Show(
           $"{ex.Message} \n{ex.StackTrace}",
           "Ошибка",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button1);
                return false;

            }

        }

        public bool SaveLessions(string path = "")
        {
            path = path == "" ? (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\lessions.json") : path;
            Debug.WriteLine("SL " + path);
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                JsonSerializer.Serialize(fs, lessionDatas, settings.jsonSerializerOptions);
                settings.LastLessionsPath = path;
                return true;
            }
            return false;
        }

        private void createLessionList_btn_Click(object sender, EventArgs e)
        {
            CreateLessionList(out lessionDatas);
        }
        public List<LessionData> CreateLessionList()
        {
            if (rawData.Count == 0)
            {
                MessageBox.Show(
       "Подгрузите файл с данными",
       "Ошибка",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information,
       MessageBoxDefaultButton.Button1);
                return null;
            }

            List<LessionData> lessionDatas = new List<LessionData>();
            lessionDatas.AddRange(rawData.GroupBy(x => new { x.Program, x.Filial }).Select(
                       g => new LessionData
                       {
                           Lession = g.Key.Filial == "Основной" ? g.Key.Program : g.Key.Filial,
                           LessionType = (g.Key.Filial == "Основной" ? "Group" : "Ind")

                       }
                       ).ToList());
            return lessionDatas.Distinct(new LessionsComparer()).ToList();
        }
        public void CreateLessionList(out List<LessionData> lessionData)
        {
            if (rawData.Count == 0)
            {
                MessageBox.Show(
       "Подгрузите файл с данными",
       "Ошибка",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information,
       MessageBoxDefaultButton.Button1);
                lessionData = lessionDatas;
                return;
            }
            lessionData = lessionDatas;
            var ld = rawData.GroupBy(x => new { x.Program, x.Filial }).Select(
                       g => new LessionData
                       {
                           Lession = g.Key.Filial == "Основной" ? g.Key.Program : g.Key.Filial,
                           LessionType = (g.Key.Filial == "Основной" ? "Group" : "Ind")

                       }
                       ).ToList();

            lessionData.AddRange(ld);
            lessionData = lessionData.Distinct(new LessionsComparer()).ToList();
            lessionDatas = lessionData;
        }

        private void saveSettings_btn_Click(object sender, EventArgs e)
        {
            settings.SaveSettings();
        }

        private void loadSettings_btn_Click(object sender, EventArgs e)
        {

            settings = LoadSettings(settings);

        }
        public bool TryLoadLessions()
        {
            if (settings.LastLessionsPath != "")
            {
                LoadLessions(settings.LastLessionsPath);
                return true;
            }
            else
            {
                if (LoadLessions())
                    return true;
                else
                {
                    MessageBox.Show(
                             "Не олучилось открыть файл уроков, откройте или создайте его",
                             "Ошибка",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information,
                             MessageBoxDefaultButton.Button1);
                    return false;
                }
            }


        }
        public Settings LoadSettings(Settings settings)
        {
            if (!settings.TryLoadSettings(out settings))
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!settings.TryLoadSettings(out settings, openFileDialog.FileName))
                    {
                        MessageBox.Show(
                               "Не олучилось открыть файл настроек",
                               "Ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button1);
                    }
                }
            }
            return settings;
        }

        private void editLessions_btn_Click(object sender, EventArgs e)
        {
            
            if(lessionDatas.Count==0)
            {
                MessageBox.Show(
                               "Нет уроков для редактирования, подгрузите или создайте список",
                               "Ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information,
                               MessageBoxDefaultButton.Button1);
            }
           
            else 
            {
                LessionsEdit lessionsEdit = new LessionsEdit(lessionDatas);
                if (lessionsEdit.ShowDialog() == DialogResult.OK)
                {

                }

            }
        }
    }


}
