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
        public FrmModifier(gsbrapports2016E mesDonnees)
        {
            InitializeComponent();
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

        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. On valide les modifications effectuées dans la grille
                this.familleBindingSource.EndEdit();

                // 2. On envoie les modifications à la base de données
                this.familleTableAdapter.Update(this.gsbrapports2016DataSet4.famille);

                MessageBox.Show("Enregistrement réussi !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
            }
        }

        private void FrmModifier_Load_1(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gsbrapports2016DataSet5.famille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.familleTableAdapter1.Fill(this.gsbrapports2016DataSet5.famille);

        }
    }
}