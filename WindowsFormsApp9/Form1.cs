using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randNum;
            string word = "";
            Random rNum = new Random();
            String[] rchars = new String[4]; TextWriter text1 = new StreamWriter("F:\\AdvWorks\\filewrite.txt");

            for (int i = 0; i < 4; i++)
            {
                randNum = rNum.Next(1, 37);
                switch (randNum)
                {
                    case 1:
                        word = "a";
                        break;
                    case 2:
                        word = "b";
                        break;
                    case 3:
                        word = "c";
                        break;
                    case 4:
                        word = "d";
                        break;
                    case 5:
                        word = "e";
                        break;
                    case 6:
                        word = "f";
                        break;
                    case 7:
                        word = "g";
                        break;
                    case 8:
                        word = "h";
                        break;
                    case 9:
                        word = "i";
                        break;
                    case 10:
                        word = "j";
                        break;
                    case 11:
                        word = "k";
                        break;
                    case 12:
                        word = "l";
                        break;
                    case 13:
                        word = "m";
                        break;
                    case 14:
                        word = "n";
                        break;
                    case 15:
                        word = "o";
                        break;
                    case 16:
                        word = "p";
                        break;
                    case 17:
                        word = "q";
                        break;
                    case 18:
                        word = "r";
                        break;
                    case 19:
                        word = "s";
                        break;
                    case 20:
                        word = "t";
                        break;
                    case 21:
                        word = "u";
                        break;
                    case 22:
                        word = "v";
                        break;
                    case 23:
                        word = "w";
                        break;
                    case 24:
                        word = "x";
                        break;
                    case 25:
                        word = "y";
                        break;
                    case 26:
                        word = "z";
                        break;
                    case 27:
                        word = "0";
                        break;
                    case 28:
                        word = "1";
                        break;
                    case 29:
                        word = "2";
                        break;
                    case 30:
                        word = "3";
                        break;
                    case 31:
                        word = "4";
                        break;
                    case 32:
                        word = "5";
                        break;
                    case 33:
                        word = "6";
                        break;
                    case 34:
                        word = "7";
                        break;
                    case 35:
                        word = "8";
                        break;
                    case 36:
                        word = "9";
                        break;
                }

                rchars[i] = word;
                
                text1.Write(rchars[i]);
            }


            text1.Close();
        }
    }
    
}
