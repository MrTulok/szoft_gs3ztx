using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace VillogoGomb
{
    internal class VillogoGomb : Button
    {
        public static int Méret = 40;
        public VillogoGomb()
        {
            MouseEnter += VillogoGomb_MouseEnter;
            MouseLeave += VillogoGomb_MouseLeave;
            Height = Méret;
            Width = Méret;
        }

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
