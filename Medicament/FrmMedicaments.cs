using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicament
{
  
    public partial class FrmMedicaments : Form
    {
        private gsbrapports2016E mesDonnees = new gsbrapports2016E();
        public FrmMedicaments(gsbrapports2016E mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonnees = mesDonneesEF;
        }

        

         private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new gsbrapports2016E())
                {
                    // Récupérer la liste des familles depuis la base de données
                    var listeFamilles = context.familles.ToList();

                    // Lier la liste à la ComboBox
                    comboBox1.DataSource = listeFamilles;
                    comboBox1.DisplayMember = "libelle"; // Ce qui est affiché (nom de la famille)
                    comboBox1.ValueMember = "id";        // La valeur cachée (l'identifiant)
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des familles : " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // On vérifie qu'une famille est sélectionnée
            if (comboBox1.SelectedValue != null)
            {
                // On récupère l'ID de la famille (ex: "ADL")
                string idFamilleSelectionnee = comboBox1.SelectedValue.ToString();

                // On ouvre FrmInfo en lui passant cet ID
                FrmInfo frmInfo = new FrmInfo(idFamilleSelectionnee);
                frmInfo.Show();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une famille d'abord.");
            }
        }   

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
