using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampionsWFA.Models;

namespace WeAreTheChampionsWFA
{
    public partial class Form1 : Form
    {
        ProjectContext db = new ProjectContext();
        public Form1()
        {
            InitializeComponent();
            TakimlariListele();
        }

        private void TakimlariListele()
        {
            lstTakimlar.DataSource = db.Teams.ToList();
            cboTakimAd.DataSource = db.Teams.ToList();
            cboTakimAdO.DataSource = db.Teams.ToList();
            lstTakimlar.DisplayMember = "TeamName";

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

        private void btnTakimEkle_Click(object sender, EventArgs e)
        {
            var takimAd = txtTakimAd.Text.Trim();
            if (takimAd == "")
            {
                MessageBox.Show("Lütfen bir takım adı giriniz.");
            }
            db.Teams.Add(new Team() { TeamName = takimAd });
            db.SaveChanges();
            txtTakimAd.Clear();
            TakimlariListele();
        }
    }
}
