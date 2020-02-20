using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pol
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private double[] Array;
       

        private char getSign(char character)
        {
            char ch = ' ';
            switch (character)
            {
                case '+':
                    {
                        ch = '+';
                        break;
                    }
                case '-':
                    {
                        ch = '-';
                        break;
                    }
                case '*':
                    {
                        ch = '*';
                        break;

                    }
                case '/':
                    {
                        ch = '/';
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return ch;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string first = textBox1.Text;

            if ((!textBox1.Text.Equals("")) && (!textBox1.Text.EndsWith("=")))
            {
                Array = new double[2];
                first.Replace(" ", "");

                var s = first;
                char returnedSign = ' ';
                foreach (var sign in s)
                {
                   returnedSign = getSign(sign);
                }

                var stringArray = s.Split(returnedSign);
                foreach (var text in stringArray)
                {
                    if (!text.Equals(""))
                    {
                        
                        var number = int.Parse(text);
                        Console.WriteLine(number);

                        //Array.Append(number);
                        if (Array[0] == 0)
                        {
                            Array[0] = number;
                        }
                        else
                        {
                            Array[1] = number;
                        }

                        Console.WriteLine(Array[0]);
                    }
                }
            }
            if (first.EndsWith("="))
            {
                double Result = Array[0] + Array[1];
                label1.Text=(Convert.ToString(Result));
                Console.WriteLine(Array[0] + Array[1]);
            }
        }
    }
}

