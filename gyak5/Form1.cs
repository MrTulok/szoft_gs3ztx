namespace gyak5
{
    public partial class Form1 : Form
    {
        List<Kérdés> ÖsszesKérdés;
        List<Kérdés> AktuálisKérdés = new List<Kérdés>();
        int MegjelenítettKérdésSzáma = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ÖsszesKérdés = KérdésekBeolvasása();
            for (int i = 0; i < 7; i++)
            {
                AktuálisKérdés.Add(ÖsszesKérdés[0]);
                ÖsszesKérdés.RemoveAt(0);
            }
            dataGridView1.DataSource = AktuálisKérdés;

            KérdésMegjelenítése(AktuálisKérdés[MegjelenítettKérdésSzáma]);
        }

        void KérdésMegjelenítése(Kérdés kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            textBox1.Text = kérdés.Válasz1;
            textBox2.Text = kérdés.Válasz2;
            textBox3.Text = kérdés.Válasz3;

            if (string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
            }


            textBox1.BackColor = Color.White;
            textBox2 .BackColor = Color.White;
            textBox3 .BackColor = Color.White;

        }

        List<Kérdés> KérdésekBeolvasása()
        {
            List<Kérdés> kérdések = new();
            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);

            while (!sr.EndOfStream)
            {
                string? sor = sr.ReadLine()/*vagy ?? n/a*/;
                string[] tömb = sor.Split("\t");

                if (tömb.Length != 7) continue;

                Kérdés k = new();

                k.KérdésSzöveg = tömb[1].ToUpper();
                k.Válasz1 = tömb[2].Trim('"');
                k.Válasz2 = tömb[3];
                k.Válasz3 = tömb[4];
                k.URL = tömb[5];

                int x = 0;
                int.TryParse(tömb[6], out x);

                k.HelyesVálasz = x;

                kérdések.Add(k);
            }

            sr.Close();
            return kérdések;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MegjelenítettKérdésSzáma++;
            if (MegjelenítettKérdésSzáma == AktuálisKérdés.Count) MegjelenítettKérdésSzáma = 0;

            KérdésMegjelenítése(AktuálisKérdés[MegjelenítettKérdésSzáma]);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
            if (AktuálisKérdés[MegjelenítettKérdésSzáma].HelyesVálasz == 1)
            {
                textBox1.BackColor = Color.LightGreen;
                AktuálisKérdés[MegjelenítettKérdésSzáma].HelyesVálaszokSzáma++;
            }
            else
            {
                textBox1.BackColor = Color.Salmon;
                AktuálisKérdés[MegjelenítettKérdésSzáma].HelyesVálaszokSzáma = 0;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            
            if (AktuálisKérdés[MegjelenítettKérdésSzáma].HelyesVálasz == 2)
            {
                textBox2.BackColor = Color.LightGreen;
                AktuálisKérdés[MegjelenítettKérdésSzáma].HelyesVálaszokSzáma++;
            }
            else
            {
                textBox2.BackColor = Color.Salmon;
                AktuálisKérdés[MegjelenítettKérdésSzáma].HelyesVálaszokSzáma = 0;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            
            if (AktuálisKérdés[MegjelenítettKérdésSzáma].HelyesVálasz == 3)
            {
                textBox3.BackColor = Color.LightGreen;
                AktuálisKérdés[MegjelenítettKérdésSzáma].HelyesVálaszokSzáma++;
            }
            else
            {
                textBox3.BackColor = Color.Salmon;
                AktuálisKérdés[MegjelenítettKérdésSzáma].HelyesVálaszokSzáma = 0;
            }
        }
    }
}
