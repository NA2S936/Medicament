using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicament
{
    public partial class FrmInfo : Form
    {
        private string idFamille;

        // Nouveau constructeur qui reçoit l'ID
        public FrmInfo(string idFamilleRecu)
        {
            InitializeComponent();
            this.idFamille = idFamilleRecu;
        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {
            using (var context = new gsbrapports2016E())
            {
                // C'est ici qu'on fait le filtrage (le lien/la "concaténation" logique)
                // On ne prend que les médicaments dont l'idFamille correspond à celui reçu
                var listeFiltree = context.medicaments
                                          .Where(m => m.idFamille == this.idFamille)
                                          .ToList();

                // On affiche le résultat dans ton DataGridView (ex: dataGridView1)
                dataGridView1.DataSource = listeFiltree;
            }
        }
    }
}