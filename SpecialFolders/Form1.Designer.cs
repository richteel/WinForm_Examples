
namespace SpecialFolders
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.uC_ButtonAndLink1 = new SpecialFolders.UC_ButtonAndLink();
            this.uC_ButtonAndLink2 = new SpecialFolders.UC_ButtonAndLink();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.uC_ButtonAndLink2);
            this.splitContainer1.Panel1.Controls.Add(this.uC_ButtonAndLink1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(790, 440);
            this.splitContainer1.SplitterDistance = 84;
            this.splitContainer1.TabIndex = 3;
            // 
            // uC_ButtonAndLink1
            // 
            this.uC_ButtonAndLink1.ButtonText = "Do not Use (System.Environment)";
            this.uC_ButtonAndLink1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uC_ButtonAndLink1.LinkText = "Source";
            this.uC_ButtonAndLink1.LinkUrl = "http://csharphelper.com/blog/2016/11/list-the-locations-of-special-folders-in-c/";
            this.uC_ButtonAndLink1.Location = new System.Drawing.Point(0, 0);
            this.uC_ButtonAndLink1.Name = "uC_ButtonAndLink1";
            this.uC_ButtonAndLink1.Size = new System.Drawing.Size(275, 84);
            this.uC_ButtonAndLink1.TabIndex = 2;
            this.uC_ButtonAndLink1.Clicked += new System.EventHandler(this.uC_ButtonAndLink1_Click);
            // 
            // uC_ButtonAndLink2
            // 
            this.uC_ButtonAndLink2.ButtonText = "Use P/Invoke WinAPI (SHGetKnownFolderPath)";
            this.uC_ButtonAndLink2.Dock = System.Windows.Forms.DockStyle.Left;
            this.uC_ButtonAndLink2.LinkText = "Source";
            this.uC_ButtonAndLink2.LinkUrl = "https://www.codeproject.com/Articles/878605/Getting-All-Special-Folders-in-NET";
            this.uC_ButtonAndLink2.Location = new System.Drawing.Point(275, 0);
            this.uC_ButtonAndLink2.Name = "uC_ButtonAndLink2";
            this.uC_ButtonAndLink2.Size = new System.Drawing.Size(275, 84);
            this.uC_ButtonAndLink2.TabIndex = 3;
            this.uC_ButtonAndLink2.Clicked += new System.EventHandler(this.uC_ButtonAndLink2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(790, 352);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private UC_ButtonAndLink uC_ButtonAndLink2;
        private UC_ButtonAndLink uC_ButtonAndLink1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

