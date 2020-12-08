/**
 * @author Name: "Adnan Maruf"
 * @project Name: "VoiceBox"
 * @year: 2019
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMailClientApp
{
    public partial class VBScratchpad : Form
    {
        SoundPlayer scPad;

        public VBScratchpad()
        {
            InitializeComponent();
            scPad = new SoundPlayer("ScratchpadOpen.wav");
            scPad.Play();
            VoiceBox.WindowHide += VoiceBox_WindowHide;
            VoiceBox.WindowHide_ += VoiceBox_WindowHide_;
            int Dwidth = Screen.PrimaryScreen.Bounds.Width;
            int loc = Dwidth - 394;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(loc / 15, 150);
        }

        private void VoiceBox_WindowHide_(object sender, EventArgs e)
        {
            TypeMaster.Text = String.Empty;
            this.Close();
        }

        private void VoiceBox_WindowHide(object sender, EventArgs e)
        {
            TypeMaster.Text = String.Empty;
            this.Close();
        }
    }
}
