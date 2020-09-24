using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converter
{
    public partial class information : Form
    {
        int deci1;
        string binary1,binary2,hexa1,octal1;
        char op;
        
        public information()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            subtraction.Enabled = false;
            addition.Enabled = false;
            complement.Enabled = false;
            complement2.Enabled = false;
            deci.IsAccessible = true ;
            A.Enabled = false; B.Enabled = false; C.Enabled = false; D.Enabled = false; E.Enabled = false; F.Enabled =false;

            two.Enabled = true; three.Enabled = true; four.Enabled = true; five.Enabled = true; six.Enabled = true; seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;

            op = 'd';
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            op = 'o';
            subtraction.Enabled = false;
            addition.Enabled =false;
            complement.Enabled = false;
            complement2.Enabled = false;
            A.Enabled = false; B.Enabled = false; C.Enabled = false; D.Enabled = false; E.Enabled = false; F.Enabled = false;
            two.Enabled = true; three.Enabled = true; four.Enabled = true; five.Enabled = true; six.Enabled = true; seven.Enabled = true; eight.Enabled = false; nine.Enabled = false;
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            subtraction.Enabled = true;
            addition.Enabled = true;
            complement.Enabled = true;
            complement2.Enabled = true;
            A.Enabled =false ; B.Enabled = false; C.Enabled = false; D.Enabled = false; E.Enabled = false; F.Enabled = false;

            two.Enabled = false; three.Enabled = false; four.Enabled = false; five.Enabled = false; six.Enabled = false; seven.Enabled = false; eight.Enabled = false; nine.Enabled = false;
            op = 'b';
          
            binary1 = output.Text;
            textBox_binary.Text=binary1;
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            binary1 = output.Text;
            int first_step = Convert.ToInt16(binary1, 2);
            int resualt = ~first_step+1;
            string compl = Convert.ToString(resualt, 2);
            output.Text = compl.Remove(0,32-binary1.Length);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            output.Text += "E";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            output.Text += "2";
        }

        private void A_Click(object sender, EventArgs e)
        {
            output.Text += "A";
            
        }

        private void one_Click(object sender, EventArgs e)
        {
            output.Text += "1";
            
            
        }

        private void eight_Click(object sender, EventArgs e)
        {
            output.Text += "8";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            output.Clear();
            textBox_binary.Clear();
            textBox_hexa.Clear();
            textBox_octal.Clear();
            textBox_deci.Clear();
            two.Show();
            three.Show();
            four.Show();
            five.Show();
            six.Show();
            seven.Show();
            eight.Show();
            nine.Show();
            A.Show();
            B.Show();
            C.Show();
            D.Show();
            E.Show();
            F.Show();

            
        }

        private void three_Click(object sender, EventArgs e)
        {
            output.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            output.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            output.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            output.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            output.Text += "7";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            output.Text += "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            output.Text += "0";
        }

        private void B_Click(object sender, EventArgs e)
        {
            output.Text += "B";
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
           
             binary1 = output.Text;
            op = '-';
            output.Clear();
        }

        private void complement_Click(object sender, EventArgs e)
        {
            binary1 = output.Text;
            int first_step = Convert.ToInt16(binary1, 2);
            int resualt = ~first_step;
            string compl = Convert.ToString(resualt, 2);
            
            output.Text = compl.Remove(0,32-binary1.Length);

        }

        private void C_Click(object sender, EventArgs e)
        {
            output.Text += "C";
        }

        private void addition_Click(object sender, EventArgs e)
        {
            binary1 = output.Text;
            op = '+';
            output.Clear();
        }

        private void hexa_Click(object sender, EventArgs e)
        {
            
            op = 'h';
            subtraction.Enabled = false;
            addition.Enabled = false;
            complement.Enabled = false;
            complement2.Enabled = false;
            A.Enabled = true; B.Enabled = true; C.Enabled = true; D.Enabled = true; E.Enabled = true; F.Enabled = true;

            two.Enabled = true; three.Enabled = true; four.Enabled = true; five.Enabled = true; six.Enabled = true; seven.Enabled = true; eight.Enabled = true; nine.Enabled = true;
        }

        private void info_TextChanged(object sender, EventArgs e)
        {

        }

        private void deci_BackColorChanged(object sender, EventArgs e)
        {
            ;
        }

        private void textBox_hexa_TextChanged(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {
            binary2 = output.Text;

            switch (op)
            {
                case '-':

                    int first_step1 = Convert.ToInt16(binary1, 2);
                    int first_step2 = Convert.ToInt16(binary2, 2);
                    int sub = first_step1 - first_step2;
                    if (sub < 0)
                    {
                        sub *= -1;
                        string subt = Convert.ToString(sub, 2);
                        output.Text = "-" + subt;
                    }
                    else
                    {
                        string subt = Convert.ToString(sub, 2);
                        output.Text = subt;
                    }

                    break;
                case '+':
                    int input1 = Convert.ToInt16(binary1, 2);
                    int input2 = Convert.ToInt16(binary2, 2);
                    int add = input1 + input2;
                    string addition = Convert.ToString(add, 2);
                    output.Text = addition;
                    break;
            }
            switch(op)
            {
                case'h':
                    hexa1 = output.Text;
                    textBox_hexa.Text = hexa1;
                    deci1 = Convert.ToInt32(hexa1, 16);
                    string deci_show = Convert.ToString(deci1);
                    binary1 = Convert.ToString(deci1, 2);
                    octal1 = Convert.ToString(deci1, 8);
                    textBox_deci.Text = deci_show;
                    textBox_octal.Text = octal1;
                    textBox_binary.Text = binary1;
                    break;
                    
                case 'd':
                    deci1 = Convert.ToInt32(output.Text);
                    string deci_show2 = Convert.ToString(deci1);
                    textBox_deci.Text = deci_show2;
                    binary1 = Convert.ToString(deci1,2);
                    hexa1 = Convert.ToString(deci1, 16);
                    octal1 = Convert.ToString(deci1, 8);
                    textBox_hexa.Text = hexa1;
                    textBox_octal.Text = octal1;
                    textBox_binary.Text = binary1;
                    break;
                case 'o':
                    octal1 = output.Text;
                    textBox_octal.Text = octal1;
                    deci1 = Convert.ToInt32(octal1, 8);
                    string deci_show3 = Convert.ToString(deci1);
                    binary1 = Convert.ToString(deci1, 2);
                    hexa1 = Convert.ToString(deci1, 16);
                    textBox_deci.Text = deci_show3;
                    textBox_hexa.Text = hexa1;
                    textBox_binary.Text = binary1;
                    break;
                case 'b':
                    binary1 = output.Text;
                    textBox_binary.Text = binary1;
                    deci1 = Convert.ToInt32(binary1, 2);
                    string deci_show4 = Convert.ToString(deci1);
                    hexa1 = Convert.ToString(deci1, 16);
                    octal1 = Convert.ToString(deci1, 8);
                    textBox_deci.Text = deci_show4;
                    textBox_octal.Text = octal1;
                    textBox_hexa.Text = hexa1;
                    break;
            }

        }
            
        

        private void D_Click(object sender, EventArgs e)
        {
            output.Text += "D";
        }

        private void F_Click(object sender, EventArgs e)
        {
            output.Text += "F";
        }
    }
}



