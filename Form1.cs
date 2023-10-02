namespace ProgrammaticControlPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {   
            InitializeComponent();
            var zp = new ZP();
            tabControl1.TabPages[0].Controls.Add(zp);
            zp.Dock = DockStyle.Fill;
        }
    }
}