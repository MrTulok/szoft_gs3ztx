namespace eloadas1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    SajátGomb sajátGomb = new();
                    Controls.Add(sajátGomb);

                    sajátGomb.Top = SajátGomb.Méret * sor;
                    sajátGomb.Left = SajátGomb.Méret *oszlop;
                }
            }
        }
    }
}
