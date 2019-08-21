using System;
using System.IO;
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
using SistRebanho;

namespace SistRebanho.View
{
    public partial class FrmRebanho : Form
    {
        public FrmRebanho()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRebanho_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).mnuRebanho.Enabled = true;
        }

        private void FrmRebanho_Load(object sender, EventArgs e)
        {

        }
    }
}
