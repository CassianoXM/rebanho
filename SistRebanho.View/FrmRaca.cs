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
    public partial class FrmRaca : Form
    {
        private bool Incluir = true;
        RACA _Raca = null;
        RACA oRaca = new RACA();

        public FrmRaca()
        {
            InitializeComponent();
        }
        private void FrmRaca_Load(object sender, EventArgs e)
        {
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRaca_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).mnuraça.Enabled = true;
        }
    }
}
