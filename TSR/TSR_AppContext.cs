using System;
using System.Windows.Forms;

namespace TSR
{
    public class TSR_AppContext : ApplicationContext
    {
        /*** Fields and Constants ***/
        #region
        private Form1 mainForm;
        private FormHelp helpForm;
        private AboutBox1 aboutForm;
        private NotifyIcon notifyIcon;
        #endregion

        /*** Properties ***/
        #region
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public TSR_AppContext()
        {
            Init();
        }
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
        private void Init()
        {
            Console.WriteLine("Application has started");

            mainForm = new Form1();
            mainForm.ExitRequested += Exit;
            mainForm.HelpRequested += ShowHelp;
            mainForm.ViewHelpRequested += ShowHelp;
            mainForm.ViewAboutRequested += ShowAbout;

            helpForm = new FormHelp();
            aboutForm = new AboutBox1();

            MenuItem showMainMenuItem = new MenuItem("Main Window", new EventHandler(ShowMain));
            MenuItem showHelpMenuItem = new MenuItem("Help", new EventHandler(ShowHelp));
            MenuItem showAboutMenuItem = new MenuItem("About", new EventHandler(ShowAbout));
            MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));

            notifyIcon = new NotifyIcon
            {
                Icon = TSR.Properties.Resources.MyAppIcon,
                ContextMenu = new ContextMenu(new MenuItem[]
                {
                    showMainMenuItem,
                    showHelpMenuItem,
                    showAboutMenuItem,
                    exitMenuItem
                })
            };

            notifyIcon.BalloonTipClicked += NotifyIcon_BalloonTipClicked;
            notifyIcon.MouseClick += NotifyIcon_MouseClick;
            notifyIcon.Text = Application.ProductName;
            notifyIcon.Visible = true;
            Console.WriteLine("Initialization Complete");
        }
        #endregion

        /*** Event Handlers ***/
        #region
        private void Exit(object sender, EventArgs e)
        {
            // We must manually tidy up and remove the icon before we exit.
            // Otherwise it will be left behind until the user mouses over.
            notifyIcon.Visible = false;
            Application.Exit();

            Console.WriteLine("Application has ended");
        }

        private void NotifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            Console.WriteLine("NotifyIcon_BalloonTipClicked");
        }

        private void NotifyIcon_MouseClick(Object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            ShowMain(sender, null);
        }

        private void ShowAbout(object sender, EventArgs e)
        {
            Console.WriteLine("ShowAbout");

            // If we are already showing the window, merely focus it.
            if (aboutForm.Visible)
            {
                aboutForm.Activate();
            }
            else
            {
                aboutForm.ShowDialog();
            }
        }

        private void ShowHelp(object sender, EventArgs e)
        {
            Console.WriteLine("ShowHelp");

            // If we are already showing the window, merely focus it.
            if (helpForm.Visible)
            {
                helpForm.Activate();
            }
            else
            {
                helpForm.Show();
            }
        }

        private void ShowMain(object sender, EventArgs e)
        {
            Console.WriteLine("ShowMain");

            // If we are already showing the window, merely focus it.
            if (mainForm.Visible)
            {
                mainForm.Activate();
            }
            else
            {
                mainForm.Show();
            }

            notifyIcon.ShowBalloonTip(20, "Test", "Hello World", ToolTipIcon.Info);
        }
        #endregion
    }
}
