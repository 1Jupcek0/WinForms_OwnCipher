using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SifrovacDesifrovac {
    public partial class Form2 : Form {
        public static Form2 instance;
        public Form2() {
            InitializeComponent();
            instance = this;
            textFinal.Text = Form1.instance.vysledek.Text;
        }

        private void Form2_Paint(object sender, PaintEventArgs e) {
            Graphics grf = e.Graphics;
            Color clr = Color.FromArgb(240, 48, 21);
            Pen pn = new Pen(clr, 5);
            grf.DrawRectangle(pn, textFinal.Location.X, textFinal.Location.Y, textFinal.Size.Width - 1, textFinal.Size.Height - 1);
        }
    }
}
