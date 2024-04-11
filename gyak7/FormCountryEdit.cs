using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyak7
{
    public partial class FormCountryEdit : Form
    {
        public CountryData EditedCountryData;
        public FormCountryEdit()
        {
            InitializeComponent();
        }

        private void FormCountryEdit_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = EditedCountryData;

        }
    }
}
