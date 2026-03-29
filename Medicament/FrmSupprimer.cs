using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Medicament
{
    public partial class FrmSupprimer : Form
    {
        // On utilise l'instance passée par le formulaire parent
        private gsbrapports2016E mesDonneesEF;

        public FrmSupprimer(gsbrapports2016E mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
        }

        // ÉVÉNEMENT LOAD : Se déclenche à l'ouverture de la fenêtre
        private void FrmSupprimer_Load(object sender, EventArgs e)
        {
            ActualiserListe();
        }

        // MÉTHODE POUR CHARGER/RAFRAICHIR LA COMBOBOX
        private void ActualiserListe()
        {
            // On récupère les familles triées par libellé pour que ce soit plus propre
            var lesFamilles = this.mesDonneesEF.familles.OrderBy(f => f.libelle).ToList();

            // On lie les données à la ComboBox
            Txtsupp.DataSource = lesFamilles;
            Txtsupp.DisplayMember = "libelle"; // Ce que l'utilisateur voit
            Txtsupp.ValueMember = "id";        // La valeur cachée (l'ID)

            // On force la sélection sur "rien" au départ si tu veux
            Txtsupp.SelectedIndex = -1;
        }

        // BOUTON SUPPRIMER
        private void button1_Click(object sender, EventArgs e)
        {
            // Vérification : est-ce qu'un élément est sélectionné ?
            if (Txtsupp.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une famille dans la liste.");
                return;
            }

            // On récupère l'ID de la famille sélectionnée
            string idFamille = Txtsupp.SelectedValue.ToString();

            // Confirmation (Standard BTS SIO)
            DialogResult reponse = MessageBox.Show("Voulez-vous vraiment supprimer cette famille ?",
                                                 "Confirmation",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (reponse == DialogResult.Yes)
            {
                try
                {
                    // On cherche l'objet dans le contexte
                    var laFamille = this.mesDonneesEF.familles.Find(idFamille);

                    if (laFamille != null)
                    {
                        this.mesDonneesEF.familles.Remove(laFamille);
                        this.mesDonneesEF.SaveChanges(); // Enregistrement en base

                        MessageBox.Show("Famille supprimée avec succès !");

                        // ON RAFRAICHIT ICI SEULEMENT
                        ActualiserListe();
                    }
                }
                catch (Exception)
                {
                    // Erreur si violation de clé étrangère (si la famille est liée à un médicament)
                    MessageBox.Show("Impossible de supprimer : cette famille est utilisée par des médicaments existants.",
                                    "Erreur de contrainte",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        // IMPORTANT : L'événement SelectedIndexChanged doit rester VIDE 
        // ou être supprimé pour ne pas casser la sélection.
        private void Txtsupp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ne rien mettre ici pour le chargement des données.
        }
    }
}