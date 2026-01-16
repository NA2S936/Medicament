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
            // TODO: cette ligne de code charge les données dans la table 'gsbrapports2016DataSet4.famille'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.familleTableAdapter.Fill(this.gsbrapports2016DataSet4.famille);

        }
    }
}
