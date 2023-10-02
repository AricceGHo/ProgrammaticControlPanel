namespace ProgrammaticControlPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages[0].Controls.Add(new ZP());
        }
    }
}