using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБА5ВЫЧМАТ
{
    public static class Program
    { 

        public delegate double MyFunction(double x);

        public static double F(double x) => (1.0 + x) * (1.0 + x) / (x * x * x * Math.Sqrt(2.0 + x));

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
