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
using SistRebanho.Model;
using SistRebanho.Control;
using SistRebanho.Model.Helper;

namespace SistRebanho.View
{
    public partial class FrmRaca : Form
    {
        private CRaca _Control = new CRaca();
        RACA _Raca = null;
        RACA oRaca = new RACA();

        public FrmRaca()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRaca_Load(object sender, EventArgs e)
        {
            GrdRaca.DataSource = _Control.SelecionarTodos();
        }

        private void FrmRaca_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).mnuraça.Enabled = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            oRaca.raca = TxtRaca.Text;
            _Control.Incluir(oRaca);
            Mensagens.MsgIncluido();
            TxtRaca.Text = "";
            GrdRaca.DataSource = _Control.SelecionarTodos();


        }
    }
}
