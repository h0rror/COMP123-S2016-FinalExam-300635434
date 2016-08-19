using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Final Exam - Character Generator
 * Nikola Savin
 * COMP 123
 * 300635434
 * Summer 2016
 */
namespace COMP123_S2016_FinalExam
{
    public static class Program
    {
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());                // Opens the SplashForm when application starts.
            Application.Run(new GenerateNameForm());          // Opens the GenerateNameForm after the splash form is closed

        }
    }
}
