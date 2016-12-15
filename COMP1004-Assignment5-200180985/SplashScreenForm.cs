using COMP1004_Assignment5_200180985.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment5_200180985
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Resources.sgclip_wav);

            player.Play(); //10.519s audio clip
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            this.SplashScreenTimer.Stop();
            this.SplashScreenTimer.Enabled = false;

            SlotMachineForm slotMachineForm = new SlotMachineForm();
            this.Hide();
            slotMachineForm.Show();
        }
    }
}
