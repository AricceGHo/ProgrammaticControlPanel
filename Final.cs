using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammaticControlPanel
{
    public partial class Final : UserControl
    {
        public Final()
        {
            InitializeComponent();
           
        }
        public List<FinalData> FinalData { get; set; }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV for Google Docs (*.csv)|*.csv";
            if(saveFileDialog.ShowDialog()== DialogResult.OK)
            {
                using (TextWriter writer = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                {
                    var csv = new CsvWriter(writer,Settings.instance.csvConfig);
                    
                    csv.WriteRecords(FinalData); // where values implements IEnumerable
                }
               
                
               
            }
        }
    }
}
