using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresa.View
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



        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
