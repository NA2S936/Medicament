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
    
    public partial class FrmCreation : Form
    {
        private gsbrapports2016E mesDonneesEF;
        public FrmCreation(gsbrapports2016E mesDonnees)
        {
          
            InitializeComponent();
            this.mesDonneesEF = mesDonnees;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtLibelle.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            try
            {
                using (var context = new gsbrapports2016E())
                {
                    var nouvelFamille = new famille
                    {
                 
                        id = txtId.Text, 
                        libelle = txtLibelle.Text 
                    };

                    context.familles.Add(nouvelFamille);
                    context.SaveChanges();

                    MessageBox.Show("La famille a été enregistrée avec succès dans la base de données !");

                   
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
            }
        }
    }
    
}



