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
    public partial class FrmInfo : Form
    {
        private gsbrapports2016E mesDonnees;
        public FrmInfo()
        {
            InitializeComponent();
            mesDonnees = new gsbrapports2016E();
            this.medicamentBindingSource.DataSource = mesDonnees.medicaments.ToList();
            this.dataGridView1.DataSource = medicamentBindingSource;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gsbrapports2016DataSet2.medicament'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.medicamentTableAdapter.Fill(this.gsbrapports2016DataSet2.medicament);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
