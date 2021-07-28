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
            TakimlarTabResetle();
            RenkleriListele();
            RenklerTabResetle();

        }

        private void RenklerTabResetle()
        {
            txtRenkAd.Clear();
            mtbRDegeri.Clear();
            mtbGDegeri.Clear();
            mtbBDegeri.Clear();
            lstRenkler.SelectedIndex = -1;
            pboSecilenRenk.BackColor = default;
            btnRenkEkle.Text = "Renk Ekle";
        }

        private void RenkleriListele()
        {
            lstRenkler.DataSource = db.Colors.OrderBy(x => x.ColorName).ToList();
        }

        private void TakimlarTabResetle()
        {
            txtTakimAd.Clear();
            cboTakimAd.SelectedIndex = -1;
            cboRenkAd.SelectedIndex = -1;
            cboTakimAdO.SelectedIndex = -1;
            cboOyuncuAd.SelectedIndex = -1;
            lstTakimAdlari.SelectedIndex = -1;
            lstTakiminRengi.SelectedIndex = -1;
            lstTakimOyunculari.SelectedIndex = -1;
        }

        private void TakimlariListele()
        {
            lstTakimAdlari.DataSource = db.Teams.ToList();
            cboTakimAd.DataSource = db.Teams.ToList();
            cboTakimAdO.DataSource = db.Teams.ToList();
            lstTakimAdlari.DisplayMember = "TeamName";

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
                return;
            }
            db.Teams.Add(new Team() { TeamName = takimAd });
            db.SaveChanges();
            txtTakimAd.Clear();
            TakimlariListele();
            TakimlarTabResetle();
        }

        private void btnTakimSil_Click(object sender, EventArgs e)
        {
            Team secilitakim = (Team)lstTakimAdlari.SelectedItem;
            if (secilitakim == null)
            {
                MessageBox.Show("Lütfen kaldırılacak takimi seçiniz.");
                return;
            }
            db.Teams.Remove(secilitakim);
            db.SaveChanges();
            TakimlariListele();
            TakimlarTabResetle();

        }

        private void lstTakimAdlari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                lstTakimAdlari.SelectedIndex = -1;
                lstTakiminRengi.SelectedIndex = -1;
                lstTakimOyunculari.SelectedIndex = -1;
            }
        }

        private void btnRenkEkle_Click(object sender, EventArgs e)
        {
            if (duzenlenenRenk == null)
            {
                if (txtRenkAd.Text == "" || mtbRDegeri.Text == "")
                {
                    MessageBox.Show("Lütfen renk adını belirtip Rgb degerleri için renk paletinden renk seçiniz.");
                    return;
                }
                db.Colors.Add(new Models.Color()
                {
                    ColorName = txtRenkAd.Text,
                    Red = Convert.ToInt32(mtbRDegeri.Text),
                    Green = Convert.ToInt32(mtbGDegeri.Text),
                    Blue = Convert.ToInt32(mtbBDegeri.Text)
                });

            }
            else
            {
                duzenlenenRenk.ColorName = txtRenkAd.Text;
                duzenlenenRenk.Red = Convert.ToInt32(mtbRDegeri.Text);
                duzenlenenRenk.Green = Convert.ToInt32(mtbGDegeri.Text);
                duzenlenenRenk.Blue = Convert.ToInt32(mtbBDegeri.Text);
            }

            db.SaveChanges();
            RenkleriListele();
            RenklerTabResetle();

        }

        private void btnRenkSil_Click(object sender, EventArgs e)
        {
            if (lstRenkler.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silmek için listeden bir renk seçiniz.");
                return;
            }
            var secilenRenk = (Models.Color)lstRenkler.SelectedItem;
            db.Colors.Remove(secilenRenk);
            db.SaveChanges();
            RenkleriListele();
            RenklerTabResetle();
        }
        Models.Color duzenlenenRenk;
        private void btnRenkDuzenle_Click(object sender, EventArgs e)
        {
            if (lstRenkler.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen düzenlemek için listeden bir renk seçiniz.");
                return;
            }
            duzenlenenRenk = (Models.Color)lstRenkler.SelectedItem;
            txtRenkAd.Text = duzenlenenRenk.ColorName;
            mtbRDegeri.Text = duzenlenenRenk.Red.ToString();
            mtbGDegeri.Text = duzenlenenRenk.Green.ToString();
            mtbBDegeri.Text = duzenlenenRenk.Blue.ToString();
            btnRenkEkle.Text = "Rengi Kaydet";

        }
    }
}
