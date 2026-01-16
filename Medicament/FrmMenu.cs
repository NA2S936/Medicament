using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicament
{
    public partial class FrmMenu : Form
    {
        private gsbrapports2016E mesDonnees=new gsbrapports2016E();
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void selectionnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicaments frmMedicaments = new FrmMedicaments(mesDonnees);
            frmMedicaments.Show();

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreation frmCreation = new FrmCreation(mesDonnees);
            frmCreation.Show();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupprimer FrmSupprimer = new FrmSupprimer(mesDonnees);
            FrmSupprimer.Show();

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModifier FrmModifier = new FrmModifier(mesDonnees);
            FrmModifier.Show();

        }
    }
}
