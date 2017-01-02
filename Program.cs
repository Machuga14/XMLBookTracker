using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLBookTracker
{
	/// <summary>
	/// Static Program class
	/// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. 3.141592653589793238462643383279
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestForm());
        }
    }
}
