using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolBank
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
            Application.Run(new FmMenu());
        }   
        public const String ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SJBankCS.accdb";

        public static bool ValidAmount(string strAmount, double Min, double Max)
        {
            bool Valid = true;
            try
            {
                double Amount = Convert.ToDouble(strAmount);
                if (Amount < Min || Amount > Max)
                    Valid = false;
            }
            catch
            {
                Valid = false;
            }
            return Valid;
        }
    }

}
