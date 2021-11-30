using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFinal44.Code.DAL;
using ProjetoFinal44.Code.DTO;
using System.Data;

namespace ProjetoFinal44.Code.BLL
{
    class DadosBLL
    {
        Conexao x = new Conexao();
        string tabela = "dados";

        public void Inserir(DadosDTO DTO)
        {
            string inserir = $"insert into {tabela} values(null, '{DTO.Wpaj}', '{DTO.W12}', '{DTO.J18}')";
            x.ExecutarComando(inserir);
        }

        public void Alterar(DadosDTO DTO)
        {
            string alterar = $@"update {tabela} set wpaj = '{DTO.Wpaj}',
                                w12 ='{DTO.W12}',
                                j18 ='{DTO.J18}' where id ='{DTO.Id}';";
            x.ExecutarComando(alterar);
        }

        public void Excluir(DadosDTO DTO)
        {
            string excluir = $"delete from {tabela} where id = {DTO.Id}";
            x.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string listar = $"select * from {tabela} order by id";
            return x.ExecutarConsulta(listar);
        }
    }
}
