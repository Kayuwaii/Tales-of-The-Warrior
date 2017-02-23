using System;
using System.Windows.Forms;

namespace Tales_of_The_Warrior
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TalesOfTheWarrior());
            var launch = new LAUNCHER();
            launch.Show();
            Application.Run();

            GC.Collect();
            GC.WaitForPendingFinalizers();

        }


    }
}
