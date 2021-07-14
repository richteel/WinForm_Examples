using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialFolders
{
    public partial class UC_ButtonAndLink : UserControl
    {
        public event EventHandler Clicked;

        protected virtual void OnClicked(EventArgs e)
        {
            EventHandler eh = Clicked;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        public string ButtonText
        {
            get { return button1.Text; }
            set { button1.Text = value; }
        }

        public string LinkText
        {
            get { return linkLabel1.Text; }
            set { linkLabel1.Text = value; }
        }

        public string LinkUrl
        {
            get
            {
                if (linkLabel1.Tag == null)
                    return "";
                else
                    return linkLabel1.Tag.ToString();
            }
            set { linkLabel1.Tag = value; }
        }


        public UC_ButtonAndLink()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Tag == null)
                return;

            string target = linkLabel1.Tag.ToString();

            if(!string.IsNullOrEmpty(target))
            {
                System.Diagnostics.Process.Start(target);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnClicked(e);
        }
    }
}
