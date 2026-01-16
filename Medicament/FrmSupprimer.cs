using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medicament
{
    public partial class FrmSupprimer : Form
    {
        private gsbrapports2016E mesDonneesEF;
        public FrmSupprimer(gsbrapports2016E mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualiserListe();
        }
        private void ActualiserListe()
        {
            using (var context = new gsbrapports2016E()) // Ton contexte EF
            {
                var lesFamilles = context.familles.ToList();
                Txtsupp.DataSource = lesFamilles;
                Txtsupp.DisplayMember = "libelle"; // Affiche le nom
                Txtsupp.ValueMember = "id";        // Garde l'ID en valeur
            }
        }

        private void FrmSupprimer_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gsbrapports2016DataSet3.famille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.familleTableAdapter.Fill(this.gsbrapports2016DataSet3.famille);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txtsupp.SelectedValue == null) return;

            string idFamille = Txtsupp.SelectedValue.ToString();

            // Demander confirmation (important pour le BTS SIO)
            DialogResult reponse = MessageBox.Show("Voulez-vous supprimer cette famille ?", "Confirmation", MessageBoxButtons.YesNo);

            if (reponse == DialogResult.Yes)
            {
                try
                {
                    using (var context = new gsbrapports2016E())
                    {
                        // On cherche la famille par son ID
                        var laFamille = context.familles.Find(idFamille);

                        if (laFamille != null)
                        {
                            context.familles.Remove(laFamille);
                            context.SaveChanges(); // Enregistre la suppression

                            MessageBox.Show("Famille supprimée !");
                            ActualiserListe(); // Rafraîchit la liste après suppression
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Erreur si la famille est liée à des médicaments (contrainte SQL)
                    MessageBox.Show("Impossible de supprimer : cette famille contient des médicaments.");
                }
            }

        }
    }
}

