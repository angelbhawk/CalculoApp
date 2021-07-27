using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoAplicación
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Grafica gf;
        private Graphics gp;

        private SolidBrush s;
        private Pen p;
        private Color Blue, White = Color.White;

        public Form()
        {
            InitializeComponent();

            p = new Pen(White);
            s = new SolidBrush(White);

            gf = new Grafica(600, 600, new int[] { 1, 1, 1, 1 });
            pnlGrf.Controls.Add(gf);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcularCilindro();
            for (int gh = 10; gh > 0; gh--)
            {
                gf.Refresh();
                Thread.Sleep(500);
            }
        }

        private void calcularCilindro()
        {
            tbxRes.Text = " ";
            //La bomba extrae medio metro cubico por minuto
            double radio = double.Parse(tbxRadio.Text);
            radio = radio * -1;
            string[] aux;
            double res;
            if (tbxCapa.Text.Contains("/"))
            {
                aux = tbxCapa.Text.Split(new char[] { '/' }, 2);
                res = double.Parse(aux[0]) / double.Parse(aux[1]);
            }
            else
            {
                res = double.Parse(tbxCapa.Text);
            }
            double Volumen = Math.PI * (Math.Pow(radio, 2)) * res;
            double dydt = 1 / Volumen * res;

            //label3.Text = Volumen.ToString();
            tbxRes.Text = dydt.ToString();
        }
    }
}