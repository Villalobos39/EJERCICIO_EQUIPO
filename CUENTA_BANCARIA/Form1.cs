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
                Cuenta_Bancaria cuenta_Bancaria = new Cuenta_Bancaria();
                decimal DepositoInicial = Convert.ToDecimal(MontoInicial.Text);
                decimal DepositoAhorro = Convert.ToDecimal(CuotaTxt.Text);
                string Periodo = PeriodoBox.Text;
                string Composicion = ComposicionBox.Text;
                double PorcentajeIntere = Convert.ToDouble(InteresTxt.Text);
         
                cuenta_Bancaria.CuentaBancaria(PorcentajeIntere, Composicion, Periodo, DepositoInicial, DepositoAhorro);

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

        private void button2_Click(object sender, EventArgs e)
        {
            CuotaTxt.Text = "00.00";
            Incial_Label.Text = "00.00";
            SaldoFinal_Label.Text = "00.00";
            ResetText();
        }

    }
}
