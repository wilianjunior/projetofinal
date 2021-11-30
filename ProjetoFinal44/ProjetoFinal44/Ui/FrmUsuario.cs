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
    public partial class FrmUsuario : Form
    {
        UsuarioBLL BLL = new UsuarioBLL();
        UsuarioDTO DTO = new UsuarioDTO();
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DTO.Nome = txtNome.Text;
            DTO.Telefone = txtTelefone.Text;
            DTO.Rua = txtRua.Text;
            DTO.Numero = txtNumero.Text;
            DTO.Bairro = txtBairro.Text;
            DTO.Cidade = txtCidade.Text;
            DTO.Estado = txtEstado.Text;
            DTO.Pais = txtPais.Text;
            DTO.Cpf = txtCPF.Text;
            DTO.Rg = txtRG.Text;
            DTO.Datanascimento = dtDataNascimento.Text;
            DTO.Email = txtEmail.Text;
            DTO.Senha = txtSenha.Text;

            BLL.Inserir(DTO);

            txtNome.Clear();
            txtTelefone.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtPais.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            txtEmail.Clear();
            txtSenha.Clear();

            dtgUsuarios.DataSource = BLL.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DTO.Id = int.Parse(txtId.Text);
            DTO.Nome = txtNome.Text;
            DTO.Telefone = txtTelefone.Text;
            DTO.Rua = txtRua.Text;
            DTO.Numero = txtNumero.Text;
            DTO.Bairro = txtBairro.Text;
            DTO.Cidade = txtCidade.Text;
            DTO.Estado = txtEstado.Text;
            DTO.Pais = txtPais.Text;
            DTO.Cpf = txtCPF.Text;
            DTO.Rg = txtRG.Text;
            DTO.Datanascimento = dtDataNascimento.Text;
            DTO.Email = txtEmail.Text;
            DTO.Senha = txtSenha.Text;

            BLL.Alterar(DTO);

            txtId.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtPais.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            txtEmail.Clear();
            txtSenha.Clear();

            dtgUsuarios.DataSource = BLL.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DTO.Id = int.Parse(txtId.Text);

            BLL.Excluir(DTO);

            txtId.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtPais.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            txtEmail.Clear();
            txtSenha.Clear();

            dtgUsuarios.DataSource = BLL.Listar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            dtgUsuarios.DataSource = BLL.Listar();
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                txtId.Text = dtgUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dtgUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTelefone.Text = dtgUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtRua.Text = dtgUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNumero.Text = dtgUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtBairro.Text = dtgUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCidade.Text = dtgUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtEstado.Text = dtgUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtPais.Text = dtgUsuarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtCPF.Text = dtgUsuarios.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtRG.Text = dtgUsuarios.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtEmail.Text = dtgUsuarios.Rows[e.RowIndex].Cells[12].Value.ToString();
                txtSenha.Text = dtgUsuarios.Rows[e.RowIndex].Cells[13].Value.ToString();
        }
    }
}
