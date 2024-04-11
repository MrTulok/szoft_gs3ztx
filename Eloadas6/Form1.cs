using System.Security.Policy;

namespace Eloadas6
{
    enum Státus {Aktív,Passzív}
    enum Munkarend {Nappali,Esti,Levelezõ}
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Státus s = Státus.Aktív;
            Munkarend m = Munkarend.Nappali;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void másodikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            if (f2.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 uc1 = new();
            panel1.Controls.Add(uc1);
            uc1.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 uc2 = new();
            panel1.Controls.Add(uc2);
            uc2.Dock = DockStyle.Fill;
        }
    }
}
