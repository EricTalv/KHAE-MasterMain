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
using KHAE.Properties;

namespace KHAE
{
    public partial class SettingsMenu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public SettingsMenu()
        {
            InitializeComponent();

            CBxLanguage.Items.Add("Estonian");
            CBxLanguage.Items.Add("Russian");
            CBxLanguage.Items.Add("English");

            LBxQuality.Items.Add("Low");
            LBxQuality.Items.Add("Medium");
            LBxQuality.Items.Add("High");
            LBxQuality.Items.Add("Ultra");

        }

        private void SettingsMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void AudioCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(AudioCheck.Checked == false)
            {
                TBMasterV.Enabled = false;
                TBSoundFX.Enabled = false;
                TBMusicV.Enabled = false;

                LMusicV.ForeColor = Color.LightGray;
                LMasterVolume.ForeColor = Color.LightGray;
                LSoundFX.ForeColor = Color.LightGray;

                TBMasterV.Value = 0;
                TBSoundFX.Value = 0;
                TBMusicV.Value = 0;
            }

            else
            {
                TBMasterV.Enabled = true;
                TBSoundFX.Enabled = true;
                TBMusicV.Enabled = true;

                LMusicV.ForeColor = Color.White;
                LMasterVolume.ForeColor = Color.White;
                LSoundFX.ForeColor = Color.White;
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BApply_Click(object sender, EventArgs e)
        {
            // Properties.Settings.Default["TestText"] = textBox1.Text;
            // label2.Text = Properties.Settings.Default["TestText"].ToString();

            //Taking Trackbar value and setting it to MasterAudio Property
            Properties.Settings.Default["MasterAudio"] = TBMasterV.Value;

            //Save Added Property Settings
            Properties.Settings.Default.Save();

            //Indicator
            MessageBox.Show("Saved");
                
        }

        private void SettingsMenu_Load(object sender, EventArgs e)
        {
            //label2.Text = Properties.Settings.Default["TestText"].ToString();

            //Set Label2.Text DEFAULT VALUE to PROPERTIES DEFAULT VALUE
            label2.Text = Properties.Settings.Default["MasterAudio"].ToString();

            //Setting Trackbar to Property Value
            TBMasterV.Value = Convert.ToInt32(Properties.Settings.Default["MasterAudio"]);
            
        } 
    }
}
