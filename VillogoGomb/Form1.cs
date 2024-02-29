namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button b = new();
            Controls.Add(b);

            b.Left = ClientRectangle.Width / 2 - b.Width / 2;
            b.Top = ClientRectangle.Height / 2 - b.Height / 2;

            for (int sor = 1; sor < 21; sor++)
            {
                for (int oszlop = 1; oszlop < 21; oszlop++)
                {
                    VillogoGomb villogoGomb = new VillogoGomb();
                    Controls.Add(villogoGomb);

                    villogoGomb.Top = VillogoGomb.Méret * sor;
                    villogoGomb.Left = VillogoGomb.Méret * oszlop;
                    villogoGomb.Text =  (sor * oszlop).ToString();
                }
            }
        }
    }
}
