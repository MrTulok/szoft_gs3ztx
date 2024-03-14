using System.Data;
using System.Security.Cryptography;
using System.Text.Json;

namespace gyak2
{
    public partial class Form1 : Form
    {

        private List<Sor> list = new List<Sor>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rng = new Random();

            int db = 0;

            while (db != 100)
            {
                int w = rng.Next(10, 40);
                int h = rng.Next(10, 40);
                int l = rng.Next(ClientSize.Width - w);
                int t = rng.Next(ClientSize.Height - h);

                Gomb g = new(w, h);

                g.Left = l;
                g.Top = t;

                Controls.Add(g);
                db++;
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            decimal meret = 0;
            string ertek = textBox1.Text;

            if (decimal.TryParse(ertek, out decimal result))
            {
                textBox2.Text = (result * 2).ToString();
                meret = result * 2;
            }
            else
            {
                textBox2.Text = "Helytelen";
            }            

            Sor újSor = new Sor(list.Count + 1,textBox2.Text,meret);

            list.Add(újSor);

            list = list.OrderByDescending(újSor => újSor.Meret).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }


    }
}
