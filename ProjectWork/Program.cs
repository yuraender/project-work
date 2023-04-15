using ProjectWork.Forms;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ProjectWork {

    public static class Program {

        [STAThread]
        private static void Main() {
            using (Mutex mutex = new Mutex(false, "Global\\" + Assembly
                .GetExecutingAssembly().GetCustomAttribute<GuidAttribute>().Value)) {
                if (!mutex.WaitOne(0, false)) {
                    return;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
