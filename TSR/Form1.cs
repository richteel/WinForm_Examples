using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSR
{
    public partial class Form1 : Form
    {
        /*** Fields and Constants ***/
        #region
        #endregion

        /*** Properties ***/
        #region
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        /*** Public Events ***/
        #region
        public event EventHandler<EventArgs> ExitRequested;

        protected void FrmMain_ExitRequested()
        {
            ExitRequested?.Invoke(this, new EventArgs());
        }

        public event EventHandler<EventArgs> ViewAboutRequested;

        protected void FrmMain_ViewAboutRequested()
        {
            ViewAboutRequested?.Invoke(this, new EventArgs());
        }

        public new event EventHandler<EventArgs> HelpRequested;

        protected void FrmMain_HelpRequested()
        {
            HelpRequested?.Invoke(this, new EventArgs());
        }

        public event EventHandler<EventArgs> ViewHelpRequested;

        protected void FrmMain_ViewHelpRequested()
        {
            ViewHelpRequested?.Invoke(this, new EventArgs());
        }
        #endregion

        /*** Public Methods ***/
        #region
        #endregion

        /*** Protected Methods ***/
        #region
        #endregion

        /*** Private Methods ***/
        #region
        #endregion

        /*** Event Handlers ***/
        #region
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMain_ViewAboutRequested();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMain_ExitRequested();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void ViewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMain_ViewHelpRequested();
        }
        #endregion
    }
}
