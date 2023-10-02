
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

namespace ProgrammaticControlPanel
{
    public partial class ZP : UserControl
    {
        CsvConfiguration csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
        {
            HasHeaderRecord = false,
            Comment = '#',
            AllowComments = true,
            Delimiter = ",",
        };
        public ZP()
        {
            InitializeComponent();
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var dt = new DataTable();

                    var csv = new CsvReader(new StreamReader(openFileDialog1.FileName), csvConfig);
                    var rawData = csv.GetRecords<RawData>().ToList();
                    rawData.RemoveAt(0);

                    raw_dgw.AutoGenerateColumns = true;

                    raw_dgw.DataSource = rawData;
                    foreach (DataGridViewColumn column in raw_dgw.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }

                    //List<Data> data = rawData.GroupBy(x => x.Teacher).Select(g => new Data { Teacher = g.Key }).ToList();

                    //var data = from row in rawData
                    //                  group row by row.Teacher
                    //                  select  ;


                    List<Data> data = rawData.GroupBy(x => x.Teacher).Select(
                        g => new Data
                        {
                            Teacher = g.Key
                            ,
                            AS = g.Sum(x => (x.Status == "Не проведено" ? 0 : double.Parse(x.AS)))
                            ,
                            AK = g.Sum(x => (x.Status == "Не проведено" ? 0 : double.Parse(x.AK)))
                        }).ToList();
                    calculatedData_dgw.DataSource = data;
                    foreach (DataGridViewColumn column in calculatedData_dgw.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
    public class RawData
    {
        [DisplayName("Дата")]
        public string DateString { get; set; }
        [DisplayName("Время")]

        public string TimeString { get; set; }
        [DisplayName("Ауд/зал")]
        public string Place { get; set; }
        [DisplayName("Статус")]
        public string Status { get; set; }
        [DisplayName("Филиал")]
        public string Filial { get; set; }
        [DisplayName("Программа")]
        public string Program { get; set; }
        [DisplayName("Группа")]
        public string Group { get; set; }
        [DisplayName("Преподаватель")]
        public string Teacher { get; set; }
        [DisplayName("Тема")]
        public string Subject { get; set; }
        [DisplayName("Описание")]
        public string Note { get; set; }
        [DisplayName("Записано")]
        public string Recorded { get; set; }
        [DisplayName("Пришло")]
        public string HasCome { get; set; }
        [DisplayName("Пропусков всего")]
        public string MissedAll { get; set; }
        [DisplayName("Пропусков по уваж. причине")]
        public string MissedAllowed { get; set; }
        [DisplayName("Продолж. ас/ч")]
        public string AS { get; set; }
        [DisplayName("Продолж. ак/ч")]
        public string AK { get; set; }
        public override string ToString()
        {
            return $"{DateString} {TimeString} {Place} {Status} {Filial} {Program} {Group} {Teacher} {Subject} {Note} {Recorded} {HasCome} {MissedAll} {MissedAllowed} {AS} {AK}  ";
        }

    }
    public class Data
    {
        [DisplayName("Преподаватель")]
        public string Teacher { get; set; }
        [DisplayName("Продолж. ас/ч")]
        public double AS { get; set; }
        [DisplayName("Продолж. ак/ч")]
        public double AK { get; set; }
    }
}
