using System;
using System.Windows.Forms;

namespace Santiago_BSIT_WM_202_Lesson3Activity
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EnrollmentForm());
        }
    }
}