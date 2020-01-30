using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace empresa
{
    public partial class FrmLogin : Form
    {
        Conexao con;
        Usuario user;

        public FrmLogin()
        {            
            InitializeComponent();
            con = new Conexao();
            user = new Usuario();
        }

        private void lerDados()
        {
            user.User = txtNome.Text.Trim();
            user.Senha = txtSenha.Text.Trim();                      
                    
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            lerDados();
            String Cryp = CryHash.ComputeSha256Hash(user.Senha);
            con.OpenConnection();
            String sql = $"select * from tb_usuario where usuario = {user.User} and senha {Cryp} and status = true";

            MySqlDataReader reader;

            reader = con.executeQuery(sql);

            if (reader.Read())
            {
                MessageBox.Show("Logou com sucesso!");
            }
            else
            {
                MessageBox.Show("Não logou!");
            }
        }
    }
}
