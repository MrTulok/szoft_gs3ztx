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
                    Saj�tGomb saj�tGomb = new();
                    Controls.Add(saj�tGomb);

                    saj�tGomb.Top = Saj�tGomb.M�ret * sor;
                    saj�tGomb.Left = Saj�tGomb.M�ret *oszlop;
                }
            }
        }
    }
}
