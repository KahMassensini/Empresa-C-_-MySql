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
    public partial class FrmTelaPrincipal : Form
    {
        Conexao con;
        Usuario user;

        public FrmTelaPrincipal()
        {            
            InitializeComponent();
            con = new Conexao();
            user = new Usuario();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void btnCsetor_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmSetor setor = new FrmSetor();
            setor.Show();
        }

        private void setorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmSetor setor = new FrmSetor();
            setor.Show();
        }


        private void btnCfunc_Click(object sender, EventArgs e)
        {

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void btnRfunc_Click(object sender, EventArgs e)
        {

        }

        private void funçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }



    }
}
