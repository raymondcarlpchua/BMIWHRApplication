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
    public partial class FormLogin : Form
    {
       
        private FormCalculator otherForm;
        public static string passingText;
        public static string passingText2;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnproceed_Click(object sender, EventArgs e)
        {


            passingText = txtName.Text;
            passingText2 = txtAge.Text;
                if (txtName.Text == "" && txtAge.Text == "")
                {
                    this.labela.Show();
                    this.labelb.Show();
                    txtName.BackColor = Color.Red;
                    txtAge.BackColor = Color.Red;
                }
                else if (txtName.Text == "" && txtAge.Text == txtAge.Text)
                {
                    this.labela.Show();
                    txtName.BackColor = Color.Red;
                }
                else if (txtName.Text == txtName.Text && txtAge.Text == "")
                {
                    this.labelb.Show();
                    txtAge.BackColor = Color.Red;
                }
                else
                {
                         FormCalculator frm = new FormCalculator();
                         frm.Show();
                }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
       
    }

            
}
    


    

