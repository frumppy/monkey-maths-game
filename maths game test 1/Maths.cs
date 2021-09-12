using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace maths_game_test_1
{
    public partial class MonkeyMaths : Form
    {
        public MonkeyMaths()
        {
            InitializeComponent();
            Maths();
        

        }

        // ///////////
        public int goes = 0;
        public int QAnswer = 0;
        public int answer = 0;
        public string text = null;
        public string text2 = null;
        public int userAnswer = 0;
        public int points = 0;
        // ////////

        public void button1_Click(object sender, EventArgs e)
        {
            //enter
            Console.WriteLine("the button has been pressed");
            Console.WriteLine(userAnswer);
            if (userAnswer == QAnswer)
            {
                if (goes >= 10)
                {

                }
                else
                {
                    points++;
                    textBox3.Text = points.ToString();
                }
            }

            if (goes >= 10)
            {

                

            }
            else
            {
                goes++;
            }

          

            textBox1.Text = "0";
            userAnswer = 0;
            text = null;
            text2 = null;
            answer = 0;
            Maths();
            if (goes >= 10) 
            {
                textBox3.Text = "you have finnshed you got " + points.ToString() + " out of " + goes.ToString();
                textBox2.Text = ":)";
                textBox1.Text = "Press leave";
                if(Control.ModifierKeys == Keys.Space)
                {

                
                }
            }

        }

        public void button12_Click(object sender, EventArgs e)
        {

            //back space button
            answer = 0;
            string text = answer.ToString();
            textBox1.Text = text;


        }


        public void button2_Click(object sender, EventArgs e)
        {
            string text = answer.ToString();
            answer = 1;
            if (text == null)
            {
                //button 1 

                textBox1.Text = text;

            }

            else
            {
                string text2 = answer.ToString();
                textBox1.Text = text + text2;
                userAnswer = int.Parse(text + text2);

            }


        }

        public void button11_Click(object sender, EventArgs e)
        {
            string text = answer.ToString();
            answer = 2;
            if (Text == null)
            {
                //button 2

                textBox1.Text = text;

            }
            else
            {
                string text2 = answer.ToString();
                textBox1.Text = text + text2;
                userAnswer = int.Parse(text + text2);

            }
        }

        public void button8_Click(object sender, EventArgs e)
        {
            string text = answer.ToString();
            answer = 3;
            if (text == null)
            {
                //button 3

                textBox1.Text = text;

            }
            else
            {
                string text2 = answer.ToString();
                textBox1.Text = text + text2;
                userAnswer = int.Parse(text + text2);

            }
        }

        public void button10_Click(object sender, EventArgs e)
        {
            string text = answer.ToString();
            answer = 4;
            if (text == null)
            {
                //button 4

                textBox1.Text = text;

            }
            else
            {
                string text2 = answer.ToString();
                textBox1.Text = text + text2;
                userAnswer = int.Parse(text + text2);

            }
        }


        public void button6_Click(object sender, EventArgs e)
        {
            string text = answer.ToString();
            answer = 5;
            if (text == null)
            {
                //button 5

                textBox1.Text = text;

            }
            else
            {
                string text2 = answer.ToString();
                textBox1.Text = text + text2;
                userAnswer = int.Parse(text + text2);

            }
        }

        public void button5_Click(object sender, EventArgs e)
        {
            string text = answer.ToString();
            answer = 6;
            if (text == null)
            {
                //button 6

                textBox1.Text = text;

            }
            else
            {
                string text2 = answer.ToString();
                textBox1.Text = text + text2;
                userAnswer = int.Parse(text + text2);

            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            string text = answer.ToString();
            answer = 7;
            if (text == null)
            {
                //button 7

                textBox1.Text = text;

            }
            else
            {
                string text2 = answer.ToString();
                textBox1.Text = text + text2;
                userAnswer = int.Parse(text + text2);

            }
        }

        public void button4_Click(object sender, EventArgs e)
        {
            string text = answer.ToString();
            answer = 8;
            if (text == null)
            {
                //button 8

                textBox1.Text = text;

            }
            else
            {
                string text2 = answer.ToString();
                textBox1.Text = text + text2;
                userAnswer = int.Parse(text + text2);

            }
        }

        public void button9_Click(object sender, EventArgs e)
        {
            string text = answer.ToString();
            answer = 9;
            if (text == null)
            {
                //button 9

                textBox1.Text = text;

            }
            else
            {
                string text2 = answer.ToString();
                textBox1.Text = text + text2;
                userAnswer = int.Parse(text + text2);

            }
        }

        public void button7_Click(object sender, EventArgs e)
        {
            string text = answer.ToString();
            answer = 0;
            if (text == null)
            {
                //button 0

                textBox1.Text = text;

            }
            else if (userAnswer == 10)
            {

                textBox1.Text = "100";
                userAnswer = 100;
            }
            else
            {
                string text2 = answer.ToString();
                textBox1.Text = text + text2;
                userAnswer = int.Parse(text + text2);

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {



        }

        public void Maths()
        {
            Random ram = new Random();
            int nub1 = ram.Next(1, 11);
            int nub2 = ram.Next(1, 11);
            QAnswer = nub1 * nub2;
            textBox2.Text = nub1.ToString() + "X" + nub2.ToString();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void MonkeyMaths_Load(object sender, EventArgs e)
        {

        }
    }

}
