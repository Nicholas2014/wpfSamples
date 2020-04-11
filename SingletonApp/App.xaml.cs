using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace SingletonApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var initiallyOwned = true;

            var mutex = new Mutex(initiallyOwned, "singleton", out bool isCreatedNew);
            if (!(initiallyOwned && isCreatedNew))
            {
                //MessageBox.Show("程序已运行!");
                //Shutdown();
                var h = FindWindowW(null, "Singleton Application");
                if (h != IntPtr.Zero)
                {
                    SetForegroundWindow(h);
                }
                Shutdown();
            }
        }



        [DllImport("User32", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindowW(string lpClassName, string lpWindowName);
        [DllImport("User32", CharSet = CharSet.Unicode)]
        static extern Boolean SetForegroundWindow(IntPtr hWnd);

    }
}
