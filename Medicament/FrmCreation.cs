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
    
    public partial class FrmCreation : Form
    {
        public FrmCreation()
        {
          
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new gsbrapports2016E())
            {
                var nouvelFamille = new famille
                {
                    // Tentez un ID très différent (par exemple 'Z99')
                    id = "Z99",
                    libelle = "dupont",
                };

                context.familles.Add(nouvelFamille);
                context.SaveChanges();
            }
        }
    }
}



