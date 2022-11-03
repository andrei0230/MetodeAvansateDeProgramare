using System.Security.Cryptography.X509Certificates;

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

        private void btnBFS_Click(object sender, EventArgs e)
        {
            string x = "";
            List<int> t = Engine.demo.BFS(3);
            foreach(int i in t)
            {
                x += i + " ";   
            }
            listBox1.Items.Add(x);
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            string x = "";
            List<int> t = Engine.demo.DFS(3);
            foreach (int i in t)
            {
                x += i + " ";
            }
            listBox1.Items.Add(x);
        }
    }
}