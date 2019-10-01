using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTrackerPjan
{
    static class Log
    {
        static StringBuilder log = new StringBuilder();
        
        public static void Write(string text)
        {
            log.AppendLine(String.Format("[{0}]{1}", DateTime.Now.ToString(), text));
        }

        public static void Save()
        {
            using (SaveFileDialog savefile = new SaveFileDialog())
            {
                savefile.Filter = "Text File | *.txt";
                DialogResult result = savefile.ShowDialog();
                if (result == DialogResult.OK)
                {
                    File.WriteAllText(savefile.FileName, log.ToString());
                }
            }
        }
    }
}
