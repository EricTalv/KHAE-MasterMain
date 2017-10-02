using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHAE
{
    public partial class ProfilesMenu : Form
    {
        public ProfilesMenu()
        {
            InitializeComponent();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
