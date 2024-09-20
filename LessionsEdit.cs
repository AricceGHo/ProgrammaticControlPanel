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
    public partial class LessionsEdit : Form
    {
        public List<LessionData> lessionDatas;
        public LessionsEdit(List<LessionData> lessionDatas)
        {
            InitializeComponent();
            this.lessionDatas= lessionDatas;


            MakeGrid();
            SetGrid();
        }
        public void SetGrid()
        {
            DataGridViewButtonColumn upButtonColumn = new DataGridViewButtonColumn();
            upButtonColumn.Name = "up_column";
            upButtonColumn.Text = "+";


            DataGridViewButtonColumn downButtonColumn = new DataGridViewButtonColumn();
            downButtonColumn.Name = "down_column";
            downButtonColumn.Text = "-";

            lessionsEdit_dgw.Columns.Insert(3, upButtonColumn);
            lessionsEdit_dgw.Columns.Insert(4, downButtonColumn);
            lessionsEdit_dgw.CellClick += dataGridViewSoftware_CellClick;
        }

        public void MakeGrid()
        {

            lessionDatas = lessionDatas.OrderBy(t => t.Number).ToList();
            lessionsEdit_dgw.DataSource = lessionDatas;

        }

        private void dataGridViewSoftware_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == lessionsEdit_dgw.Columns["up_column"].Index)
            {
               if(e.RowIndex!=lessionDatas.Count-1) lessionDatas[e.RowIndex].Number++;
            }
            else if(e.ColumnIndex == lessionsEdit_dgw.Columns["down_column"].Index)
            {
                if (e.RowIndex != 0) lessionDatas[e.RowIndex].Number--;
            }

            MakeGrid();
            lessionsEdit_dgw.Refresh();
        }

        public void Edit()
        {

        }


        private void save_btn_Click(object sender, EventArgs e)
        {
            Settings.instance.SaveLessions(lessionDatas);
            this.DialogResult = DialogResult.OK;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
