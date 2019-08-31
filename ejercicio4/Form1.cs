using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double nota1x = double.Parse(nota1.Text);
            double nota2x = double.Parse(nota2.Text);
            double nota3x = double.Parse(nota3.Text);

            double promedio = (nota1x + nota2x + nota3x) / 3;

            promediototal.Text = promedio.ToString();
        }
    }
}
