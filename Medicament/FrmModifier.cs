using System;
using System.Windows.Forms;

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
    public partial class FrmModifier : Form
    {
        gsbrapports2016E mesDonnees;
        public FrmModifier(gsbrapports2016E mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            familleBindingSource.DataSource = mesDonnees.familles.ToList();
        }

        private void FrmModifier_Load(object sender, EventArgs e)
        {
            try
            {

                this.familleTableAdapter.Fill(this.gsbrapports2016DataSet4.famille);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            this.mesDonnees.SaveChanges();

            MessageBox.Show("La modification a bien été effectuée !", "Succès", MessageBoxButtons.OK);
        }
        

        
    }
}