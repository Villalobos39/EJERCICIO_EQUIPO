using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUENTA_BANCARIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double SaldoTotal(double DepositoInicial, double DepositoAhorro, double Mensualidades, double Interes)
        {
            double TasaInt=0;
            double suma = 0;
            double valor=0;
            int contador = 1;
            for (int i = 1; i <= Mensualidades; i++)
            {
                int n = dataGV.Rows.Add(Mensualidades);
                valor += DepositoInicial + DepositoAhorro + TasaInt;
                TasaInt = valor*Interes;
                suma = valor + TasaInt;
                dataGV.Rows[n].Cells[0].Value=contador++.ToString();
                dataGV.Rows[n].Cells[1].Value = Math.Round(valor, 4).ToString();
                dataGV.Rows[n].Cells[2].Value = Math.Round(TasaInt, 4).ToString();
                dataGV.Rows[n].Cells[3].Value = Math.Round(suma, 4).ToString();
                dataGV.Rows[n].Cells[4].Value= Math.Round((valor + TasaInt), 4).ToString();
                //contador = i++;
                DepositoInicial = 0;
            }
            return Math.Round(suma,4);

        }

        public void CuentaAhorro()
        {
            double DepositoInicial = 10000.00;
            double DepositoAhorro = 1000;
            double Interes = 0.00580333;
            int Meses = 12;
            int Mensualidades;
            double Total = 0;

            switch (PeriodoBox.Text)
            {
                case "1 AÑO":
                    Mensualidades = Meses;
                    Total= SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, Interes);
                    break; 
                case "2 AÑOS":
                    Mensualidades = Meses*2;
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, Interes);
                    break; 
                case "3 AÑOS":
                    Mensualidades = Meses*3;
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, Interes);
                    break; 
                case "4 AÑOS":
                    Mensualidades = Meses*4;
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, Interes);
                    break; 
                case "5 AÑOS":
                    Mensualidades = Meses*5;
                    Total = SaldoTotal(DepositoInicial, DepositoAhorro, Mensualidades, Interes);
                    break;
            }
            SaldoFinal.Text = Total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CuentaAhorro();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CuotaTxt.Text = "00.00";
            IncialTxt.Text = "00.00";
            SaldoFinal.Text = "00.00";
            ResetText();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
