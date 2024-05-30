using System.Data;
using System.Globalization;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Application.CurrentCulture = new CultureInfo("en-US");

            InitializeComponent();
        }



        private void button12_Click(object sender, EventArgs e)
        {
            string txt1 = textBox1.Text; //Button 1
            string txt2 = "1";
            textBox1.Text = txt1 + txt2;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e) //division
        {
            string txt1 = textBox1.Text;
            string txt2 = "/";
            textBox1.Text = txt1 + txt2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e) //main function where the arithmetic operations takes place
        {

   
             string calculation = textBox1.Text;
            
            DataTable table = new DataTable();

            try
            {
                var result = table.Compute(calculation, "");

                textBox1.Text = result.ToString();
            }
            catch
            {

                MessageBox.Show("Please enter valid characters or check your arithmetic operations  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)  //you cant write over the textbox
        {
            textBox1.ReadOnly = true;
        }

        private void button11_Click(object sender, EventArgs e)//button 2
        {
            string txt1 = textBox1.Text;

            string txt2 = "2";

            textBox1.Text = txt1 + txt2;
        }

        private void button9_Click(object sender, EventArgs e)//button 3
        {
            string txt1 = textBox1.Text;

            string txt2 = "3";

            textBox1.Text = txt1 + txt2;
        }

        private void button4_Click(object sender, EventArgs e)//button 4
        {
            string txt1 = textBox1.Text;

            string txt2 = "4";

            textBox1.Text = txt1 + txt2;
        }

        private void button8_Click(object sender, EventArgs e)//button 5
        {
            string txt1 = textBox1.Text;

            string txt2 = "5";

            textBox1.Text = txt1 + txt2;
        }

        private void button7_Click(object sender, EventArgs e)//button 6
        {
            string txt1 = textBox1.Text;

            string txt2 = "6";

            textBox1.Text = txt1 + txt2;
        }

        private void button2_Click(object sender, EventArgs e)//button 7
        {
            string txt1 = textBox1.Text;

            string txt2 = "7";

            textBox1.Text = txt1 + txt2;
        }

        private void button5_Click(object sender, EventArgs e)//button 8
        {
            string txt1 = textBox1.Text;

            string txt2 = "8";

            textBox1.Text = txt1 + txt2;
        }

        private void button1_Click(object sender, EventArgs e)//button 9
        {
            string txt1 = textBox1.Text;

            string txt2 = "9";

            textBox1.Text = txt1 + txt2;
        }

        private void button20_Click(object sender, EventArgs e)//button 0
        {
            string txt1 = textBox1.Text;

            string txt2 = "0";

            textBox1.Text = txt1 + txt2;
        }

        private void button10_Click(object sender, EventArgs e)//Addition 
        {
            string txt1 = textBox1.Text;

            string txt2 = "+";

            textBox1.Text = txt1 + txt2;
        }

        private void button6_Click(object sender, EventArgs e)//Subtraction 
        {
            string txt1 = textBox1.Text;

            string txt2 = "-";

            textBox1.Text = txt1 + txt2;
        }

        private void button3_Click(object sender, EventArgs e)//Multiplication 
        {

            string txt1 = textBox1.Text;

            string txt2 = "*";

            textBox1.Text = txt1 + txt2;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//you cant write over the textbox
        {
            textBox2.ReadOnly = true;
        }

        private void button19_Click(object sender, EventArgs e)//decimal
        {
            string txt1 = textBox1.Text;

            string txt2 = ".";

            textBox1.Text = txt1 + txt2;
        }

        private void button16_Click(object sender, EventArgs e)//x^2 button
        {
            string txt1 = textBox1.Text;

            char[] operators = { '+', '-', '/', '*' };

            string[] strings = txt1.Split(operators);

            if (strings.Length > 0)
            {
                string last = strings[strings.Length - 1];

                if (int.TryParse(last, out int a))
                {
                    a = a * a;
                    strings[strings.Length - 1] = a.ToString();
                   txt1= txt1.Substring(0, txt1.Length - 1) +a;
                    textBox1.Text = txt1;
                }
                else
                {
                   
                    MessageBox.Show("Invalid number at the end of the expression.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           






        }

        private void button15_Click(object sender, EventArgs e)
        {
            string txt1 = textBox1.Text;


            if (!string.IsNullOrEmpty(txt1))
            {
                txt1 = txt1.Remove(txt1.Length - 1);
                textBox1.Text = txt1;
            }






        }

        private void button18_Click(object sender, EventArgs e)//Root button (x^1/2)
        {
            string txt1 = textBox1.Text;

            char[] operators = { '+', '-', '/', '*' };

            string[] strings = txt1.Split(operators);

            if (strings.Length > 0)
            {
                string last = strings[strings.Length - 1];

                if (double.TryParse(last, out double a))
                {
                    a= Math.Sqrt(a);

                    strings[strings.Length - 1] = a.ToString();
                    txt1 = txt1.Substring(0, txt1.Length - 1) + a;
                    textBox1.Text = txt1;
                }
                else
                {

                    MessageBox.Show("Invalid number at the end of the expression.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }






        }





    }
    }
