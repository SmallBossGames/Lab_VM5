﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБА5ВЫЧМАТ
{
    public partial class Form1 : Form
    {
        decimal From => decimal.Parse(fromTextBox.Text);
        decimal To => decimal.Parse(toTextBox.Text);
        decimal Accuracy => decimal.Parse(accuracyTextBox.Text);

        public Form1()
        {
            InitializeComponent();
        }

        private void integrateRectangleButton_Click(object sender, EventArgs e)
        {

            (var H, var result) = RectangleIntegral.CalculateWithAcuracy(From, To, Accuracy, Program.F);
            rectangleStepTextBox.Text = H.ToString();
            recatngleTextBox.Text = result.ToString();
        }

        private void simpsonButton_Click(object sender, EventArgs e)
        {
            (var H, var result) = SimpsonIntegral.CalculateWithAcuracy(From, To, Accuracy, Program.F);
            simpsonStepTextBox.Text = H.ToString();
            simpsonTextBox.Text = result.ToString();
        }
    }
}
