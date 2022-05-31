using PI_zadatak.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_zadatak
{
    public partial class frmEvidencije : Form
    {
        public frmEvidencije()
        {
            InitializeComponent();
        }

        private void Evidencije_Load(object sender, EventArgs e)
        {
            showZaposlenik();
        }

        private void showZaposlenik()
        {
            var zaposlenik = Zaposlenik_CIP_Repozitorij.GetZaposlenik();
            dgvEvidencija.DataSource = zaposlenik;

            dgvEvidencija.Columns["Id"].DisplayIndex = 0;
            dgvEvidencija.Columns["FirstName"].DisplayIndex = 1;
            dgvEvidencija.Columns["LastName"].DisplayIndex = 2;

        }

        private void bntKreiranjeEvidencije_Click(object sender, EventArgs e)
        {
            var frmEvidencija_Posudbe = new frmEvidencija_Posudbe();
            frmEvidencija_Posudbe.ShowDialog();
        }
    }
}
