using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eloadas1
{
    internal class SajátGomb : Button
    {
        public static int Méret = 30;
        public SajátGomb()
        {
            Text = ":)";
            MouseEnter += SajátGomb_MouseEnter;
            Height = Méret;
            Width = Méret;
        }

        private void SajátGomb_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }

        

    }
}
