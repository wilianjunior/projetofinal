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
    public partial class FrmDados : Form
    {

        DadosBLL BLL = new DadosBLL();
        DadosDTO DTO = new DadosDTO();
        public FrmDados()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DTO.Wpaj = txtWPAJ.Text;
            DTO.W12 = txtW12.Text;
            DTO.J18 = txtA18.Text;

            BLL.Inserir(DTO);

            txtWPAJ.Clear();
            txtW12.Clear();
            txtA18.Clear();

            dtgDados.DataSource = BLL.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DTO.Id = int.Parse(txtID.Text);
            DTO.Wpaj = txtWPAJ.Text;
            DTO.W12 = txtW12.Text;
            DTO.J18 = txtA18.Text;

            BLL.Alterar(DTO);

            txtID.Clear();
            txtWPAJ.Clear();
            txtW12.Clear();
            txtA18.Clear();

            dtgDados.DataSource = BLL.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DTO.Id = int.Parse(txtID.Text);

            BLL.Excluir(DTO);

            txtID.Clear();

            dtgDados.DataSource = BLL.Listar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgDados.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtWPAJ.Text = dtgDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtW12.Text = dtgDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtA18.Text = dtgDados.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void FrmDados_Load(object sender, EventArgs e)
        {
            dtgDados.DataSource = BLL.Listar();
        }
    }
}
