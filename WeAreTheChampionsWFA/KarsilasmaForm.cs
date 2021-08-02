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
    public partial class KarsilasmaForm : Form
    {
        public event EventHandler MacEklendi;
        private readonly ProjectContext db;
        private Match matches;
        public KarsilasmaForm()
        {

        }
        public KarsilasmaForm(ProjectContext db)
        {
            this.db = db;
            InitializeComponent();
            TakimlariListele();
        }
        public KarsilasmaForm(Match matches, ProjectContext db)
        {
            this.matches = matches;
            this.db = db;
            InitializeComponent();
            DuzenleArayuzOlustur();
        }

        private void DuzenleArayuzOlustur()
        {
            cboTakim1.DisplayMember = "TeamName";
            cboTakim2.DisplayMember = "TeamName";
            cboTakim1.DataSource = db.Teams.ToList();
            cboTakim2.DataSource = db.Teams.ToList();
            dtpMacTime.Value = matches.MatchTime;
            cboTakim1.Text = matches.Team1.TeamName.ToString();
            cboTakim2.Text = matches.Team2.TeamName.ToString();
            mtbSkor1.Text = matches.Score1.ToString();
            mtbSkor2.Text = matches.Score2.ToString();
            btnIptal.Visible = true;
            btnEkle.Text = "KAYDET";
        }

        private void FormuResetle()
        {
            cboTakim1.SelectedIndex = cboTakim2.SelectedIndex = -1;
            mtbSkor1.Clear();
            mtbSkor2.Clear();
            btnIptal.Visible = false;
            btnEkle.Text = "EKLE";
        }

        private void TakimlariListele()
        {
            cboTakim1.DisplayMember = "TeamName";
            cboTakim2.DisplayMember = "TeamName";
            cboTakim1.DataSource = db.Teams.ToList();
            cboTakim2.DataSource = db.Teams.ToList();
            FormuResetle();
        }

        private MatchResult Sonuc()
        {
            int? a = mtbSkor1.Text == "" ? null as int? : Convert.ToInt32(mtbSkor1.Text.Trim());
            int? b = mtbSkor2.Text == "" ? null as int? : Convert.ToInt32(mtbSkor2.Text.Trim());
            if (a > b)
            {
                return MatchResult.Team1_Kazandi;
            }
            else if (b>a)
            {
                return MatchResult.Team2_Kazandi;
            }
            else if (a==b && a != null && b != null)
            {
                return MatchResult.Berabere;
            }
            else
            {
                return MatchResult.Belli_Degil;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
                var takim1 = (Team)cboTakim1.SelectedItem;
                var takim2 = (Team)cboTakim2.SelectedItem;
            if (matches==null)
            {
                if (takim1 == null || takim2 == null)
                {
                    MessageBox.Show("Lütfen karşılaşma oluşturmak için takımları seçiniz.");
                    return;
                }
                else if (takim1.Id == takim2.Id)
                {
                    MessageBox.Show("Karşılaşmalar iki farklı takım arasında olmalıdır,Lütfen iki farklı takim seçiniz. ");
                    return;
                }

                db.Matches.Add(new Match()
                {
                    MatchTime = dtpMacTime.Value,
                    Team1Id = takim1.Id,
                    Team2Id = takim2.Id,
                    Score1 = mtbSkor1.Text == "" ? null as int? : Convert.ToInt32(mtbSkor1.Text),
                    Score2 = mtbSkor2.Text == "" ? null as int? : Convert.ToInt32(mtbSkor2.Text),
                    Result = Sonuc()
                });
                FormuResetle();
            }
            else
            {
                if (takim1 == null || takim2 == null)
                {
                    MessageBox.Show("Lütfen karşılaşma oluşturmak için takımları seçiniz.");
                    return;
                }
                else if (takim1.Id == takim2.Id)
                {
                    MessageBox.Show("Karşılaşmalar iki farklı takım arasında olmalıdır,Lütfen iki farklı takim seçiniz. ");
                    return;
                }

                matches.MatchTime = dtpMacTime.Value;
                matches.Team1Id = takim1.Id;
                matches.Team2Id = takim2.Id;
                matches.Score1 = mtbSkor1.Text == "" ? null as int? : Convert.ToInt32(mtbSkor1.Text);
                matches.Score2 = mtbSkor2.Text == "" ? null as int? : Convert.ToInt32(mtbSkor2.Text);
                matches.Result = Sonuc();
            }
            db.SaveChanges();
            MacEklendiginde(EventArgs.Empty);
            Close();
        }

        protected virtual void MacEklendiginde(EventArgs args)
        {
            if (MacEklendi !=null)
            {
                MacEklendi(this, args);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
            Close();
        }
    }
}
