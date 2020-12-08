/**
 * @author Name: "Adnan Maruf"
 * @project Name: "VoiceBox"
 * @year: 2019
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMailClientApp
{
    public partial class InfoControl : UserControl
    {
        public event EventHandler ClosePushNoti;

        public InfoControl()
        {
            InitializeComponent();
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            EventHandler handler = ClosePushNoti;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
            CloseTimer.Stop();
        }

        private void CntrlCloseBtn_Click(object sender, EventArgs e)
        {
            EventHandler handler = ClosePushNoti;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void InfoControl_Load(object sender, EventArgs e)
        {
            //CloseTimer.Start();
        }
    }
}
