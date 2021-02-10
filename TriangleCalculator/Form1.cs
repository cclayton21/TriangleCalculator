using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void checkInputFields()
        {
            if(sideA.Value > 0 && sideB.Value > 0 && sideC.Value > 0)
            {
                Triangle t = new Triangle((int)sideA.Value, (int)sideB.Value, (int)sideC.Value);
                if (t.getIsValid())
                {
                    outputTxt.Text = $"These side lengths produce a valid {t.getAngleClass()} {t.getSideClass()} triangle";
                    angleA.Text = $"Angle A: {t.getAngleA()}\u00B0";
                    angleB.Text = $"Angle B: {t.getAngleB()}\u00B0";
                    angleC.Text = $"Angle C: {t.getAngleC()}\u00B0";
                }
                else
                {
                    outputTxt.Text = "These side lengths do not produce a valid triangle.";
                    angleA.Text = "";
                    angleB.Text = "";
                    angleC.Text = "";
                }
                
            }
            else
            {
                outputTxt.Text = "";
                angleA.Text = "";
                angleB.Text = "";
                angleC.Text = "";
            }
        }

        private void sideA_ValueChanged(object sender, EventArgs e)
        {
            checkInputFields();
        }

        private void sideB_ValueChanged(object sender, EventArgs e)
        {
            checkInputFields();
        }

        private void sideC_ValueChanged(object sender, EventArgs e)
        {
            checkInputFields();
        }
    }
}
