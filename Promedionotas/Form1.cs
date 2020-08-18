using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedionotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            double nota1, nota2, nota3, resultado, Suma;
            nota1 =  double.Parse(txtnota1.Text);
            nota2 =  double.Parse(txtnota2.Text);
            nota3 =  double.Parse(txtnota3.Text);

            Suma = nota1 + nota2 + nota3;

            resultado = Suma / 3;

            lblresultado.Text = Convert.ToString(resultado);

            label5.Visible = true;
            lblresultado.Visible = true;
           
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnota1.Text = string.Empty;
            txtnota2.Text = string.Empty;
            txtnota3.Text = string.Empty;
            label5.Visible = false;
            lblresultado.Visible = false;
            txtnota1.Focus();
        }
    }
}
