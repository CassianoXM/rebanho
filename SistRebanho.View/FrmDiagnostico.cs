using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebanho
{
    public partial class FrmDiagnostico : Form
    {
        public FrmDiagnostico()
        {
            InitializeComponent();
        }

        private void FrmDiagnostico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rebanhoDataSet.DIAGNOSTICO'. Você pode movê-la ou removê-la conforme necessário.
            this.dIAGNOSTICOTableAdapter.Fill(this.rebanhoDataSet.DIAGNOSTICO);
            // TODO: esta linha de código carrega dados na tabela 'rebanhoDiagnosticoDataBase.DIAGNOSTICO'. Você pode movê-la ou removê-la conforme necessário.

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

       
    }
}
