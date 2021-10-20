using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТРПО_ИСП2_20_Гичка_ПР__2
{
    public partial class pract : Form
    {
        public pract()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double X = double.Parse(XText.Text);
            double Y = double.Parse(YText.Text);
            double E = Math.E;
            double Fx = 0;
            double shX = (E * X - E * (-X)) / 2;
            double X2 = X * X;
            double EX = Math.Pow(E, X);
            double d;
            

            if (UX.Checked)
            {
                Fx = shX;
            }

            else if (UY.Checked)
            {
                Fx = X2;
            }

            else if (UZ.Checked)
            {
                Fx = EX;
            }

            if  (X > Y)
            {
                double a = Math.Pow(Fx - Y, 3);
                double z = Math.Atan(Fx);
                d = a - z;
            }

            else if (Y > X)
            {
                double z = Math.Atan(Fx);
                double b = Math.Pow(Y - Fx, 3);
                d = b - z;
            }
            else
            {
                double c = Math.Pow(Y + Fx, 3);
                d = c + 0.5;
            }

            string name = "Пракитическая работа №2. Студента группы ИСП 2-20 Гичка Глеб";
            string XYZ = String.Format ("X = {0}, Y = {1}", X, Y);
            string dform = String.Format ("d = {0,F3}", d);
            XText.Text = name + "\n" + XYZ + "\n" + dform;
        }
    }
}
