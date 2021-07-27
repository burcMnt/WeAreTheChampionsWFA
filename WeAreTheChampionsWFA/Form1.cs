using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeAreTheChampionsWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pboRenkler_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            mtbRDegeri.Text = cd.Color.R.ToString();
            mtbGDegeri.Text = cd.Color.G.ToString();
            mtbBDegeri.Text = cd.Color.B.ToString();
            pboSecilenRenk.BackColor = cd.Color;

        }

    }
}
