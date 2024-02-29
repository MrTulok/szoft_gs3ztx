using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzinezoGomb
{
    internal class SzíneződőGomb : Button
    {
        public static int Méret = 20;
        public SzíneződőGomb()
        {
            Width = Méret;
            Height = Méret;
            MouseClick += SzíneződőGomb_MouseClick;
        }

        private void SzíneződőGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
