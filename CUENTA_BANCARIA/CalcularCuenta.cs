using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTA_BANCARIA
{
    class CalcularCuenta
    {
        SaldoFinal SaldoFinal = new SaldoFinal();
        public List<Variables> ListCuenta { get; set; }
        // UNA VEZ QUE RECIVIMOS LA COMPOSISCION EN LA QUE SE REALIZARA
        // SE APLICARA LA TASA DE INTERES A LO QUE LE CORRESPONDE 
        public decimal CuentaAhorroMensual(double Interes, string Periodo, decimal DepositoInicial, decimal DepositoAhorro)
        {
            int Mensualidades;
            int Meses = 12;
            decimal Total = 0;
       
            switch (Periodo)
            { 
                case "1 AÑO":
                    Mensualidades = Meses;
                    Total = SaldoFinal.SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, Interes);
                    break;
                case "2 AÑOS":
                    Mensualidades = Meses * 2;
                    Total = SaldoFinal.SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, Interes);
                    break;
                case "3 AÑOS":
                    Mensualidades = Meses * 3;
                    Total = SaldoFinal.SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, Interes);
                    break;
                case "4 AÑOS":
                    Mensualidades = Meses * 4;
                    Total = SaldoFinal.SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, Interes);
                    break;
                case "5 AÑOS":
                    Mensualidades = Meses * 5;
                    Total = SaldoFinal.SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, Interes);
                    break;
            }
            return Total;
        }

        public decimal CuentaAhorroSemestral(double Interes, string Periodo, decimal DepositoInicial, decimal DepositoAhorro)
        {
            int Semestres;
            decimal Total = 0;
            switch (Periodo)
            {
                case "1 AÑO":
                    Semestres = 2;
                    Total = SaldoFinal.SaldoTotal(DepositoInicial, DepositoAhorro, Semestres, Interes);
                    break;
                case "2 AÑOS":
                    Semestres = 4;
                    Total = SaldoFinal.SaldoTotal(DepositoInicial, DepositoAhorro, Semestres, Interes);
                    break;
                case "3 AÑOS":
                    Semestres = 6;
                    Total = SaldoFinal.SaldoTotal(DepositoInicial, DepositoAhorro, Semestres, Interes);
                    break;
                case "4 AÑOS":
                    Semestres = 8;
                    Total = SaldoFinal.SaldoTotal(DepositoInicial, DepositoAhorro, Semestres, Interes);
                    break;
                case "5 AÑOS":
                    Semestres=10;
                    Total = SaldoFinal.SaldoTotal(DepositoInicial, DepositoAhorro, Semestres, Interes);
                    break;
            }
            return Total;
        }

        public decimal CuentaAhorroAnual(double Interes, string Periodo, decimal DepositoInicial, decimal DepositoAhorro)
        {
            int Anual;
            decimal Total = 0;
            switch (Periodo)
            {
                case "1 AÑO":
                    Anual = 1;
                    Total = SaldoFinal.SaldoTotal(DepositoInicial, DepositoAhorro, Anual, Interes);
                    this.ListCuenta = SaldoFinal.ListCuenta;
                    break;
                case "2 AÑOS":
                    Anual = 2;
                    Total = SaldoFinal.SaldoTotal(DepositoInicial, DepositoAhorro, Anual, Interes);
                    this.ListCuenta = SaldoFinal.ListCuenta;
                    break;
                case "3 AÑOS":
                    Anual = 3;
                    Total = SaldoFinal.SaldoTotal(DepositoInicial, DepositoAhorro, Anual, Interes);
                    this.ListCuenta = SaldoFinal.ListCuenta;
                    break;
                case "4 AÑOS":
                    Anual = 4;
                    Total = SaldoFinal.SaldoTotal(DepositoInicial, DepositoAhorro, Anual, Interes);
                    this.ListCuenta = SaldoFinal.ListCuenta;
                    break;
                case "5 AÑOS":
                    Anual = 5;
                    Total = SaldoFinal.SaldoTotal(DepositoInicial, DepositoAhorro, Anual, Interes);
                    this.ListCuenta = SaldoFinal.ListCuenta;
                    break;
            }
            return Total;
        }

    }
}
