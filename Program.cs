/**
 * @author Name: "Adnan Maruf"
 * @project Name: "VoiceBox"
 * @year: 2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinMailClientApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string filename = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\UData\\User_Settings.txt";
            if (File.Exists(filename))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filename);
                    string state = lines[1].ToString();
                    if (state.Equals("Voice-Recognition = 1"))
                    {
                        Application.Run(new VoiceBox());
                    }
                    else if (state.Equals("Voice-Recognition = 0"))
                    {
                        Application.Run(new login());
                    }
                }
                catch(Exception ex)
                {
                    //
                }
            }
        }
    }
}
