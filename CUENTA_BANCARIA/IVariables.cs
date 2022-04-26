using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTA_BANCARIA
{
    class IVariables
    {
        public List<IVariables> ListCuenta { get; set; }
        public int NoRegistros { get; set; }
        public decimal Saldo { get; set; }
        public decimal TasaInteres { get; set; }
        public decimal SaldoInteres { get; set; }
    }
}
