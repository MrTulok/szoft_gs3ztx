namespace Háromszög
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int m = 20;
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < i+1; j++)
                {
                    Gomb g = new(m, m);
                    Controls.Add(g);

                    g.Left = j * m - i * m / 2 + Width / 2;
                    g.Top = i * m + Height / 4;
                }
            }
        }
    }
}
