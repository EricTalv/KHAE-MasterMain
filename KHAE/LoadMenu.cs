using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KHAE
{
    public partial class LoadMenu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                        int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public LoadMenu()
        {
            InitializeComponent();

            LBLoads.Items.Add("Chapter 1: Lets Begin                                    WED/28/09/17");
            LBLoads.Items.Add("Chapter 1: 'Where am i?'                               WED/25/09/17");
            LBLoads.Items.Add("Chapter 1: Captivated                                    WED/24/09/17");

        }

        private void LoadMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BLoad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
