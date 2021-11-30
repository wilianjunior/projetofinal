using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoFinal44.Code.DTO;
using ProjetoFinal44.Code.BLL;

namespace ProjetoFinal44.Ui
{
    public partial class FrmLogin : Form
    {
        UsuarioBLL BLL = new UsuarioBLL();
        UsuarioDTO DTO = new UsuarioDTO();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DTO.Email = txtEmail.Text;
            DTO.Cpf = txtCpf.Text;
            DTO.Senha = txtSenha.Text;

            if (BLL.Log(DTO) == true)
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos!");
            }
        }
    }
}
