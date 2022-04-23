using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTA_BANCARIA
{
    class Cuenta_Bancaria
    {
        public decimal Resultado = 0;

        public void CuentaBancaria(double Interes, string Composicion, string Periodo, decimal DepositoInicial, decimal DepositoAhorro)
        {
            CalcularCuenta calcularcuenta = new CalcularCuenta();
            double TasaIntere;
            switch (Composicion)
            {
                case "MENSUAL":
                    TasaIntere = Math.Round((Interes/100) / 12,5);
                    Resultado = calcularcuenta.CuentaAhorroMensual(TasaIntere, Periodo,DepositoInicial,DepositoAhorro);
                    break;
                case "SEMESTRAL":
                    TasaIntere = Math.Round((Interes / 100) / 2, 5);
                    Resultado = calcularcuenta.CuentaAhorroSemestral(TasaIntere, Periodo, DepositoInicial, DepositoAhorro);
                    break;
                case "ANUAL":
                    TasaIntere = Math.Round((Interes / 100), 5);
                    Resultado = calcularcuenta.CuentaAhorroAnual(TasaIntere, Periodo, DepositoInicial, DepositoAhorro);
                    break;
            }
        }
    }
}
