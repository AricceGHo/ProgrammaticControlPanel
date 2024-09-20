using System.Windows.Forms;

namespace ProgrammaticControlPanel
{
    public partial class Form1 : Form
    {
        Settings settings = new Settings();
        ZP input = new ZP();
        public Form1()
        {

            InitializeComponent();
           
            var common = new CommonInfo();
            var analisys = new Analysis();
            var final = new Final();
            var load =new Load();

            settings=input.LoadSettings(settings);
            input.TryLoadLessions();

            tabControl1.TabPages[0].Controls.Add(input);
            
            input.Dock = DockStyle.Fill;
            final.Dock = DockStyle.Fill;
            common.Dock = DockStyle.Fill;
            analisys.Dock = DockStyle.Fill;
            load.Dock = DockStyle.Fill;

            input.CommonInfo = common;
            input.AnalisysInfo = analisys;
            input.settings = settings;
            input.Final = final;
            input.Load = load;



            tabControl1.TabPages[1].Controls.Add(common);
            tabControl1.TabPages[2].Controls.Add(analisys);
            tabControl1.TabPages[3].Controls.Add(load);
            tabControl1.TabPages[4].Controls.Add(final);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.SaveSettings();
            input.SaveLessions();
        }
    }
}