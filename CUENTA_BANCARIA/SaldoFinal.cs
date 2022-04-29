using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUENTA_BANCARIA
{
    class SaldoFinal
    {
        public List<Variables> ListCuenta { get; set; }
        public int NoRegistros { get; set; }

        // RECIBE ÑAS MENSUALIDADES DE DEPOSITOS QUE HARA Y SE CALCULA EL VALOR DEPENDIENDO DE SU INTERES
        public decimal SaldoTotal(decimal DepositoInicial, decimal DepositoAhorro, int Mensualidades, double Interes)
        {
            //ListCuenta = new List<Variables>();
            decimal TasaInt = 0;
            decimal suma = 0;
            decimal valor = 0;
            NoRegistros = Mensualidades;
            for (int i = 1; i <= Mensualidades; i++)
            {
                valor += DepositoInicial + DepositoAhorro + TasaInt;
                TasaInt = valor * Convert.ToDecimal(Interes);
                suma = valor + TasaInt;
                //ListCuenta.Add(new Variables() { Saldo = valor, TasaInteres = TasaInt, SaldoInteres = suma });
                DepositoInicial = 0;
            }
            return Math.Round(suma, 4);
        }

        //public List<Variables> Parametros() 
        //{
        //   return ListCuenta;
        //}
        //public int ItemMensl()
        //{
        //    return NoRegistros;
        //}

    }
}
