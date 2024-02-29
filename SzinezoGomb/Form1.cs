namespace SzinezoGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 1; sor < 21; sor++)
            {
                for (int oszlop = 1; oszlop < 21; oszlop++)
                {
                    SzínezõdõGomb sz = new();
                    Controls.Add(sz);

                    sz.Top = SzínezõdõGomb.Méret * sor;
                    sz.Left = SzínezõdõGomb.Méret * oszlop;
                    sz.Text = (sor * oszlop).ToString();
                }
            }
        }
    }
}
