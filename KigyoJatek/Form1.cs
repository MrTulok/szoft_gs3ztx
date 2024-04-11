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

        int ir�ny_x = 1;
        int ir�ny_y = 0;

        public int l�p�sSz�m = 0;

        List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();
        

        int hossz = 7;

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�sSz�m++;

            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;

            foreach (object item in Controls)
            {
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;

                    if (k.Left == fej_x && k.Top == fej_y)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }

            }

            K�gy�Elem ke = new();
            k�gy�.Add(ke);
            Controls.Add(ke);

            ke.Top = fej_y;
            ke.Left = fej_x;



            if (k�gy�.Count > hossz)
            {
                K�gy�Elem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }


            if (l�p�sSz�m % 2 == 0 ) ke.BackColor = Color.Black;


            
        }

        bool igaz_e = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }
            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
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
