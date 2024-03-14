using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak2
{
    internal class Gomb : Button
    {
        public Gomb(int w, int h)
        {
            Width = w;
            Height = h;
            BackColor = Color.Black;

            ow = Width;
            oh = Height;
            oc = Color.Black;

            MouseEnter += Gomb_MouseEnter;
            MouseLeave += Gomb_MouseLeave;
        }

        private int ow;
        private int oh;
        private Color oc;

        private void Gomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Blue;
            Width = Width * 2;
            Height = Height * 2;
        }
        private void Gomb_MouseLeave(object? sender, EventArgs e)
        {
            Width = ow;
            Height = oh;
            BackColor = oc;
        }

    }
}
