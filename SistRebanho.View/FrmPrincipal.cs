using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistRebanho.View;
using SistRebanho.Model;


namespace SistRebanho.View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void mnuraça_Click(object sender, EventArgs e)
        {
            FrmRaca oFrm = new FrmRaca();
            oFrm.MdiParent = this;
            oFrm.Show();
            mnuraça.Enabled = false;
        }

        private void mnuRebanho_Click(object sender, EventArgs e)
        {
            FrmRebanho oFrm = new FrmRebanho();
            oFrm.MdiParent = this;
            oFrm.Show();
            mnuRebanho.Enabled = false;
        }

        private void mnuVacina_Click(object sender, EventArgs e)
        {
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void mnuCobertura_Click(object sender, EventArgs e)
        {
        }

        private void mnuPesagem_Click(object sender, EventArgs e)
        {

        }

        private void mnuManejo_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
