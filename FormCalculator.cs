using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIandWHRApplication
{
    public partial class FormCalculator : Form
    {
        double h;
        double w;
        double t;
        double a;
        double b;
        double c;
        int d;
   
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {
            textBox1.Text = FormLogin.passingText;
            txtAge.Text = FormLogin.passingText2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            lblBMI.BackColor = Color.White;
            h = Double.Parse(txtHeight.Text);
            w = Double.Parse(txtWeight.Text);
           
            t = w / (h * h);

            lblBMI.Text = String.Format("{0:f}", t);
            {
                if (t < 16)
                {
                    lblBMID.Text = " Severe Thinness (Underweight) ";
                   // pb1.Image = Properties.Resources.male;
                   // pb2.Image = Properties.Resources.male1;
                }

                else if (t >= 16 & t <= 17)
                    lblBMID.Text = "Moderate Thinness (Underweight)";
                else if (t >= 17 & t <= 18.5)
                    lblBMID.Text = "Mild Thinness (Underweight)";
                else if (t >= 18.5 & t <= 25)
                    lblBMID.Text = "Normal";
                else if (t >= 25 & t <= 30)
                    lblBMID.Text = "Overweight";
                else if (t >= 30 & t <= 35)
                    lblBMID.Text = "Overweight Class I (Obese)";
                else if (t >= 35 & t <= 40)
                    lblBMID.Text = "Overweight Class II (Obese)";
                else if (t <= 0 & t >= 0)
                    lblBMID.Text = " Refrain in using negative number ";

                else
                    lblBMID.Text = "Overweight Class III (Obese)";
            }
        }

        private void btnWHR_Click(object sender, EventArgs e)
        {

            lblWHR.BackColor = Color.White;
            a = Double.Parse(txtWaist.Text);
            b = Double.Parse(txtHip.Text);
            c = a / b;
            lblWHR.Text = String.Format("{0:f}", c);

            if (c < 0 & optM.Checked == true || optF.Checked == true)
                lblWHRD.Text = " Refrain in using negative number ";

            else if (c >= 0.01 & c <= 0.85 & optM.Checked)
                lblWHRD.Text = "Excellent";
            else if (c >= 0.85 & c <= 0.90 & optM.Checked == true)
                lblWHRD.Text = " Good";
            else if (c >= 0.90 & c <= 0.95 & optM.Checked == true)
                lblWHRD.Text = "Average";
            else if (c >= 0.95 & c <= 1.00 & optM.Checked == true)
                lblWHRD.Text = " High ";
            else if (c > 1.00 & optM.Checked == true)
                lblWHRD.Text = " Bad ";
            //--------------------FEMALE WHR-------------------------------------
            else if (c < 0.75 & optF.Checked == true)
                lblWHRD.Text = "Excellent";
            else if (c >= 0.75 & c <= 0.80 & optF.Checked == true)
                lblWHRD.Text = " Good";
            else if (c >= 0.80 & c <= 0.85 & optF.Checked == true)
                lblWHRD.Text = "Average";
            else if (c >= 0.85 & c <= 0.90 & optF.Checked == true)
                lblWHRD.Text = " High ";
            else if (c > 0.90 & optF.Checked == true)
                lblWHRD.Text = " Bad ";
            else
                lblWHRD.Text = " Bad";
                 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHeight.Clear();
            txtWeight.Clear();
            lblBMI.Text = "";
            txtWaist.Clear();
            txtHip.Clear();
            lblWHR.Text = "";
            lblWHRD.Text = "";
            lblWHRD.Text = "";
            optM.Checked = false;
            optF.Checked = false;

        }

        private void optM_CheckedChanged(object sender, EventArgs e)
        {
            pb1.Image = Properties.Resources.male;
            pb2.Image = Properties.Resources.male1;
        }

        private void bodyMassIndexBMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBMI formBMI = new FormBMI();
            formBMI.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void waistAndHipRatioWHRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWHR formWHR = new FormWHR();
            formWHR.ShowDialog();
        }

        private void underweightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUnder formUnder = new FormUnder();
            formUnder.ShowDialog();
        }

        private void overweightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOver formOver = new FormOver();
            formOver.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void optF_CheckedChanged(object sender, EventArgs e)
        {
            pb1.Image = Properties.Resources.female;
            pb2.Image = Properties.Resources.female1;
        }









        }



        
    }
