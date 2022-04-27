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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal DepositoInicial = Convert.ToDecimal(MontoInicial.Text);
                decimal DepositoAhorro = Convert.ToDecimal(CuotaTxt.Text);
                int Periodo =Convert.ToInt32(PeriodoBox.Value);
                string Composicion = ComposicionBox.Text;
                double PorcentajeIntere = Convert.ToDouble(InteresTxt.Text);
                Cuenta_Bancaria cuenta_Bancaria = new Cuenta_Bancaria(PorcentajeIntere, Composicion, Periodo, DepositoInicial, DepositoAhorro);

                // CALCULAR INGRESOS ES EL SALDO TOTAL DE SU CUENTA DE AHORRO 
                // ENVIAMOS LOS PARAMENTROS DE PORCENTANJE , LA COMPOSICION , EL PERIDO Y LOS DEPOSISTOS 
                cuenta_Bancaria.CalcularIngresos();
                //Metodo();
                MostrarLista(cuenta_Bancaria.ListCuenta);
                SaldoFinal_Label.Text = Math.Round(cuenta_Bancaria.Resultado,2).ToString();
                Incial_Label.Text = DepositoInicial.ToString();
                Interes_Label.Text =PorcentajeIntere.ToString();
                NombreLabel.Text = NombreTxt.Text;

            }
            catch (Exception)
            {
                ResetText();
            }
            

        }

        private void MostrarLista(List<Variables> lista)
        {
            int cont = 1;
            foreach (var item in lista)
            {

                int n = dataGV.Rows.Add(lista.Count);
                dataGV.Rows[n].Cells[0].Value = cont++.ToString();
                dataGV.Rows[n].Cells[1].Value = item.Saldo.ToString();
                dataGV.Rows[n].Cells[2].Value = item.SaldoInteres.ToString();  // Math.Round(valor, 4).ToString();
                dataGV.Rows[n].Cells[3].Value = item.TasaInteres.ToString();
            }
        }

        public decimal SaldoTotalPrueba(decimal DepositoInicial, decimal DepositoAhorro, int Mensualidades, double Interes)
        {
            decimal TasaInt = 0;
            decimal suma = 0;
            decimal valor = 0;
            int contador = 1;
            for (int i = 1; i <= Mensualidades; i++)
            {
                int n = dataGV.Rows.Add(Mensualidades);
                valor += DepositoInicial + DepositoAhorro + TasaInt;
                TasaInt = valor * Convert.ToDecimal(Interes);
                suma = valor + TasaInt;
                dataGV.Rows[n].Cells[0].Value = contador++.ToString();
                dataGV.Rows[n].Cells[1].Value = Math.Round(valor, 4).ToString();
                dataGV.Rows[n].Cells[2].Value = Math.Round(TasaInt, 4).ToString();
                dataGV.Rows[n].Cells[3].Value = Math.Round(suma, 4).ToString();
                DepositoInicial = 0;
            }
            return Math.Round(suma, 4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CuotaTxt.Text = "00.00";
            Incial_Label.Text = "00.00";
            SaldoFinal_Label.Text = "00.00";
            Application.Restart();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

//ListCuenta.Add(new IVariables() { Saldo = valor, TasaInteres = TasaInt, SaldoInteres = suma });

//for (int i = 1; i <= final.ListCuenta.Count; i++)
//{
//    int n = dataGV.Rows.Add(final.NoRegistros);
//    dataGV.Rows[n].Cells[0].Value = contador++.ToString();
//    dataGV.Rows[n].Cells[1].Value = final.ListCuenta[i].Saldo.ToString();
//    dataGV.Rows[n].Cells[2].Value = final.ListCuenta[i].TasaInteres.ToString();
//    dataGV.Rows[n].Cells[3].Value = final.ListCuenta[i].SaldoInteres.ToString();
//    i++;
//}
