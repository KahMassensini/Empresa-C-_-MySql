using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresa
{
    public partial class FrmSetor : Form, ICadForm
    {
        FrmSetor objSetor;
        Conexao con;

        public FrmSetor()
        {
            InitializeComponent();
        }

        // MenuStrip

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmTelaPrincipal principal = new FrmTelaPrincipal();
            principal.Show();
        }

        // Bottons

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
            //con.conectar();
            desbloquearCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        //metodos dos bottons

        public void lerDados()
        {
            objSetor = new FrmSetor();

            
        }

        public void limparCampos()
        {
            txtId.Text = "" ;
            txtNome.Text = "" ;
            cmbStatus.Text = "" ;
        }

        public void desbloquearCampos()
        {
            txtId.ReadOnly = false;
            txtNome.ReadOnly = false;
            cmbStatus.Enabled = true;
        }

        public void bloquearCampos()
        {
            txtId.ReadOnly = true;
            txtNome.ReadOnly =true;
            cmbStatus.Enabled = false;
        }

        public void atualizarGrid()
        {

        }
    }
}
