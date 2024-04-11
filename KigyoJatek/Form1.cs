namespace KigyoJatek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int fej_x = 100;
        int fej_y = 100;

        int irány_x = 1;
        int irány_y = 0;

        public int lépésSzám = 0;

        List<KígyóElem> kígyó = new List<KígyóElem>();
        

        int hossz = 7;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésSzám++;

            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;

            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Left == fej_x && k.Top == fej_y)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }

            }

            KígyóElem ke = new();
            kígyó.Add(ke);
            Controls.Add(ke);

            ke.Top = fej_y;
            ke.Left = fej_x;



            if (kígyó.Count > hossz)
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }


            if (lépésSzám % 2 == 0 ) ke.BackColor = Color.Black;


            
        }

        bool igaz_e = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }
            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
            if (e.KeyCode == Keys.Space && igaz_e == false)
            {
                timer1.Interval /= 5;
                igaz_e = true;
            }
            else if (e.KeyCode == Keys.Space && igaz_e == true)
            {
                timer1.Interval *= 5;
                igaz_e = false;
            }

        }
    }
}
