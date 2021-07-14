using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FreeCode___Be_Free_to_code
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class Global
        {
            //public static string name;
            //public static String Name { get; set; }
            //public static String code1;
            //public static String code2;
            //public static int repeat_times;
            //public static String store_code_say;
            //public static String store_code_repeat;
            //public static String repeat_store1;
            public static String if_statement_contains;  //* This is where most of the variable are kept, its like a storage room where a commands takes a variable and
            public static String var_string;             //* then keeps it back once its done.
            public static Boolean var_bool;
            public static String ask;
            public static String func;
            public static String variable1;
            public static String variable2;
            public static String variable3;
            public static String variable4;
            public static String variable5;
            public static int num2;
            public static int num1;
            public static int Math_result;
            /*NEW VARIABLES FOR THE IDE*/
            public static String Code;
            public static String Output_cache;
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codeline;
            Console.WriteLine("W14# Coding Terminal - Checker");
            Console.WriteLine("==============================");            
            codeline = richTextBox1.Text;
            if (codeline.StartsWith("Say"))
            {
                richTextBox2.Text = codeline.Substring(4) + Environment.NewLine;
            }
            else if (codeline == "time")
            {
                string Date_and_time = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
                Console.WriteLine(Date_and_time);
            }
            else if (codeline.Contains("math"))
            {
                Global.num1 = Convert.ToInt32(codeline.Substring(5, 1));
                Global.num2 = Convert.ToInt32(codeline.Substring(7, 1));
                if (codeline.Substring(6, 1) == "+")
                {
                    Global.num2 = Convert.ToInt32(codeline.Substring(7, 1));
                    Global.Math_result = Global.num1 + Global.num2;
                    richTextBox2.Text = Global.Math_result + ToString();
                }
                else if (codeline.Substring(6, 1) == "-")
                {
                    Global.num2 = Convert.ToInt32(codeline.Substring(7, 1));
                    Global.Math_result = (Global.num1 - Global.num2);
                    richTextBox2.Text = Global.Math_result + ToString();
                }
                else if (codeline.Substring(6, 1) == "*")
                {
                    Global.num2 = Convert.ToInt32(codeline.Substring(7, 1));
                    Global.Math_result = Global.num1 * Global.num2;
                    richTextBox2.Text = Global.Math_result + ToString();
                }
                else if (codeline.Substring(6, 1) == "/")
                {
                    Global.num2 = Convert.ToInt32(codeline.Substring(7, 1));
                    Global.Math_result = Global.num1 / Global.num2;
                    richTextBox2.Text = Global.Math_result + ToString();
                }
            }
            //}        
            //if (codeline.StartsWith("math"))
            //{
            //    Global.num1 = Convert.ToInt32(codeline.Substring(5, 1));
            //    Global.num2 = Convert.ToInt32(codeline.Substring(7, 1));
            //    if (codeline.Substring(6, 1) == "+")
            //    {
            //        Global.num2 = Convert.ToInt32(codeline.Substring(7, 1));
            //        Global.Math_result = Global.num1 + Global.num2;
            //        Console.WriteLine(Global.Math_result);
            //    }
            //    else if (codeline.Substring(6, 1) == "-")
            //    {
            //        Global.num2 = Convert.ToInt32(codeline.Substring(7, 1));
            //        Global.Math_result = (Global.num1 - Global.num2);
            //        Console.WriteLine(Global.Math_result);
            //    }
            //    else if (codeline.Substring(6, 1) == "*")
            //    {
            //        Global.num2 = Convert.ToInt32(codeline.Substring(7, 1));
            //        Global.Math_result = Global.num1 * Global.num2;
            //        Console.WriteLine(Global.Math_result);
            //    }
            //    else if (codeline.Substring(6, 1) == "/")
            //    {
            //        Global.num2 = Convert.ToInt32(codeline.Substring(7, 1));
            //        Global.Math_result = Global.num1 / Global.num2;
            //        Console.WriteLine(Global.Math_result);
            //    }

            //}
            //if (codeline.StartsWith("read"))     //Removed Since it will just causes bugs(in the IDE)
            //{
            //    if (codeline.Substring(4) != "")
            //    {
            //        string readText = File.ReadAllText(codeline.Substring(5) + ".txt");  // Read the contents of the file
            //        Console.WriteLine(readText);  // Output the content
            //    }
            //    else if (codeline.Substring(4) == "")
            //    {
            //        Console.WriteLine("Please make sure there is a .txt file in W14-Sharp >> W14-Sharp_coding_language >> bin >> Debug >> netcoreapp3.1");
            //        Console.WriteLine("Please close this program, insert your file, then reopen this program and then type in 'read *file name*.txt'");
            //    }
            //}
            else
            {
                richTextBox2.Text = "ERROR(not really but); did you type any code in to compile?";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
        }
    }
}  

