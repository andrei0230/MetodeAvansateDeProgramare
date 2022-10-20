namespace Curs_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.initGraph(pictureBox1);
            Engine.demo = new Graf();
            Engine.demo.LoadFromFile(@"../../../WindowsFormAplication4.txt");
            Engine.demo.Color();
            List<string> t = Engine.demo.View(listBox2);
            Engine.demo.Draw(Engine.grp);
            Engine.Refresh();

        }
    }
}