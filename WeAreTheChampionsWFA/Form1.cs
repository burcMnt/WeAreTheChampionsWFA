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
using WMPLib;

namespace WeAreTheChampionsWFA
{
    public partial class Form1 : Form
    {
        ProjectContext db = new ProjectContext();
        WMPLib.WindowsMediaPlayer muzik = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            muzik.URL = "uefa.mp3";
            MaclariYukle();
            TakimlariListele();
            TakimlarTabResetle();
            RenkleriListele();
            RenklerTabResetle();
            OyunculariListele();
            OyuncularTabResetle();
            TakiminRenkleriniListele();
            TakiminOyunculariniListele();

        }

        private void TakiminOyunculariniListele()
        {
            lstTakimOyunculari.DisplayMember = "PlayerName";
            Team takim = (Team)cboTakimAdO.SelectedItem;
            if (takim == null)
            {
                lstTakimOyunculari.DataSource = null;
            }
            else
            {
                lstTakimOyunculari.DataSource = takim.Players.OrderBy(x => x.PlayerName).ToList();
            }
        }

        private void TakiminRenkleriniListele()
        {
            lstTakiminRengi.DisplayMember = "ColorName";
            Team takim = (Team)cboTakimAd.SelectedItem;
            if (takim == null)
            {
                lstTakiminRengi.DataSource = null;
            }
            else
            {
                lstTakiminRengi.DataSource = takim.Colors.ToList();
            }
        }

        private void OyuncularTabResetle()
        {
            txtOyuncuAd.Clear();
            lstOyuncular.SelectedIndex = -1;
            btnOyuncuEkle.Text = "EKLE";
            btnOyuncuIptal.Visible = false;
        }

        private void OyunculariListele()
        {
            lstOyuncular.DataSource = db.Players.OrderBy(x => x.PlayerName).ToList();
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
            btnRenkIptal.Visible = false;
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
            btnTakimEkle.Text = "Takım Ekle";
            btnTakimIptal.Visible = false;

        }

        private void TakimlariListele()
        {
            lstTakimAdlari.DataSource = db.Teams.OrderBy(x => x.TeamName).ToList();
            cboTakimAd.DataSource = db.Teams.OrderBy(x => x.TeamName).ToList();
            cboTakimAdO.DataSource = db.Teams.OrderBy(x => x.TeamName).ToList();
            cboRenkAd.DataSource = db.Colors.ToList();
            cboOyuncuAd.DataSource = db.Players.ToList();
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
            if (duzenlenenTakim == null)
            {

                var takimAd = txtTakimAd.Text.Trim();
                if (takimAd == "")
                {
                    MessageBox.Show("Lütfen bir takım adı giriniz.");
                    return;
                }
                db.Teams.Add(new Team() { TeamName = takimAd });
            }
            else
            {
                duzenlenenTakim.TeamName = txtTakimAd.Text.Trim();
            }

            db.SaveChanges();
            txtTakimAd.Clear();
            duzenlenenTakim = null;
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
            MaclariYukle();
        }
        Team duzenlenenTakim;
        private void btnTakimDuzenle_Click(object sender, EventArgs e)
        {
            if (lstTakimAdlari.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen düzenlemek için listeden bir takım adı seçiniz.");
                return;
            }
            duzenlenenTakim = (Team)lstTakimAdlari.SelectedItem;
            txtTakimAd.Text = duzenlenenTakim.TeamName;
            btnTakimEkle.Text = "KAYDET";
            btnTakimIptal.Visible = true;
        }
        private void btnTakimIptal_Click(object sender, EventArgs e)
        {
            TakimlarTabResetle();
            duzenlenenTakim = null;
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
                int r = Convert.ToInt32(mtbRDegeri.Text);
                int g = Convert.ToInt32(mtbGDegeri.Text);
                int b = Convert.ToInt32(mtbBDegeri.Text);
                if (r > 255 || g > 255 || b > 255)
                {
                    MessageBox.Show("R-G-B değerleri 255 den büyük olamaz, Lütfen yeniden deneyin.");
                    return;
                }
            }

            db.SaveChanges();
            RenkleriListele();
            RenklerTabResetle();
            cboRenkAd.DataSource = db.Colors.ToList();
            cboRenkAd.SelectedIndex = -1;

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
            cboRenkAd.DataSource = db.Colors.ToList();
            cboRenkAd.SelectedIndex = -1;
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
            mtbRDegeri.ReadOnly = mtbGDegeri.ReadOnly = mtbBDegeri.ReadOnly = false;
            btnRenkEkle.Text = "Rengi Kaydet";
            btnRenkIptal.Visible = true;
            pboSecilenRenk.BackColor = System.Drawing.Color.FromArgb(duzenlenenRenk.Red, duzenlenenRenk.Green, duzenlenenRenk.Blue);

        }

        private void btnOyuncuEkle_Click(object sender, EventArgs e)
        {
            if (duzenlenenOyuncu == null)
            {
                if (txtOyuncuAd.Text == "")
                {
                    MessageBox.Show("Lütfen takım oyuncusunun bilgilerini giriniz.");
                    return;
                }
                db.Players.Add(new Player()
                {
                    PlayerName = txtOyuncuAd.Text.Trim()
                });
            }
            else
            {
                duzenlenenOyuncu.PlayerName = txtOyuncuAd.Text.Trim();
            }
            db.SaveChanges();
            OyunculariListele();
            OyuncularTabResetle();
            cboOyuncuAd.DataSource = db.Players.OrderBy(X => X.PlayerName).ToList();
            cboOyuncuAd.SelectedIndex = -1;
        }

        private void btnOyuncuSil_Click(object sender, EventArgs e)
        {
            if (lstOyuncular.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silmek için tablodan bir oyuncu seçin.");
                return;
            }
            var secilenOyuncu = (Player)lstOyuncular.SelectedItem;
            db.Players.Remove(secilenOyuncu);
            db.SaveChanges();
            OyunculariListele();
            OyuncularTabResetle();
            cboOyuncuAd.DataSource = db.Players.OrderBy(X => X.PlayerName).ToList();
            cboOyuncuAd.SelectedIndex = -1;
        }
        Player duzenlenenOyuncu;
        private void btnOyuncuDuzenle_Click(object sender, EventArgs e)
        {
            if (lstOyuncular.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz oyuncu adını seçiniz.");
                return;
            }
            duzenlenenOyuncu = (Player)lstOyuncular.SelectedItem;
            txtOyuncuAd.Text = duzenlenenOyuncu.PlayerName;
            btnOyuncuEkle.Text = "KAYDET";
            btnOyuncuIptal.Visible = true;
        }

        private void btnTakimRenkAta_Click(object sender, EventArgs e)
        {
            Team takim = (Team)cboTakimAd.SelectedItem;
            Models.Color renk = (Models.Color)cboRenkAd.SelectedItem;
            if (takim == null || renk == null)
            {
                MessageBox.Show("Lütfen takım adı ve takım rengi seçiniz.");
                return;
            }
            takim.Colors.Add(renk);
            db.SaveChanges();
            TakiminRenkleriniListele();
            lstTakiminRengi.SelectedIndex = -1;
            cboRenkAd.SelectedIndex = -1;

        }

        private void cboTakimAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            TakiminRenkleriniListele();
            cboRenkAd.SelectedIndex = -1;
            lstTakiminRengi.SelectedIndex = -1;
        }

        private void btnTakimRenkSil_Click(object sender, EventArgs e)
        {
            Team takim = (Team)cboTakimAd.SelectedItem;
            Models.Color renk = (Models.Color)lstTakiminRengi.SelectedItem;
            if (takim == null || renk == null)
            {
                MessageBox.Show("Lütfen takım adı ve kaldırılacak takım rengi seçiniz.");
                return;
            }
            takim.Colors.Remove(renk);
            db.SaveChanges();
            TakiminRenkleriniListele();
        }

        private void btnTakimOyuncuAta_Click(object sender, EventArgs e)
        {
            Team takimo = (Team)cboTakimAdO.SelectedItem;
            Player oyuncu = (Player)cboOyuncuAd.SelectedItem;
            if (takimo == null || oyuncu == null)
            {
                MessageBox.Show("Lütfen takım adı ve takım oyuncusunu seçiniz.");
                return;
            }
            takimo.Players.Add(oyuncu);
            db.SaveChanges();
            TakiminOyunculariniListele();
            lstTakimOyunculari.SelectedIndex = -1;
            cboOyuncuAd.SelectedIndex = -1;
        }

        private void cboTakimAdO_SelectedIndexChanged(object sender, EventArgs e)
        {
            TakiminOyunculariniListele();
            cboOyuncuAd.SelectedIndex = -1;
            lstTakimOyunculari.SelectedIndex = -1;
        }

        private void btnTakimOyuncuSil_Click(object sender, EventArgs e)
        {
            Team takim = (Team)cboTakimAdO.SelectedItem;
            Player oyuncu = (Player)lstTakimOyunculari.SelectedItem;
            if (takim == null || oyuncu == null)
            {
                MessageBox.Show("Lütfen takım adı ve kaldırılacak takım oyuncusunu seçiniz.");
                return;
            }
            takim.Players.Remove(oyuncu);
            db.SaveChanges();
            TakiminOyunculariniListele();
        }

        private void btnOyuncuIptal_Click(object sender, EventArgs e)
        {
            OyuncularTabResetle();
            duzenlenenOyuncu = null;
        }

        private void btnRenkIptal_Click(object sender, EventArgs e)
        {
            RenklerTabResetle();
            duzenlenenRenk = null;
        }

        private void chbMuzik_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMuzik.Checked)
            {
                chbMuzik.Text = "Sound Off";
                muzik.controls.play();
            }
            else
            {
                chbMuzik.Text = "Sound On";
                muzik.controls.stop();
            }
        }

        private void pboKarsilasmaEkle_Click(object sender, EventArgs e)
        {
            KarsilasmaFormAc();
        }

        private void KarsilasmaFormAc()
        {
            var karsilasmaForm = new KarsilasmaForm(db);
            karsilasmaForm.MacEklendi += KarsilasmaForm_MacEklendi;
            karsilasmaForm.ShowDialog();
        }

        private void KarsilasmaForm_MacEklendi(object sender, EventArgs e)
        {
            MaclariYukle();
        }

        private void MaclariYukle()
        {

            lviKarsilasma.Items.Clear();
            foreach (Match item in db.Matches.OrderByDescending(x => x.MatchTime).ToList())
            {
                ListViewItem lvi = new ListViewItem(item.MatchTime.ToShortDateString());
                if (item.Team1Id == null && item.Team2Id == null)
                {
                    lvi.SubItems.Add(item.MatchTime.ToShortTimeString());
                    lvi.SubItems.Add("?????");
                    lvi.SubItems.Add("?????");
                    lvi.SubItems.Add(item.Score1.ToString() + " - " + item.Score2.ToString());
                    lvi.SubItems.Add(item.Result.ToString());
                    lvi.Tag = item;
                    lviKarsilasma.Items.Add(lvi);
                }
                else if (item.Team1Id == null)
                {
                    lvi.SubItems.Add(item.MatchTime.ToShortTimeString());
                    lvi.SubItems.Add("?????");
                    lvi.SubItems.Add(item.Team2.TeamName.ToString());
                    lvi.SubItems.Add(item.Score1.ToString() + " - " + item.Score2.ToString());
                    lvi.SubItems.Add(item.Result.ToString());
                    lvi.Tag = item;
                    lviKarsilasma.Items.Add(lvi);
                }
                else if (item.Team2Id == null)
                {
                    lvi.SubItems.Add(item.MatchTime.ToShortTimeString());
                    lvi.SubItems.Add(item.Team1.TeamName.ToString());
                    lvi.SubItems.Add("?????");
                    lvi.SubItems.Add(item.Score1.ToString() + " - " + item.Score2.ToString());
                    lvi.SubItems.Add(item.Result.ToString());
                    lvi.Tag = item;
                    lviKarsilasma.Items.Add(lvi);
                }
                else
                {
                    lvi.SubItems.Add(item.MatchTime.ToShortTimeString());
                    lvi.SubItems.Add(item.Team1.TeamName.ToString());
                    lvi.SubItems.Add(item.Team2.TeamName.ToString());
                    lvi.SubItems.Add(item.Score1.ToString() + " - " + item.Score2.ToString());
                    lvi.SubItems.Add(item.Result.ToString());
                    lvi.Tag = item;
                    lviKarsilasma.Items.Add(lvi);
                }

            }
        }

        private void pboKarsilasmaSil_Click(object sender, EventArgs e)
        {

            if (lviKarsilasma.SelectedItems.Count == 1)
            {
                DialogResult dr = MessageBox.Show(
                    "Seçili karşılaşmayı silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    Match maclar = (Match)lviKarsilasma.SelectedItems[0].Tag;
                    db.Matches.Remove(maclar);
                    db.SaveChanges();
                    MaclariYukle();

                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz karşılaşmayı seçiniz.");
                return;
            }
        }
        Match duzenlenenMac;
        private void pboKarsilasmaDuzenle_Click(object sender, EventArgs e)
        {
            MaclariDuzenle();
        }

        private void lviKarsilasma_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MaclariDuzenle();
        }
        private void MaclariDuzenle()
        {
            if (lviKarsilasma.SelectedItems.Count == 1)
            {
                duzenlenenMac = (Match)lviKarsilasma.SelectedItems[0].Tag;
                var KarsilasmaForm2 = new KarsilasmaForm(duzenlenenMac, db);
                KarsilasmaForm2.MacEklendi += KarsilasmaForm2_MacEklendi;
                KarsilasmaForm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlenicek olan karşılaşmayı seçiniz.");
                return;
            }
        }

        private void KarsilasmaForm2_MacEklendi(object sender, EventArgs e)
        {
            MaclariYukle();
        }

        private void chbFiltre_CheckedChanged(object sender, EventArgs e)
        {
            lviKarsilasma.Items.Clear();
            if (!chbFiltre.Checked)
            {
                MaclariYukle();
            }
            else
            {
                FiltreliMaclar();
            }
        }

        private void FiltreliMaclar()
        {
            foreach (Match item in db.Matches.Where(x => x.Result != MatchResult.Belli_Degil).OrderByDescending(x => x.MatchTime).ToList())
            {
                ListViewItem lvi = new ListViewItem(item.MatchTime.ToShortDateString());
                if (item.Team1Id == null && item.Team2Id == null)
                {
                    lvi.SubItems.Add(item.MatchTime.ToShortTimeString());
                    lvi.SubItems.Add("?????");
                    lvi.SubItems.Add("?????");
                    lvi.SubItems.Add(item.Score1.ToString() + " - " + item.Score2.ToString());
                    lvi.SubItems.Add(item.Result.ToString());
                    lvi.Tag = item;
                    lviKarsilasma.Items.Add(lvi);
                }
                else if (item.Team1Id == null)
                {
                    lvi.SubItems.Add(item.MatchTime.ToShortTimeString());
                    lvi.SubItems.Add("?????");
                    lvi.SubItems.Add(item.Team2.TeamName.ToString());
                    lvi.SubItems.Add(item.Score1.ToString() + " - " + item.Score2.ToString());
                    lvi.SubItems.Add(item.Result.ToString());
                    lvi.Tag = item;
                    lviKarsilasma.Items.Add(lvi);
                }
                else if (item.Team2Id == null)
                {
                    lvi.SubItems.Add(item.MatchTime.ToShortTimeString());
                    lvi.SubItems.Add(item.Team1.TeamName.ToString());
                    lvi.SubItems.Add("?????");
                    lvi.SubItems.Add(item.Score1.ToString() + " - " + item.Score2.ToString());
                    lvi.SubItems.Add(item.Result.ToString());
                    lvi.Tag = item;
                    lviKarsilasma.Items.Add(lvi);
                }
                else
                {
                    lvi.SubItems.Add(item.MatchTime.ToShortTimeString());
                    lvi.SubItems.Add(item.Team1.TeamName.ToString());
                    lvi.SubItems.Add(item.Team2.TeamName.ToString());
                    lvi.SubItems.Add(item.Score1.ToString() + " - " + item.Score2.ToString());
                    lvi.SubItems.Add(item.Result.ToString());
                    lvi.Tag = item;
                    lviKarsilasma.Items.Add(lvi);
                }

            }
        }
    }
}
