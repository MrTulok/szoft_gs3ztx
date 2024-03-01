namespace Gombok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++) 
            {
                for (int j = 0; j < 10; j++)
                {
                    Random random = new();
                    int meret = random.Next(0, 40);

                    Gombok g = new(meret, meret);
                    Controls.Add(g);

                    g.Left = random.Next(0, ClientRectangle.Width);
                    g.Top = random.Next(0, ClientRectangle.Height);
                    g.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255),random.Next(0, 255));
                }
            }
        }
    }
}
