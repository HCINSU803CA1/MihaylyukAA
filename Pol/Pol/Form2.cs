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


        private char GetSign(char character)
        {

                if (character == '+')
                {
                    return '+';
                }
                if (character == '*')
                {
                    return '*';
                }
                if (character == '/')
                {
                    return '/';
                }
                if (character == '-')
                {
                    return '-';
                }

            return character;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            char returnedSign = ' ';

            if ((!textBox1.Text.Equals("")) && (!textBox1.Text.EndsWith("=")))
            {
                Array = new double[2];
                first.Replace(" ", "");

                var s = first;
                
                foreach (var sign in s)
                {
                   returnedSign = GetSign(sign);
                }

                var stringArray = s.Split(new char[] { '+', '-', '*', '/'});
               // Console.WriteLine(returnedSign);
                
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
                 Console.WriteLine("ret"+ returnedSign);
                if (first.EndsWith("="))
                {
                   
                    double Result = Array[0] - Array[1];
                    label1.Text = (Convert.ToString(Result));

                    //Console.WriteLine(Array[0] + Array[1]);
                }
            
            
        }
    }
}
