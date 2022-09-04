using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive.Utility
{
    /// <summary>
    /// This class handles all the error or message printing needs.
    /// </summary>
    static class MessagePrinter
    {
        public static void PrintToConsole(string text, string caption)
        {
            Console.WriteLine($"\n<<MESSAGE>> {caption}:\n{text}\n\n");
        }

        public static void PrintToMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(text, caption, buttons, icon);
        }

        public static void PrintToErrorLabel(Label errorLabel, string message)
        {
            errorLabel.Text = message;
        }

        public static DialogResult PrintToMessageBoxV2(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(text, caption, buttons, icon);
        }
    }
}
