using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infra
{
    public class DadosPaginados
    {
        public int Pagina { get; set; }
        public int QuantidadePorPagina { get; set; }
        public dynamic Dados { get; set; }
        public int Total { get; set; }
    }
}
