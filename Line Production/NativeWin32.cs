using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Line_Production
{
    public static class NativeWin32
    {
        [DllImport("user32.dll")]
        public static extern int FindWindow(
         string lpClassName, // class name 
         string lpWindowName // window name 
     );
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(
          int hWnd // handle to window
          );
        [DllImport("user32.dll")]
        public static extern IntPtr SetForegroundWindow(
                    IntPtr hWnd // handle to window
                    );
    }
}
