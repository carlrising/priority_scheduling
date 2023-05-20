using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace os
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b1 = Convert.ToDouble(textBox1.Text);
            double b2 = Convert.ToDouble(textBox2.Text);
            double b3 = Convert.ToDouble(textBox3.Text);
            double b4 = Convert.ToDouble(textBox4.Text);

            double pr1 = Convert.ToDouble(textBox5.Text);
            double pr2 = Convert.ToDouble(textBox6.Text);
            double pr3 = Convert.ToDouble(textBox7.Text);
            double pr4 = Convert.ToDouble(textBox8.Text);

            label22.Text = Convert.ToString(pr1);
            label23.Text = Convert.ToString(pr2);
            label24.Text = Convert.ToString(pr3);
            label25.Text = Convert.ToString(pr4);


            label14.Text = Convert.ToString(b1);
            label15.Text = Convert.ToString(b2);
            label16.Text = Convert.ToString(b3);
            label17.Text = Convert.ToString(b4);

            label18.Text = "Process 1";
            label19.Text = "Process 2";
            label20.Text = "Process 3";
            label21.Text = "Process 4";
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double pr1 = Convert.ToDouble(textBox5.Text);
            double pr2 = Convert.ToDouble(textBox6.Text);
            double pr3 = Convert.ToDouble(textBox7.Text);
            double pr4 = Convert.ToDouble(textBox8.Text);

            double b1 = Convert.ToDouble(textBox1.Text);
            double b2 = Convert.ToDouble(textBox2.Text);
            double b3 = Convert.ToDouble(textBox3.Text);
            double b4 = Convert.ToDouble(textBox4.Text);

            //Starting Time
            if (pr1==1 && pr2==2 && pr3==3 && pr4==4)
            {
                label26.Text = Convert.ToString(0);
                label27.Text = Convert.ToString(b1 + 1);
                label28.Text = Convert.ToString(b1 + b2 + 1);
                label29.Text = Convert.ToString(b1 + b2 + b3 + 1); //

            }
            else if (pr1 == 1 && pr2 == 2 && pr3 == 4 && pr4 == 3)
                {
                label26.Text = Convert.ToString(0);
                label27.Text = Convert.ToString(b1 + 1);
                label28.Text = Convert.ToString(b1 + b2 + b4 + 1);
                label29.Text = Convert.ToString(b1 + b2 + 1); //

            }
            else if (pr1 == 1 && pr2 == 3 && pr3 == 2 && pr4 == 4)
            {
                label26.Text = Convert.ToString(0);
                label27.Text = Convert.ToString(b1 + b3 + 1);
                label28.Text = Convert.ToString(b1 + 1);
                label29.Text = Convert.ToString(b1 + b2 + b3 + 1); //

            }
            else if (pr1 == 1 && pr2 == 3 && pr3 == 4 && pr4 == 2)
            {
                label26.Text = Convert.ToString(0);
                label27.Text = Convert.ToString(b1 + b4 + 1);
                label28.Text = Convert.ToString(b1 + b2 + b4 + 1);
                label29.Text = Convert.ToString(b1 + 1); //

            }
            else if (pr1 == 1 && pr2 == 4 && pr3 == 2 && pr4 == 3)
            {
                label26.Text = Convert.ToString(0);
                label27.Text = Convert.ToString(b1 + b3 + b4 + 1);
                label28.Text = Convert.ToString(b1 + 1);
                label29.Text = Convert.ToString(b1 + b3 + 1); //

            }
            else if (pr1 == 1 && pr2 == 4 && pr3 == 3 && pr4 == 2)
            {
                label26.Text = Convert.ToString(0);
                label27.Text = Convert.ToString(b1 + b3 + b4 + 1);
                label28.Text = Convert.ToString(b1 + b4 + 1);
                label29.Text = Convert.ToString(b1 + 1); //

            }
            else if (pr1 == 2 && pr2 == 1 && pr3 == 3 && pr4 == 4)
            {
                label26.Text = Convert.ToString(b2 + 1);
                label27.Text = Convert.ToString(0);
                label28.Text = Convert.ToString(b1 + b2 + 1);
                label29.Text = Convert.ToString(b1 + b2 + b3 + 1); //

            }
            else if (pr1 == 2 && pr2 == 1 && pr3 == 4 && pr4 == 3)
            {
                label26.Text = Convert.ToString(b2 + 1);
                label27.Text = Convert.ToString(0);
                label28.Text = Convert.ToString(b1 + b2 + b4 + 1);
                label29.Text = Convert.ToString(b1 + b2 + 1); //

            }
            else if (pr1 == 2 && pr2 == 3 && pr3 == 1 && pr4 == 4)
            {
                label26.Text = Convert.ToString(b3 + 1);
                label27.Text = Convert.ToString(b1 + b3 + 1);
                label28.Text = Convert.ToString(0);
                label29.Text = Convert.ToString(b1 + b2 + b3 + 1); //

            }
            else if (pr1 == 2 && pr2 == 3 && pr3 == 4 && pr4 == 1)
            {
                label26.Text = Convert.ToString(b4 + 1);
                label27.Text = Convert.ToString(b1 + b4 + 1);
                label28.Text = Convert.ToString(b1 + b2 + b4 + 1); //
                label29.Text = Convert.ToString(0);

            }
            else if (pr1 == 2 && pr2 == 4 && pr3 == 1 && pr4 == 3)
            {
                label26.Text = Convert.ToString(b3 + 1);
                label27.Text = Convert.ToString(b1 + b3 + b4 + 1);
                label28.Text = Convert.ToString(0);
                label29.Text = Convert.ToString(b1 + b3 + 1); // 

            }
            else if (pr1 == 2 && pr2 == 4 && pr3 == 3 && pr4 == 1)
            {
                label26.Text = Convert.ToString(b4 + 1);
                label27.Text = Convert.ToString(b1 + b3 + b4 + 1);
                label28.Text = Convert.ToString(b1 + b4 + 1);
                label29.Text = Convert.ToString(0); //

            }
            else if (pr1 == 3 && pr2 == 1 && pr3 == 2 && pr4 == 4)
            {
                label26.Text = Convert.ToString(b2 + b3 + 1);
                label27.Text = Convert.ToString(0);
                label28.Text = Convert.ToString(b2 + 1);
                label29.Text = Convert.ToString(b1 + b2 + b3 + 1); //

            }
            else if (pr1 == 3 && pr2 == 1 && pr3 == 4 && pr4 == 2)
            {
                label26.Text = Convert.ToString(b2 + b4 + 1);
                label27.Text = Convert.ToString(0);
                label28.Text = Convert.ToString(b1 + b2 + b4 + 1);
                label29.Text = Convert.ToString(b2 + 1); //

            }
            else if (pr1 == 3 && pr2 == 2 && pr3 == 1 && pr4 == 4)
            {
                label26.Text = Convert.ToString(b2 + b3 + 1);
                label27.Text = Convert.ToString(b3 + 1);
                label28.Text = Convert.ToString(0);
                label29.Text = Convert.ToString(b1 + b2 + b3 + 1); //

            }
            else if (pr1 == 3 && pr2 == 2 && pr3 == 4 && pr4 == 1)
            {
                label26.Text = Convert.ToString(b2 + b4 + 1);
                label27.Text = Convert.ToString(b4 + 1);
                label28.Text = Convert.ToString(b1 + b2 + b4 + 1);
                label29.Text = Convert.ToString(0); //

            }
            else if (pr1 == 3 && pr2 == 4 && pr3 == 1 && pr4 == 2)
            {
                label26.Text = Convert.ToString(b3 + b4 + 1);
                label27.Text = Convert.ToString(b1 + b3 + b4 + 1);
                label28.Text = Convert.ToString(0);
                label29.Text = Convert.ToString(b3 + 1); //

            }
            else if (pr1 == 3 && pr2 == 4 && pr3 == 2 && pr4 == 1)
            {
                label26.Text = Convert.ToString(b3 + b4 + 1);
                label27.Text = Convert.ToString(b1 + b3 + b4 + 1);
                label28.Text = Convert.ToString(b4 + 1);
                label29.Text = Convert.ToString(0); //

            }
            else if (pr1 == 4 && pr2 == 1 && pr3 == 2 && pr4 == 3)
            {
                label26.Text = Convert.ToString(b2 + b3 + b4 + 1);
                label27.Text = Convert.ToString(0);
                label28.Text = Convert.ToString(b2 + 1);
                label29.Text = Convert.ToString(b2 + b3 + 1); //

            }
            else if (pr1 == 4 && pr2 == 1 && pr3 == 3 && pr4 == 2)
            {
                label26.Text = Convert.ToString(b2 + b3 + b4 + 1);
                label27.Text = Convert.ToString(0);
                label28.Text = Convert.ToString(b2 + b4 + 1);
                label29.Text = Convert.ToString(b2 +1); //

            }
            else if (pr1 == 4 && pr2 == 2 && pr3 == 1 && pr4 == 3)
            {
                label26.Text = Convert.ToString(b2 + b3 + b4 + 1);
                label27.Text = Convert.ToString(b3 + 1);
                label28.Text = Convert.ToString(0);
                label29.Text = Convert.ToString(b2 + b3 + 1); //

            }
            else if (pr1 == 4 && pr2 == 2 && pr3 == 1 && pr4 == 3)
            {
                label26.Text = Convert.ToString(b2 + b3 + b4 + 1);
                label27.Text = Convert.ToString(b3 + 1);
                label28.Text = Convert.ToString(0);
                label29.Text = Convert.ToString(b2 + b3 + 1);//
            }
            else if (pr1 == 4 && pr2 == 2 && pr3 == 3 && pr4 == 1)
            {
                label26.Text = Convert.ToString(b2 + b3 + b4 + 1);
                label27.Text = Convert.ToString(b4 + 1);
                label28.Text = Convert.ToString(b2 + b4 + 1);
                label29.Text = Convert.ToString(0);

            }
            else if (pr1 == 4 && pr2 == 3 && pr3 == 1 && pr4 == 2)
            {
                label26.Text = Convert.ToString(b2 + b3 + b4 + 1);
                label27.Text = Convert.ToString(b3 + b4 + 1);
                label28.Text = Convert.ToString(0);
                label29.Text = Convert.ToString(b3 + 1);//

            }
            else if (pr1 == 4 && pr2 == 3 && pr3 == 2 && pr4 == 1)
            {
                label26.Text = Convert.ToString(b2 + b3 + b4 + 1);
                label27.Text = Convert.ToString(b3 + b4 + 1);
                label28.Text = Convert.ToString(b4 + 1);
                label29.Text = Convert.ToString(0); //

            }


            // Finshing Time
            if (pr1 == 1 && pr2 == 2 && pr3 == 3 && pr4 == 4)
            {
                label30.Text = Convert.ToString(b1);
                label31.Text = Convert.ToString(b1 + b2);
                label32.Text = Convert.ToString(b1 + b2 + b3);
                label33.Text = Convert.ToString(b1 + b2 + b3 + b4); 

            }
            else if (pr1 == 1 && pr2 == 2 && pr3 == 4 && pr4 == 3)
            {
                label30.Text = Convert.ToString(b1);
                label31.Text = Convert.ToString(b1 + b2);
                label32.Text = Convert.ToString(b1 + b2 + b4 + b3);
                label33.Text = Convert.ToString(b1 + b2 + b3); 

            }
            else if (pr1 == 1 && pr2 == 3 && pr3 == 2 && pr4 == 4)
            {
                label30.Text = Convert.ToString(b1);
                label31.Text = Convert.ToString(b1 + b3 + b2);
                label32.Text = Convert.ToString(b1 + b3);
                label33.Text = Convert.ToString(b1 + b2 + b3 + b4);

            }
            else if (pr1 == 1 && pr2 == 3 && pr3 == 4 && pr4 == 2)
            {
                label30.Text = Convert.ToString(b1);
                label31.Text = Convert.ToString(b1 + b4 + b2);
                label32.Text = Convert.ToString(b1 + b2 + b4 + b3);
                label33.Text = Convert.ToString(b1 + b4); 

            }
            else if (pr1 == 1 && pr2 == 4 && pr3 == 2 && pr4 == 3)
            {
                label30.Text = Convert.ToString(b1);
                label31.Text = Convert.ToString(b1 + b3 + b4 + b2);
                label32.Text = Convert.ToString(b1 + b3);
                label33.Text = Convert.ToString(b1 + b3 + b4); 

            }
            else if (pr1 == 1 && pr2 == 4 && pr3 == 3 && pr4 == 2)
            {
                label30.Text = Convert.ToString(b1);
                label31.Text = Convert.ToString(b1 + b3 + b4 + 1);
                label32.Text = Convert.ToString(b1 + b4 + 1);
                label33.Text = Convert.ToString(b1 + 1); 

            }
            else if (pr1 == 2 && pr2 == 1 && pr3 == 3 && pr4 == 4)
            {
                label30.Text = Convert.ToString(b2 + b1);
                label31.Text = Convert.ToString(b2);
                label32.Text = Convert.ToString(b1 + b2 + b3);
                label33.Text = Convert.ToString(b1 + b2 + b3 + b4); 

            }
            else if (pr1 == 2 && pr2 == 1 && pr3 == 4 && pr4 == 3)
            {
                label30.Text = Convert.ToString(b2 + b1);
                label31.Text = Convert.ToString(b1);
                label32.Text = Convert.ToString(b1 + b2 + b4 + b3);
                label33.Text = Convert.ToString(b1 + b2 + b3); 

            }
            else if (pr1 == 2 && pr2 == 3 && pr3 == 1 && pr4 == 4)
            {
                label30.Text = Convert.ToString(b3 + b1);
                label31.Text = Convert.ToString(b1 + b3 + b2);
                label32.Text = Convert.ToString(b3);
                label33.Text = Convert.ToString(b1 + b2 + b3 + b4); 

            }
            else if (pr1 == 2 && pr2 == 3 && pr3 == 4 && pr4 == 1)
            {
                label30.Text = Convert.ToString(b4 + b1);
                label31.Text = Convert.ToString(b1 + b4 + b2);
                label32.Text = Convert.ToString(b1 + b2 + b4 + b3); 
                label33.Text = Convert.ToString(b4);

            }
            else if (pr1 == 2 && pr2 == 4 && pr3 == 1 && pr4 == 3)
            {
                label30.Text = Convert.ToString(b3 + b1);
                label31.Text = Convert.ToString(b1 + b3 + b4 + b2);
                label32.Text = Convert.ToString(b3);
                label33.Text = Convert.ToString(b1 + b3 + b4); 

            }
            else if (pr1 == 2 && pr2 == 4 && pr3 == 3 && pr4 == 1)
            {
                label30.Text = Convert.ToString(b4 + b1);
                label31.Text = Convert.ToString(b1 + b3 + b4 + b2);
                label32.Text = Convert.ToString(b1 + b4 + b3);
                label33.Text = Convert.ToString(b4); 

            }
            else if (pr1 == 3 && pr2 == 1 && pr3 == 2 && pr4 == 4)
            {
                label30.Text = Convert.ToString(b2 + b3 + b1);
                label31.Text = Convert.ToString(b2);
                label32.Text = Convert.ToString(b2 + b3);
                label33.Text = Convert.ToString(b1 + b2 + b3 + b4); 

            }
            else if (pr1 == 3 && pr2 == 1 && pr3 == 4 && pr4 == 2)
            {
                label30.Text = Convert.ToString(b2 + b4 + b1);
                label31.Text = Convert.ToString(b2);
                label32.Text = Convert.ToString(b1 + b2 + b4 + b3);
                label33.Text = Convert.ToString(b2 + b4); 

            }
            else if (pr1 == 3 && pr2 == 2 && pr3 == 1 && pr4 == 4)
            {
                label30.Text = Convert.ToString(b2 + b3 + b1);
                label31.Text = Convert.ToString(b3 + b2);
                label32.Text = Convert.ToString(b3);
                label33.Text = Convert.ToString(b1 + b2 + b3 + b4); 

            }
            else if (pr1 == 3 && pr2 == 2 && pr3 == 4 && pr4 == 1)
            {
                label30.Text = Convert.ToString(b2 + b4 + b1);
                label31.Text = Convert.ToString(b4 + b2);
                label32.Text = Convert.ToString(b1 + b2 + b4 + b3);
                label33.Text = Convert.ToString(b4); 

            }
            else if (pr1 == 3 && pr2 == 4 && pr3 == 1 && pr4 == 2)
            {
                label30.Text = Convert.ToString(b3 + b4 + b1);
                label31.Text = Convert.ToString(b1 + b3 + b4 + b2);
                label32.Text = Convert.ToString(b3);
                label33.Text = Convert.ToString(b3 + b4); 

            }
            else if (pr1 == 3 && pr2 == 4 && pr3 == 2 && pr4 == 1)
            {
                label30.Text = Convert.ToString(b3 + b4 + b1);
                label31.Text = Convert.ToString(b1 + b3 + b4 + b2);
                label32.Text = Convert.ToString(b4 + b3);
                label33.Text = Convert.ToString(b4); 

            }
            else if (pr1 == 4 && pr2 == 1 && pr3 == 2 && pr4 == 3)
            {
                label30.Text = Convert.ToString(b2 + b3 + b4 + b1);
                label31.Text = Convert.ToString(b2);
                label32.Text = Convert.ToString(b2 + b3);
                label33.Text = Convert.ToString(b2 + b3 + b4); 

            }
            else if (pr1 == 4 && pr2 == 1 && pr3 == 3 && pr4 == 2)
            {
                label30.Text = Convert.ToString(b2 + b3 + b4 + b1);
                label31.Text = Convert.ToString(b2);
                label32.Text = Convert.ToString(b2 + b4 + b3);
                label33.Text = Convert.ToString(b2 + b4); 

            }
            else if (pr1 == 4 && pr2 == 2 && pr3 == 1 && pr4 == 3)
            {
                label30.Text = Convert.ToString(b2 + b3 + b4 + b1);
                label31.Text = Convert.ToString(b3 + b2);
                label32.Text = Convert.ToString(b3);
                label33.Text = Convert.ToString(b2 + b3 + b4); 

            }
            else if (pr1 == 4 && pr2 == 2 && pr3 == 1 && pr4 == 3)
            {
                label30.Text = Convert.ToString(b2 + b3 + b4 + b1);
                label31.Text = Convert.ToString(b3 + b2);
                label32.Text = Convert.ToString(b3);
                label33.Text = Convert.ToString(b2 + b3 + b4);
            }
            else if (pr1 == 4 && pr2 == 2 && pr3 == 3 && pr4 == 1)
            {
                label30.Text = Convert.ToString(b2 + b3 + b4 + b1);
                label31.Text = Convert.ToString(b4 + b2);
                label32.Text = Convert.ToString(b2 + b4 + b3);
                label33.Text = Convert.ToString(b4);

            }
            else if (pr1 == 4 && pr2 == 3 && pr3 == 1 && pr4 == 2)
            {
                label30.Text = Convert.ToString(b2 + b3 + b4 + b1);
                label31.Text = Convert.ToString(b3 + b4 + b2);
                label32.Text = Convert.ToString(b3);
                label33.Text = Convert.ToString(b3 + b4);//

            }
            else if (pr1 == 4 && pr2 == 3 && pr3 == 2 && pr4 == 1)
            {
                label30.Text = Convert.ToString(b2 + b3 + b4 + b1);
                label31.Text = Convert.ToString(b3 + b4 + b2);
                label32.Text = Convert.ToString(b3 + b4);
                label33.Text = Convert.ToString(b4); //

            }

            // Waiting Time
            if (pr1 == 1 && pr2 == 2 && pr3 == 3 && pr4 == 4)
            {

                double wt1 = 0;
                double wt2 = b1;
                double wt3 = (b1 + b2);
                double wt4 = (b1 + b2 + b3); //

                label34.Text = Convert.ToString(0);
                label35.Text = Convert.ToString(b1);
                label36.Text = Convert.ToString(b1 + b2);
                label37.Text = Convert.ToString(b1 + b2 + b3); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);
            }
            else if (pr1 == 1 && pr2 == 2 && pr3 == 4 && pr4 == 3)
            {

                double wt1 = (0);
                double wt2 = (b1);
                double wt3 = (b1 + b2 + b4);
                double wt4 = (b1 + b2); //

                label34.Text = Convert.ToString(0);
                label35.Text = Convert.ToString(b1);
                label36.Text = Convert.ToString(b1 + b2 + b4);
                label37.Text = Convert.ToString(b1 + b2); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 1 && pr2 == 3 && pr3 == 2 && pr4 == 4)
            {

                double wt1 = (0);
                double wt2 = (b1 + b3);
                double wt3 = (b1);
                double wt4 = (b1 + b2 + b3); //

                label34.Text = Convert.ToString(0);
                label35.Text = Convert.ToString(b1 + b3);
                label36.Text = Convert.ToString(b1);
                label37.Text = Convert.ToString(b1 + b2 + b3); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 1 && pr2 == 3 && pr3 == 4 && pr4 == 2)
            {

                double wt1 = (0);
                double wt2 = (b1 + b4);
                double wt3 = (b1 + b2 + b4);
                double wt4 = (b1); //

                label34.Text = Convert.ToString(0);
                label35.Text = Convert.ToString(b1 + b4);
                label36.Text = Convert.ToString(b1 + b2 + b4);
                label37.Text = Convert.ToString(b1); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 1 && pr2 == 4 && pr3 == 2 && pr4 == 3)
            {

                double wt1 = (0);
                double wt2 = (b1 + b3 + b4);
                double wt3 = (b1);
                double wt4 = (b1 + b3); //

                label34.Text = Convert.ToString(0);
                label35.Text = Convert.ToString(b1 + b3 + b4);
                label36.Text = Convert.ToString(b1);
                label37.Text = Convert.ToString(b1 + b3); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);
            }
            else if (pr1 == 1 && pr2 == 4 && pr3 == 3 && pr4 == 2)
            {

                double wt1 = (0);
                double wt2 = (b1 + b3 + b4);
                double wt3 = (b1 + b4);
                double wt4 = (b1); //

                label34.Text = Convert.ToString(0);
                label35.Text = Convert.ToString(b1 + b3 + b4);
                label36.Text = Convert.ToString(b1 + b4);
                label37.Text = Convert.ToString(b1); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 2 && pr2 == 1 && pr3 == 3 && pr4 == 4)
            {

                double wt1 = (b2);
                double wt2 = (0);
                double wt3 = (b1 + b2);
                double wt4 = (b1 + b2 + b3); //

                label34.Text = Convert.ToString(b2);
                label34.Text = Convert.ToString(0);
                label35.Text = Convert.ToString(b1 + b2);
                label36.Text = Convert.ToString(b1 + b2 + b3); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 2 && pr2 == 1 && pr3 == 4 && pr4 == 3)
            {

                double wt1 = (b2);
                double wt2 = (0);
                double wt3 = (b1 + b2 + b4);
                double wt4 = (b1 + b2); //

                label34.Text = Convert.ToString(b2);
                label35.Text = Convert.ToString(0);
                label36.Text = Convert.ToString(b1 + b2 + b4);
                label37.Text = Convert.ToString(b1 + b2); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);


            }
            else if (pr1 == 2 && pr2 == 3 && pr3 == 1 && pr4 == 4)
            {

                double wt1 = (b3);
                double wt2 = (b1 + b3);
                double wt3 = (0);
                double wt4 = (b1 + b2 + b3); //

                label34.Text = Convert.ToString(b3);
                label35.Text = Convert.ToString(b1 + b3);
                label36.Text = Convert.ToString(0);
                label37.Text = Convert.ToString(b1 + b2 + b3); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 2 && pr2 == 3 && pr3 == 4 && pr4 == 1)
            {

                double wt1 = (b4);
                double wt2 = (b1 + b4);
                double wt3 = (b1 + b2 + b4); //
                double wt4 = (0);

                label34.Text = Convert.ToString(b4);
                label35.Text = Convert.ToString(b1 + b4);
                label36.Text = Convert.ToString(b1 + b2 + b4 ); //
                label37.Text = Convert.ToString(0);

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 2 && pr2 == 4 && pr3 == 1 && pr4 == 3)
            {

                double wt1 = (b3);
                double wt2 = (b1 + b3 + b4);
                double wt3 = (0);
                double wt4 = (b1 + b3); // 

                label34.Text = Convert.ToString(b3);
                label35.Text = Convert.ToString(b1 + b3 + b4);
                label36.Text = Convert.ToString(0);
                label37.Text = Convert.ToString(b1 + b3); // 

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 2 && pr2 == 4 && pr3 == 3 && pr4 == 1)
            {

                double wt1 = (b4);
                double wt2 = (b1 + b3 + b4);
                double wt3 = (b1 + b4);
                double wt4 = (0); //

                label34.Text = Convert.ToString(b4);
                label35.Text = Convert.ToString(b1 + b3 + b4);
                label36.Text = Convert.ToString(b1 + b4);
                label37.Text = Convert.ToString(0); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 3 && pr2 == 1 && pr3 == 2 && pr4 == 4)
            {

                double wt1 = (b2 + b3);
                double wt2 = (0);
                double wt3 = (b2);
                double wt4 = (b1 + b2 + b3); //

                label34.Text = Convert.ToString(b2 + b3);
                label35.Text = Convert.ToString(0);
                label36.Text = Convert.ToString(b2);
                label37.Text = Convert.ToString(b1 + b2 + b3); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 3 && pr2 == 1 && pr3 == 4 && pr4 == 2)
            {

                double wt1 = (b2 + b4);
                double wt2 = (0);
                double wt3 = (b1 + b2 + b4);
                double wt4 = (b2); //

                label34.Text = Convert.ToString(b2 + b4);
                label35.Text = Convert.ToString(0);
                label36.Text = Convert.ToString(b1 + b2 + b4);
                label37.Text = Convert.ToString(b2); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 3 && pr2 == 2 && pr3 == 1 && pr4 == 4)
            {

                double wt1 = (b2 + b3);
                double wt2 = (b3);
                double wt3 =(0);
                double wt4 = (b1 + b2 + b3); //

                label34.Text = Convert.ToString(b2 + b3);
                label35.Text = Convert.ToString(b3);
                label36.Text = Convert.ToString(0);
                label37.Text = Convert.ToString(b1 + b2 + b3); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 3 && pr2 == 2 && pr3 == 4 && pr4 == 1)
            {

                double wt1 = (b2 + b4);
                double wt2 = (b4);
                double wt3 = (b1 + b2 + b4);
                double wt4 = (0); //

                label34.Text = Convert.ToString(b2 + b4);
                label35.Text = Convert.ToString(b4);
                label36.Text = Convert.ToString(b1 + b2 + b4);
                label37.Text = Convert.ToString(0); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 3 && pr2 == 4 && pr3 == 1 && pr4 == 2)
            {

                double wt1 = (b3 + b4);
                double wt2 = (b1 + b3 + b4);
                double wt3 = (0);
                double wt4 = (b3); //

                label34.Text = Convert.ToString(b3 + b4);
                label35.Text = Convert.ToString(b1 + b3 + b4);
                label36.Text = Convert.ToString(0);
                label37.Text = Convert.ToString(b3); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 3 && pr2 == 4 && pr3 == 2 && pr4 == 1)
            {

                double wt1 = (b3 + b4);
                double wt2 = (b1 + b3 + b4);
                double wt3 = (b4);
                double wt4 = (0); //

                label34.Text = Convert.ToString(b3 + b4);
                label35.Text = Convert.ToString(b1 + b3 + b4);
                label36.Text = Convert.ToString(b4);
                label37.Text = Convert.ToString(0); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 4 && pr2 == 1 && pr3 == 2 && pr4 == 3)
            {

                double wt1 = (b2 + b3 + b4);
                double wt2 = (0);
                double wt3 = (b2);
                double wt4 = (b2 + b3); //

                label34.Text = Convert.ToString(b2 + b3 + b4);
                label35.Text = Convert.ToString(0);
                label36.Text = Convert.ToString(b2);
                label37.Text = Convert.ToString(b2 + b3); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 4 && pr2 == 1 && pr3 == 3 && pr4 == 2)
            {

                double wt1 = (b2 + b3 + b4);
                double wt2 = (0);
                double wt3 = (b2 + b4);
                double wt4 = (b2); //

                label34.Text = Convert.ToString(b2 + b3 + b4);
                label35.Text = Convert.ToString(0);
                label36.Text = Convert.ToString(b2 + b4);
                label37.Text = Convert.ToString(b2); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 4 && pr2 == 2 && pr3 == 1 && pr4 == 3)
            {

                double wt1 = (b2 + b3 + b4);
                double wt2 = (b3);
                double wt3 = (0);
                double wt4 = (b2 + b3); //

                label34.Text = Convert.ToString(b2 + b3 + b4);
                label35.Text = Convert.ToString(b3);
                label36.Text = Convert.ToString(0);
                label37.Text = Convert.ToString(b2 + b3); //

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 4 && pr2 == 2 && pr3 == 1 && pr4 == 3)
            {

                double wt1 = (b2 + b3 + b4);
                double wt2 = (b3);
                double wt3 = (0);
                double wt4 = (b2 + b3);//

                label34.Text = Convert.ToString(b2 + b3 + b4);
                label35.Text = Convert.ToString(b3);
                label36.Text = Convert.ToString(0);
                label37.Text = Convert.ToString(b2 + b3);//

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);
            }
            else if (pr1 == 4 && pr2 == 2 && pr3 == 3 && pr4 == 1)
            {

                double wt1 = (b2 + b3 + b4);
                double wt2 = (b4);
                double wt3 = (b2 + b4);
                double wt4 = (0);

                label34.Text = Convert.ToString(b2 + b3 + b4);
                label35.Text = Convert.ToString(b4);
                label36.Text = Convert.ToString(b2 + b4);
                label37.Text = Convert.ToString(0);

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);

            }
            else if (pr1 == 4 && pr2 == 3 && pr3 == 1 && pr4 == 2)
            {


                double wt1 = (b2 + b3 + b4);
                double wt2 = (b3 + b4);
                double wt3 = (0);
                double wt4 = (b3);//

                label34.Text = Convert.ToString(b2 + b3 + b4);
                label35.Text = Convert.ToString(b3 + b4);
                label36.Text = Convert.ToString(0);
                label37.Text = Convert.ToString(b3);//

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);
            }
            else if (pr1 == 4 && pr2 == 3 && pr3 == 2 && pr4 == 1)
            {

                double wt1 = (b2 + b3 + b4);
                double wt2 = (b3 + b4);
                double wt3 = (b4);
                double wt4 = (0); //

                label34.Text = Convert.ToString(b2 + b3 + b4);
                label35.Text = Convert.ToString(b3 + b4);
                label36.Text = Convert.ToString(b4);
                label37.Text = Convert.ToString(0);

                label43.Text = Convert.ToString(wt1 + wt2 + wt3 + wt4);
                label45.Text = Convert.ToString((wt1 + wt2 + wt3 + wt4) / 4);
            }

            // Allocation Time
            if (pr1 == 1 && pr2 == 2 && pr3 == 3 && pr4 == 4)
            {

                double at1 = (b1);
                double at2 = (b1 + b2);
                double at3 = (b1 + b2 + b3);
                double at4 = (b1 + b2 + b3 + b4);

                label38.Text = Convert.ToString(b1);
                label39.Text = Convert.ToString(b1 + b2);
                label40.Text = Convert.ToString(b1 + b2 + b3);
                label41.Text = Convert.ToString(b1 + b2 + b3 + b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 1 && pr2 == 2 && pr3 == 4 && pr4 == 3)
            {

                double at1 = (b1);
                double at2 = (b1 + b2);
                double at3 = (b1 + b2 + b4 + b3);
                double at4 = (b1 + b2 + b3);

                label38.Text = Convert.ToString(b1);
                label39.Text = Convert.ToString(b1 + b2);
                label40.Text = Convert.ToString(b1 + b2 + b4 + b3);
                label41.Text = Convert.ToString(b1 + b2 + b3);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 1 && pr2 == 3 && pr3 == 2 && pr4 == 4)
            {

                double at1 = (b1);
                double at2 = (b1 + b3 + b2);
                double at3 = (b1 + b3);
                double at4 = (b1 + b2 + b3 + b4);

                label38.Text = Convert.ToString(b1);
                label39.Text = Convert.ToString(b1 + b3 + b2);
                label40.Text = Convert.ToString(b1 + b3);
                label41.Text = Convert.ToString(b1 + b2 + b3 + b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 1 && pr2 == 3 && pr3 == 4 && pr4 == 2)
            {

                double at1 = (b1);
                double at2 = (b1 + b4 + b2);
                double at3 = (b1 + b2 + b4 + b3);
                double at4 = (b1 + b4);

                label38.Text = Convert.ToString(b1);
                label39.Text = Convert.ToString(b1 + b4 + b2);
                label40.Text = Convert.ToString(b1 + b2 + b4 + b3);
                label41.Text = Convert.ToString(b1 + b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 1 && pr2 == 4 && pr3 == 2 && pr4 == 3)
            {

                double at1 = (b1);
                double at2 = (b1 + b3 + b4 + b2);
                double at3 = (b1 + b3);
                double at4 = (b1 + b3 + b4);

                label38.Text = Convert.ToString(b1);
                label39.Text = Convert.ToString(b1 + b3 + b4 + b2);
                label40.Text = Convert.ToString(b1 + b3);
                label41.Text = Convert.ToString(b1 + b3 + b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 1 && pr2 == 4 && pr3 == 3 && pr4 == 2)
            {

                double at1 = (b1);
                double at2 = (b1 + b3 + b4 + b2);
                double at3 = (b1 + b4 + b3);
                double at4 = (b1 + b4);

                label38.Text = Convert.ToString(b1);
                label39.Text = Convert.ToString(b1 + b3 + b4 + b2);
                label40.Text = Convert.ToString(b1 + b4 + b3);
                label41.Text = Convert.ToString(b1 + b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 2 && pr2 == 1 && pr3 == 3 && pr4 == 4)
            {

                double at1 = (b2 + b1);
                double at2 = (b2);
                double at3 = (b1 + b2 + b3);
                double at4 = (b1 + b2 + b3 + b4);

                label38.Text = Convert.ToString(b2 + b1);
                label39.Text = Convert.ToString(b2);
                label40.Text = Convert.ToString(b1 + b2 + b3);
                label41.Text = Convert.ToString(b1 + b2 + b3 + b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 2 && pr2 == 1 && pr3 == 4 && pr4 == 3)
            {

                double at1 = (b2 + b1);
                double at2 = (b1);
                double at3 = (b1 + b2 + b4 + b3);
                double at4 = (b1 + b2 + b3);

                label38.Text = Convert.ToString(b2 + b1);
                label39.Text = Convert.ToString(b1);
                label40.Text = Convert.ToString(b1 + b2 + b4 + b3);
                label41.Text = Convert.ToString(b1 + b2 + b3);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 2 && pr2 == 3 && pr3 == 1 && pr4 == 4)
            {

                double at1 = (b3 + b1);
                double at2 = (b1 + b3 + b2);
                double at3 = (b3);
                double at4 = (b1 + b2 + b3 + b4);

                label38.Text = Convert.ToString(b3 + b1);
                label39.Text = Convert.ToString(b1 + b3 + b2);
                label40.Text = Convert.ToString(b3);
                label41.Text = Convert.ToString(b1 + b2 + b3 + b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 2 && pr2 == 3 && pr3 == 4 && pr4 == 1)
            {

                double at1 = (b4 + b1);
                double at2 = (b1 + b4 + b2);
                double at3 = (b1 + b2 + b4 + b3);
                double at4 = (b4);

                label38.Text = Convert.ToString(b4 + b1);
                label39.Text = Convert.ToString(b1 + b4 + b2);
                label40.Text = Convert.ToString(b1 + b2 + b4 + b3);
                label41.Text = Convert.ToString(b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 2 && pr2 == 4 && pr3 == 1 && pr4 == 3)
            {

                double at1 = (b3 + b1);
                double at2 = (b1 + b3 + b4 + b2);
                double at3 = (b3);
                double at4 = (b1 + b3 + b4);

                label38.Text = Convert.ToString(b3 + b1);
                label39.Text = Convert.ToString(b1 + b3 + b4 + b2);
                label40.Text = Convert.ToString(b3);
                label41.Text = Convert.ToString(b1 + b3 + b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 2 && pr2 == 4 && pr3 == 3 && pr4 == 1)
            {

                double at1 = (b4 + b1);
                double at2 = (b1 + b3 + b4 + b2);
                double at3 = (b1 + b4 + b3);
                double at4 = (b4);

                label38.Text = Convert.ToString(b4 + b1);
                label39.Text = Convert.ToString(b1 + b3 + b4 + b2);
                label40.Text = Convert.ToString(b1 + b4 + b3);
                label41.Text = Convert.ToString(b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 3 && pr2 == 1 && pr3 == 2 && pr4 == 4)
            {

                double at1 = (b4 + b1);
                double at2 = (b1 + b3 + b4 + b2);
                double at3 = (b1 + b4 + b3);
                double at4 = (b4);

                label38.Text = Convert.ToString(b2 + b3 + b1);
                label39.Text = Convert.ToString(b2);
                label40.Text = Convert.ToString(b2 + b3);
                label41.Text = Convert.ToString(b1 + b2 + b3 + b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 3 && pr2 == 1 && pr3 == 4 && pr4 == 2)
            {

                double at1 = (b2 + b4 + b1);
                double at2 = (b2);
                double at3 = (b1 + b2 + b4 + b3);
                double at4 = (b2 + b4);

                label38.Text = Convert.ToString(b2 + b4 + b1);
                label39.Text = Convert.ToString(b2);
                label40.Text = Convert.ToString(b1 + b2 + b4 + b3);
                label41.Text = Convert.ToString(b2 + b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 3 && pr2 == 2 && pr3 == 1 && pr4 == 4)
            {

                double at1 = (b2 + b3 + b1);
                double at2 = (b3 + b2);
                double at3 = (b3);
                double at4 = (b1 + b2 + b3 + b4);

                label38.Text = Convert.ToString(b2 + b3 + b1);
                label39.Text = Convert.ToString(b3 + b2);
                label40.Text = Convert.ToString(b3);
                label41.Text = Convert.ToString(b1 + b2 + b3 + b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 3 && pr2 == 2 && pr3 == 4 && pr4 == 1)
            {

                double at1 = (b2 + b4 + b1);
                double at2 = (b4 + b2);
                double at3 = (b1 + b2 + b4 + b3);
                double at4 = (b4);

                label38.Text = Convert.ToString(b2 + b4 + b1);
                label39.Text = Convert.ToString(b4 + b2);
                label40.Text = Convert.ToString(b1 + b2 + b4 + b3);
                label41.Text = Convert.ToString(b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 3 && pr2 == 4 && pr3 == 1 && pr4 == 2)
            {

                double at1 = (b3 + b4 + b1);
                double at2 = (b1 + b3 + b4 + b2);
                double at3 = (b3);
                double at4 = (b3 + b4);

                label38.Text = Convert.ToString(b3 + b4 + b1);
                label39.Text = Convert.ToString(b1 + b3 + b4 + b2);
                label40.Text = Convert.ToString(b3);
                label41.Text = Convert.ToString(b3 + b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 3 && pr2 == 4 && pr3 == 2 && pr4 == 1)
            {

                double at1 = (b3 + b4 + b1);
                double at2 = (b1 + b3 + b4 + b2);
                double at3 = (b4 + b3);
                double at4 = (b4);

                label38.Text = Convert.ToString(b3 + b4 + b1);
                label39.Text = Convert.ToString(b1 + b3 + b4 + b2);
                label40.Text = Convert.ToString(b4 + b3);
                label41.Text = Convert.ToString(b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 4 && pr2 == 1 && pr3 == 2 && pr4 == 3)
            {

                double at1 = (b2 + b3 + b4 + b1);
                double at2 = (b2);
                double at3 = (b2 + b3);
                double at4 = (b2 + b3 + b4);

                label38.Text = Convert.ToString(b2 + b3 + b4 + b1);
                label39.Text = Convert.ToString(b2);
                label40.Text = Convert.ToString(b2 + b3);
                label41.Text = Convert.ToString(b2 + b3 + b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 4 && pr2 == 1 && pr3 == 3 && pr4 == 2)
            {

                double at1 = (b2 + b3 + b4 + b1);
                double at2 = (b2);
                double at3 = (b2 + b4 + b3);
                double at4 = (b2 + b4);

                label38.Text = Convert.ToString(b2 + b3 + b4 + b1);
                label39.Text = Convert.ToString(b2);
                label40.Text = Convert.ToString(b2 + b4 + b3);
                label41.Text = Convert.ToString(b2 + b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 4 && pr2 == 2 && pr3 == 1 && pr4 == 3)
            {

                double at1 = (b2 + b3 + b4 + b1);
                double at2 = (b3 + b2);
                double at3 = (b3);
                double at4 = (b2 + b3 + b4);

                label38.Text = Convert.ToString(b2 + b3 + b4 + b1);
                label39.Text = Convert.ToString(b3 + b2);
                label40.Text = Convert.ToString(b3);
                label41.Text = Convert.ToString(b2 + b3 + b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 4 && pr2 == 2 && pr3 == 3 && pr4 == 1)
            {

                double at1 = (b2 + b3 + b4 + b1);
                double at2 = (b4 + b2);
                double at3 = (b2 + b4 + b3);
                double at4 = (b4);

                label38.Text = Convert.ToString(b2 + b3 + b4 + b1);
                label39.Text = Convert.ToString(b4 + b2);
                label40.Text = Convert.ToString(b2 + b4 + b3);
                label41.Text = Convert.ToString(b4);

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 4 && pr2 == 3 && pr3 == 1 && pr4 == 2)
            {

                double at1 = (b2 + b3 + b4 + b1);
                double at2 = (b3 + b4 + b2);
                double at3 = (b3);
                double at4 = (b3 + b4);//

                label38.Text = Convert.ToString(b2 + b3 + b4 + b1);
                label39.Text = Convert.ToString(b3 + b4 + b2);
                label40.Text = Convert.ToString(b3);
                label41.Text = Convert.ToString(b3 + b4);//

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);

            }
            else if (pr1 == 4 && pr2 == 3 && pr3 == 2 && pr4 == 1)
            {

                double at1 = (b2 + b3 + b4 + b1);
                double at2 = (b3 + b4 + b2);
                double at3 = (b3 + b4);
                double at4 = (b4); //

                label38.Text = Convert.ToString(b2 + b3 + b4 + b1);
                label39.Text = Convert.ToString(b3 + b4 + b2);
                label40.Text = Convert.ToString(b3 + b4);
                label41.Text = Convert.ToString(b4); //

                label47.Text = Convert.ToString(at1 + at2 + at3 + at4);
                label49.Text = Convert.ToString((at1 + at2 + at3 + at4) / 4);
            }
            
        }
    }
}
