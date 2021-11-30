using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal44.Code.DTO
{
    class DadosDTO
    {
        private int _id;
        private string _wpaj;
        private string w12;
        private string j18;

        public int Id { get => _id; set => _id = value; }
        public string Wpaj { get => _wpaj; set => _wpaj = value; }
        public string W12 { get => w12; set => w12 = value; }
        public string J18 { get => j18; set => j18 = value; }
    }
}
