using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TouchlessClasses
{
    class WindowFunctions
    {

        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;

        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string lp1, string lp2);
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        private void button1_Click(object sender, EventArgs e)
        {
            // retrieve Notepad main window handle
            IntPtr hWnd = FindWindow("Notepad", "Untitled - Notepad");
            if (!hWnd.Equals(IntPtr.Zero))
            {
                // SW_SHOWMAXIMIZED to maximize the window
                // SW_SHOWMINIMIZED to minimize the window
                // SW_SHOWNORMAL to make the window be normal size
                ShowWindowAsync(hWnd, SW_SHOWMAXIMIZED);
            }
        }

    }
}
