using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SistRebanho.Model.Helper
{
    public partial class Mensagens
    {
        public static void MsgExcluido()
        {
            MessageBox.Show(Constantes.MsgExcluido, "Controle Leiteiro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void MsgAlterado()
        {
            MessageBox.Show(Constantes.MsgAlteracao, "Controle Leiteiro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void MsgIncluido()
        {
            MessageBox.Show(Constantes.MsgInclusao, "Controle Leiteiro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void MsgLoginInvalidos()
        {
            MessageBox.Show("Login ou Senha invalidos ! Por favor, tente novamente.", "Controle Leiteiro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult MsgPerguntaExclusao()
        {
            return MessageBox.Show(Constantes.MsgExclusao, "Controle Leiteiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void MsgRegInexistente()
        {
            MessageBox.Show("Registro Inexistente!", "Controle Leiteiro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MsgAmigoNomeDigitado()
        {
            MessageBox.Show(Constantes.MsgNomeDigitado, "Controle Leiteiro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
