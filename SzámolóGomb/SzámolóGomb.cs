using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzámolóGomb
{
    internal class SzámolóGomb : Button
    {
        int szám = 1;
        public static int Méret = 40;
        public SzámolóGomb()
        {
            Height = Méret;
            Width = Méret;
            MouseClick += SzámolóGomb_MouseClick;
            Text = szám.ToString();
        }

        private void SzámolóGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (szám < 5)
            {
                szám += 1;
            }
            else
            {
                szám = 1;
            }
            Text = szám.ToString();
        }
    }
}
