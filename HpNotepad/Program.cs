using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HpNotepad
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            //声明互斥体。   
            Mutex mutex = new Mutex(false, "ThisShouldOnlyRunOnce");
            //判断互斥体是否使用中。   
            bool Running = !mutex.WaitOne(0, false);
            if (!Running) {
                FrmMain main = new HpNotepad.FrmMain();
               Application.Run(main);
              
            }
            //else
            //    MessageBox.Show("应用程序已经启动！");

        }
    }
}
