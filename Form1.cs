using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int counter = 0;
            double sum = 0;
            double summand = 0.0;
            double x;
            double precision;
            bool f = false;
            if (double.TryParse(txtPrecision.Text, out precision))
            {
                f = true;
            }
            do
            {
                counter++;
                if ( double.TryParse(txtX.Text, out x ) )
                {
                    f = true;
                    summand = double.Parse(txtX.Text) / counter;
                }
                sum += summand;
                
            } while (f &&Math.Abs(summand) > precision );
            if (f)
            {
                ibiResult.Text = "Сумма = " + sum + ", Количество = " + counter;
            }
            else
                MessageBox.Show("Введите числовое значение!");
        }
    }
}
