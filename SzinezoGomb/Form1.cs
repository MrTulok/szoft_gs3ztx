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
                    Sz�nez�d�Gomb sz = new();
                    Controls.Add(sz);

                    sz.Top = Sz�nez�d�Gomb.M�ret * sor;
                    sz.Left = Sz�nez�d�Gomb.M�ret * oszlop;
                    sz.Text = (sor * oszlop).ToString();
                }
            }
        }
    }
}
