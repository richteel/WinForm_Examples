using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocalizationExample
{
    public partial class Form1 : Form
    {
        /*** Fields and Constants ***/
        #region
        readonly string[] images = { "ThisPersonDoesNotExist001", "ThisPersonDoesNotExist002", "ThisPersonDoesNotExist003", 
            "ThisPersonDoesNotExist004", "ThisPersonDoesNotExist005", "ThisPersonDoesNotExist006", "ThisPersonDoesNotExist007", 
            "ThisPersonDoesNotExist008", "ThisPersonDoesNotExist009", "ThisPersonDoesNotExist010", "ThisPersonDoesNotExist011", 
            "ThisPersonDoesNotExist012", "ThisPersonDoesNotExist013", "ThisPersonDoesNotExist014" };
        readonly bool[] imageDisplayed;
        readonly Random rnd;
        private string lblTimerRootText;
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public Form1()
        {
            InitializeComponent();

            imageDisplayed = new bool[images.Length];
            rnd = new Random();
        }
        #endregion

        /*** Private Methods ***/
        #region
        private void DisplayRandomPicture()
        {
            int r = rnd.Next(0, images.Length - 1);

            ReadyDisplayArray();

            for (int i = 0; i < imageDisplayed.Length; i++)
            {
                if (r >= imageDisplayed.Length)
                    r = 0;

                if (!imageDisplayed[r])
                    break;

                r++;
            }

            imageDisplayed[r] = true;

            pictureBox1.Image = (Bitmap)LocalizationExample.Properties.Resources.ResourceManager.GetObject(images[r]);

            Console.WriteLine(string.Format("Display Image {0}\t{1}", r, images[r]));
        }

        private void ReadyDisplayArray()
        {
            bool freeSlots = false;

            for (int i = 0; i < imageDisplayed.Length; i++)
            {
                if (!imageDisplayed[i])
                {
                    freeSlots = true;
                    break;
                }
            }

            if (!freeSlots)
            {
                ResetDisplayArray();
            }
        }

        private void ResetDisplayArray()
        {
            for (int i = 0; i < imageDisplayed.Length; i++)
            {
                imageDisplayed[i] = false;
            }
            Console.WriteLine("ResetDisplayArray()");
        }

        private void UpdateTimerStatus()
        {
            cmdYes.Enabled = false;
            //cmdYes.BackColor = SystemColors.Control;
            cmdNo.Enabled = false;
            //cmdNo.BackColor = SystemColors.Control;

            if (timer1.Enabled)
                cmdNo.Enabled = true;
            else
                cmdYes.Enabled = true;

            lblTimerRunStatus.Text = string.Format("{0}: {1}", lblTimerRootText, cmdNo.Enabled? cmdYes.Text : cmdNo.Text);
        }
        #endregion

        /*** Event Handlers ***/
        #region
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox1 aboutBox = new AboutBox1()) {

                aboutBox.ShowDialog(this);
            }
        }

        private void cmdTimerToggle_Click(object sender, EventArgs e)
        {
            if (sender.GetType() != typeof(Button))
                return;

            timer1.Enabled = (sender == cmdYes);

            UpdateTimerStatus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTimerRootText = lblTimer.Text;
            ResetDisplayArray();
            DisplayRandomPicture();
            timer1.Interval = 5000;
            timer1.Start();
            UpdateTimerStatus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            DisplayRandomPicture();

            timer1.Start();
        }
        #endregion
    }
}
