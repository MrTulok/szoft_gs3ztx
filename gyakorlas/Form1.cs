namespace gyakorlas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button button = new Button();
                    button.Left = i * 40;
                    button.Top = j * 40;
                    button.Height = 40;
                    button.Width = 40;
                    button.Text = ((i+1)*(j+1)).ToString();

                    if ((i + 1) * (j + 1)% 2 == 0)
                    {
                        button.BackColor = Color.White;
                    }
                    else
                    {
                        button.BackColor = Color.Black;
                    }

                    Controls.Add(button);
                }
            }
        }
    }
}

