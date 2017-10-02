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
    public partial class Menu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        String lang = "";

        Form SMenu = new SaveMenu();
        Form LMenu = new LoadMenu();
        Form SeMenu = new SettingsMenu();
        Form PMenu = new ProfilesMenu();
        Form CMenu = new CreditsMenu();

        public Menu()
        {
            InitializeComponent();
        }

        private void EST_Click(object sender, EventArgs e)
        {
            lang = "EST";
            if (lang !="")
            {

                this.DialogResult = DialogResult.OK;

            }

        }

        private void ENG_Click(object sender, EventArgs e)
        {
            lang = "";
            if (lang != "")
            {

                this.DialogResult = DialogResult.OK;

            }
            else
                MessageBox.Show("Keel ei ole lisatud", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RUS_Click(object sender, EventArgs e)
        {
            lang = "";
            if (lang != "")
            {

                this.DialogResult = DialogResult.OK;

            }
            else
                MessageBox.Show("Keel ei ole lisatud", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string LangSat()
        {
            return lang;
        }


        private void BCredits_Click(object sender, EventArgs e)
        {
            if (SMenu.Visible == false)
            {
                SMenu = new SaveMenu();
            }

            SMenu.Visible = true;
            SMenu.Activate();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BStart_Click(object sender, EventArgs e)
        {
            lang = "EST";
            if (lang != "")
            {

                this.DialogResult = DialogResult.OK;

            }
        }
        private void BStart_MouseHover(object sender, EventArgs e)
        {
            BStart.Image = Properties.Resources.BStartACT_1;
        }
        private void BStart_MouseLeave(object sender, EventArgs e)
        {
            BStart.Image = Properties.Resources.BStartINACT__1;
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            if(SMenu.Visible == false)
            {
                SMenu = new SaveMenu();
            }

            SMenu.Visible = true;
            SMenu.Activate();
        }
        private void BSave_MouseHover(object sender, EventArgs e)
        {
            BSave.Image = Properties.Resources.BSaveACT__2;
        }
        private void BSave_MouseLeave(object sender, EventArgs e)
        {
            BSave.Image = Properties.Resources.BSaveINACT__4;
        }

        private void BLoad_Click(object sender, EventArgs e)
        {
            if (LMenu.Visible == false)
            {
                LMenu = new LoadMenu();
            }

            LMenu.Visible = true;
            LMenu.Activate();

        }
        private void BLoad_MouseHover(object sender, EventArgs e)
        {
            BLoad.Image = Properties.Resources.BLoadACT_2;
        }
        private void BLoad_MouseLeave(object sender, EventArgs e)
        {
            BLoad.Image = Properties.Resources.BLoadINACT__2;
        }

        private void BSettings_Click(object sender, EventArgs e)
        {
            if(SeMenu.Visible == false)
            {
                SeMenu = new SettingsMenu();
            }

            SeMenu.Visible = true;
            SeMenu.Activate();
                
        }
        private void BSettings_MouseHover(object sender, EventArgs e)
        {
            BSettings.Image = Properties.Resources.BSettingsACT_2;
        }
        private void BSettings_MouseLeave(object sender, EventArgs e)
        {
            BSettings.Image = Properties.Resources.BSettingsINACT__2;
        }

        private void BProfiles_Click(object sender, EventArgs e)
        {
            if (PMenu.Visible == false)
            {
                PMenu = new ProfilesMenu();
            }

            PMenu.Visible = true;
            PMenu.Activate();
        }
        private void BProfiles_MouseHover(object sender, EventArgs e)
        {
            BProfiles.Image = Properties.Resources.BProfilesACT_2;
        }
        private void BProfiles_MouseLeave(object sender, EventArgs e)
        {
            BProfiles.Image = Properties.Resources.BProfilesINACT__2;
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BExit_MouseHover(object sender, EventArgs e)
        {
            BExit.Image = Properties.Resources.BExitACT_3;

        }
        private void BExit_MouseLeave(object sender, EventArgs e)
        {
            BExit.Image = Properties.Resources.BExitINACT__2;

        }

        private void BCredits_MouseHover(object sender, EventArgs e)
        {
            BCredits.Image = Properties.Resources.BCreditsACT_1;

        }

        private void BCredits_MouseLeave(object sender, EventArgs e)
        {
            BCredits.Image = Properties.Resources.BCreditsINACT__1;

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //Save property value
            Properties.Settings.Default.Save();

            //Set MAudio to retrieve VALUE from PROPERTIES
            int MAudio = Convert.ToInt32(Properties.Settings.Default["MasterAudio"]);

            //Set ToolStripMAudio.Text to MAudio VALUE
            TSMasterAudio.Text = $"Master Audio: {MAudio}%"; Convert.ToString(Properties.Settings.Default["MasterAudio"]);


        }

    }
}
