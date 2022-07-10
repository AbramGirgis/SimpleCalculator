using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to exit?", "Confirmation",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // simple basic validation
            if (textBoxNumber1.Text == "")
            {
                MessageBox.Show("Number 1 is required", "Missing value");
                textBoxNumber1.Focus();
            }
            else if (textBoxNumber2.Text == "")
            {
                MessageBox.Show("Number 2 is required", "Missing value");
                textBoxNumber2.Focus();
            }
            else
            {
                labelResult.Text = "The sum is: " + (Convert.ToInt32(textBoxNumber1.Text) + 
                                                     Convert.ToInt32(textBoxNumber2.Text));
            }
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            if (textBoxNumber1.Text == "")
            {
                MessageBox.Show("Number 1 is required", "Missing value");
                textBoxNumber1.Focus();
            }
            else if (textBoxNumber2.Text == "")
            {
                MessageBox.Show("Number 2 is required", "Missing value");
                textBoxNumber2.Focus();
            }
            else
            {
                int result = (Convert.ToInt32(textBoxNumber1.Text) - Convert.ToInt32(textBoxNumber2.Text));
                if(result < 0)
                {
                    MessageBox.Show("Number 1 is less than number 2. Please swap the numbers!", "Negative value");
                    textBoxNumber1.Focus();
                }
                else
                {
                    labelResult.Text = "The difference is: " + result;
                    MessageBox.Show("The difference is: " + result, "Difference");
                }
            }
        }
    }
}
