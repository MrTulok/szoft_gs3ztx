using System.Security.Policy;

namespace Eloadas6
{
    enum St�tus {Akt�v,Passz�v}
    enum Munkarend {Nappali,Esti,Levelez�}
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            St�tus s = St�tus.Akt�v;
            Munkarend m = Munkarend.Nappali;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void m�sodikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            if (f2.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void megnyit�sToolStripMenuItem_Click(object sender, EventArgs e)
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
