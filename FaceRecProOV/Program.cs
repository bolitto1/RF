using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Detector_facial
{
    static class Program
    {
      
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
           Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmlogin   ());
        }
        public static bool IsNumeric(this string input)
        {

            int test;
            return int.TryParse(input, out test);
        }
    }
}
