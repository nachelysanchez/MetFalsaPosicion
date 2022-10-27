using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetFalsaPosicion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            double raiz = 0;
            double fxl, fxu, xr =0, fxr;
            double xl = double.Parse(xlTXT.Text);

            double xu = double.Parse(xuTXT.Text);
            int i = 0;
            double fxlr;
            double ea = 0, et = 0;
            double xrAnterior;
            do
            {
                i++;
                fxl = 0.7 - Math.Log(Math.Pow(xl,2));
                fxu = 0.7 - Math.Log(Math.Pow(xu, 2));

                xrAnterior = xr;

                xr = xu - ((fxu * (xl - xu)) / ((fxl) - (fxu)));
                fxr = 0.7 - Math.Log(Math.Pow(xr, 2));

                fxlr = fxr * fxl;
                if (i != 1)
                {
                    ea = Math.Abs((xr - xrAnterior) / xr) * 100;
                    et = ((1 - (Math.Abs(xr))) * 100);
                }
                FalsaPosiciondtg.Rows.Add(i, xl, xu, fxu, fxl, xr, fxr, fxlr, ea, et);

                if (fxl> 0 && fxr > 0)
                {
                    xl = xr;
                }
                if (fxl>0 && fxr < 0)
                {
                    xu = xr;
                }
                if(fxl < 0 && fxr < 0)
                {
                    xl = xr;
                }
                if (ea == 0.00000 && i != 1)
                {
                    break;
                }
                raiz = xr;
            } while (true);

            Raiztxt.Text = xr.ToString();
        }
    }
}
