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
    public partial class FormHelp : Form
    {
        /*** Fields and Constants ***/
        #region
        #endregion

        /*** Properties ***/
        #region
        #endregion

        /*** Constructor & Initialization ***/
        #region
        #endregion

        /*** Public Events ***/
        #region
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
        #endregion
        public FormHelp()
        {
            InitializeComponent();
        }

        private void FormHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
