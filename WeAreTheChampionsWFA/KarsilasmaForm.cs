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
        private readonly ProjectContext db;
        public KarsilasmaForm(ProjectContext db)
        {
            this.db = db;
            InitializeComponent();
            TakimlariListele();
            FormuResetle();
        }

        private void FormuResetle()
        {
            cboTakim1.SelectedIndex = cboTakim2.SelectedIndex = -1;
            mtbSkor1.Clear();
            mtbSkor2.Clear();
        }

        private void TakimlariListele()
        {
            cboTakim1.DisplayMember = "TeamName";
            cboTakim2.DisplayMember = "TeamName";
            cboTakim1.DataSource = db.Teams.ToList();
            cboTakim2.DataSource = db.Teams.ToList();
        }
    }
}
