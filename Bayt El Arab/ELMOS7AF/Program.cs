using ELMOS7AF.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELMOS7AF
{
    static class Program
    {
     public static String incomming;
       
        [STAThread]
        static void Main()
        {  Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
          
        }
    }
}
