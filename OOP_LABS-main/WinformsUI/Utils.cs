using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinformsUI
{
    public class Utils
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, int options);

        public static void FillOutputLog(string[]? multilineMessage, TextBox textBox, string? fillDivider = null)
        {
            if (multilineMessage == null)
                return;

            foreach (var str in multilineMessage)
            {
                textBox.Text += str + "\r" + "\n";
                textBox.Text += "---------------------------------------" + "\r" + "\n";
            }
            if (fillDivider != null)
            {
                textBox.Text += fillDivider + "\r" + "\n";
            }
        }

        public static void FillOutputLog(string? message, TextBox textBox, string? fillDivider = null)
        {
            if (message == null)
                return;

            textBox.Text += message + "\r" + "\n";
            if (fillDivider != null)
            {
                textBox.Text += fillDivider + "\r" + "\n";
            }
        }
    }
}
