using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTA_BANCARIA
{
    class SaldoFinal
    {
        public decimal SaldoTotal(decimal DepositoInicial, decimal DepositoAhorro, int Mensualidades, double Interes)
        {
            decimal TasaInt = 0;
            decimal suma = 0;
            decimal valor = 0;
            for (int i = 1; i <= Mensualidades; i++)
            {
                valor += DepositoInicial + DepositoAhorro + TasaInt;
                TasaInt = valor * Convert.ToDecimal(Interes);
                suma = valor + TasaInt;
                DepositoInicial = 0;
            }
            return Math.Round(suma, 4);
        }
    }
}
