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
using Syroot.Windows.IO;
using System.IO;

namespace SpecialFolders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AppendText(string message)
        {
            if (richTextBox1.Text.Length > 0)
                richTextBox1.AppendText("\r\n");

            richTextBox1.AppendText(message);
        }

        private void uC_ButtonAndLink1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            AppendText(String.Format("{0}\t{1}\t{2}\t{3}", "#", "KnownFolder Type", "Path", "Path Exists"));
            foreach (Environment.SpecialFolder folder_type in Enum.GetValues(typeof(Environment.SpecialFolder)))
            {
                AppendText(String.Format("{0}\t{1}\t{2}\t{3}", ((int)folder_type), folder_type.ToString(), 
                    Environment.GetFolderPath(folder_type), Directory.Exists(Environment.GetFolderPath(folder_type))));
            }
            richTextBox1.Select(0, 0);
        }

        private void uC_ButtonAndLink2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            AppendText(String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", "#", "KnownFolder Type", "Path", "Default Path", "Diff", "Path Exists", "Default Path Exists"));
            // Go through each KnownFolderType enumeration member.
            foreach (KnownFolderType type in Enum.GetValues(typeof(KnownFolderType)))
            {
                KnownFolder knownFolder = new KnownFolder(type);

                // Write down the current and default path.
                try
                {
                    AppendText(String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", ((int)knownFolder.Type), knownFolder.Type.ToString(), knownFolder.Path, knownFolder.DefaultPath, 
                        knownFolder.Path.ToLower() == knownFolder.DefaultPath.ToLower() ? "": "Diff",
                        Directory.Exists(knownFolder.Path), Directory.Exists(knownFolder.DefaultPath)));
                }
                catch (ExternalException ex)
                {
                    // While uncommon with personal folders, other KnownFolders don't exist on every system, and trying
                    // to query those returns an error which we catch here.
                    Console.WriteLine(string.Format("{0}\t<Exception> {1}", knownFolder.Type.ToString(), ex.ErrorCode));
                }
            }
            richTextBox1.Select(0, 0);
        }
    }
}
