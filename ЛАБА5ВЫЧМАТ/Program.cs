using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБА5ВЫЧМАТ
{
    public static class Program
    { 

        public delegate decimal MyFunction(decimal x);

        public static decimal F(decimal x) => (1.0m + x) * (1.0m + x) / (x * x * x * (decimal)Math.Sqrt((double)(2.0m + x)));

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
