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
    public partial class FrmSupprimer : Form
    {
        public FrmSupprimer()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void FrmSupprimer_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gsbrapports2016DataSet3.famille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.familleTableAdapter.Fill(this.gsbrapports2016DataSet3.famille);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new gsbrapports2016E())
            {
                var Suppfamille  = new famille
                {

                    libelle = Txtsupp.Text
                };

                context.familles.Add(Suppfamille);
                context.SaveChanges();

                MessageBox.Show("La famille a été supprimer avec succès dans la base de données !");


            }
        }
    }
}
