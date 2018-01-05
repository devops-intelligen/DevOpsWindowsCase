using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevOpsWindowCase
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DevOpsWindowCase());
        }


     }
    public class MathsHelper
    {
        public MathsHelper() { }
        public int Add(int a, int b)
        {
            int x = a + b;
            return x;
        }

        public int Subtract(int a, int b)
        {
            int x = a - b;
            return x;
        }

        public int Multiplication(int a, int b)
        {
            int x = a * b;
            return x;
        }

        public int Division(int a, int b)
        {
            int x = a / b;
            return x;
        }
    }
}
