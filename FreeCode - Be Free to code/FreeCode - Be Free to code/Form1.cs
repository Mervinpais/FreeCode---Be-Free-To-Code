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
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Text.RegularExpressions;

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
        public class Error_Codes
        {
            public static String Reading_No_File_Error = "0xr00001";
            public static String Command_Not_Recognised = "0xcnr00001";
        }
        public class Read_error1 : Exception
        {
            //Overriding the Message property
            public override string Message
            {
                get
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    return $"Please make sure there is a .txt file in W14-Sharp >> W14-Sharp_coding_language >> bin >> Debug >> netcoreapp3.1 \nPlease close this program, insert your file, then reopen this program and then type in 'read *file name*.txt' \n Error_Code: " + Error_Codes.Reading_No_File_Error + "\n Error_Name: READING_NO_FILE_ERROR \n";
                }
            }
        }
        public class Command_error1 : Exception
        {
            //Overriding the Message property
            public override string Message
            {
                get
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    return $"Error is not recognised as an internal/external command. Error_Code:" + Error_Codes.Command_Not_Recognised + " Error_Name: COMMAND_NOT_RECOGNISED";
                }
            }
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
        public static class Check {
   public static int CheckOccurrences(string str1, string pattern) {
      int count = 0;
      int a = 0;
      while ((a = str1.IndexOf(pattern, a)) != -1) {
         a += pattern.Length;
         count++;
      }
      return count;
   }
}
        static void python_test() //this is  a test to see if c# and python can work together to make the language have more features :D
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\mervi\AppData\Local\Programs\Python\Python39\python.exe";
            var script = @"C:\Users\mervi\source\repos\W14-Sharp\W14-Sharp_coding_language\Python_help\python-to-extend-w14-sharp.py";

            psi.Arguments = $"\"{script}\"";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            var errors = "";
            var results = "";

            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }
            Console.WriteLine("The Results and Errors are here below");
            Console.WriteLine("Results");
            Console.WriteLine(results);
            Console.WriteLine();
            Console.WriteLine("Errors");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errors);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains("Say"))
            {
                string find = "Say";
                if (richTextBox1.Text.Contains(find))
                {
                    var matchString = Regex.Escape(find);
                    foreach (Match match in Regex.Matches(richTextBox1.Text, matchString))
                    {
                        richTextBox1.Select(match.Index, find.Length);
                        richTextBox1.SelectionColor = Color.DodgerBlue;
                        richTextBox1.Select(richTextBox1.TextLength, 0);
                        richTextBox1.SelectionColor = richTextBox1.ForeColor;
                    };
                }
                char find_char = '"';
                if (richTextBox1.Text.Contains(find_char))
                {
                    var matchString = Regex.Escape(find_char.ToString());
                    foreach (Match match in Regex.Matches(richTextBox1.Text, matchString))
                    {
                        richTextBox1.Select(match.Index, find.Length);
                        richTextBox1.SelectionColor = Color.DarkOrange;
                        richTextBox1.Select(richTextBox1.TextLength, 0);
                        richTextBox1.SelectionColor = richTextBox1.ForeColor;
                    };
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string codeline;
            Console.WriteLine("W14# Coding Terminal - Checker");
            Console.WriteLine("==============================");            
            codeline = richTextBox1.Text;
            if (codeline.Contains("Say"))
            {
                codeline = codeline.Replace("Say", "");
                richTextBox2.Text += codeline + Environment.NewLine;
            }
            else if (codeline == "time")
            {
                string Date_and_time = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
                richTextBox2.Text += (Date_and_time) + Environment.NewLine;
            }
            else if (codeline.Contains("math"))
            {
                Global.num1 = Convert.ToInt32(codeline.Substring(5, 1));
                Global.num2 = Convert.ToInt32(codeline.Substring(7, 1));
                if (codeline.Substring(6, 1) == "+")
                {
                    Global.Math_result = Global.num1 + Global.num2;
                    richTextBox2.Text += Global.Math_result + ToString() + Environment.NewLine;
                }
                else if (codeline.Substring(6, 1) == "-")
                {
                    Global.Math_result = (Global.num1 - Global.num2);
                    richTextBox2.Text += Global.Math_result + ToString() + Environment.NewLine;
                }
                else if (codeline.Substring(6, 1) == "*")
                {
                    Global.Math_result = Global.num1 * Global.num2;
                    richTextBox2.Text += Global.Math_result + ToString() + Environment.NewLine;
                }
                else if (codeline.Substring(6, 1) == "/")
                {
                    Global.Math_result = Global.num1 / Global.num2;
                    richTextBox2.Text += Global.Math_result + ToString() + Environment.NewLine;
                }
            }
            if (codeline == "python")
            {
                python_test();
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
            /*else
            {
                richTextBox2.Text = "ERROR(not really but); did you type any code in to compile?";
            } */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*saveDialog_message MessageBox = new saveDialog_message();
            MessageBox.show("you clicked me","Save",saveDialog_message.MessageBoxButton.YesNo);*/
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                richTextBox1.Text = text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            W14_Sharp_Doc Help_on_W14 = new W14_Sharp_Doc();
            Help_on_W14.Show();
        }
    }
}  

