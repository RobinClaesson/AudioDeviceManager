namespace AudioDeviceManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputDevicePanel = new System.Windows.Forms.Panel();
            this.OutputsLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rescanAudioDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDevicePanel = new System.Windows.Forms.Panel();
            this.InputsLabel = new System.Windows.Forms.Label();
            this.outputDevicePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.inputDevicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputDevicePanel
            // 
            this.outputDevicePanel.AutoScroll = true;
            this.outputDevicePanel.Controls.Add(this.OutputsLabel);
            this.outputDevicePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.outputDevicePanel.Location = new System.Drawing.Point(0, 24);
            this.outputDevicePanel.Name = "outputDevicePanel";
            this.outputDevicePanel.Size = new System.Drawing.Size(200, 406);
            this.outputDevicePanel.TabIndex = 0;
            // 
            // OutputsLabel
            // 
            this.OutputsLabel.AutoSize = true;
            this.OutputsLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputsLabel.Location = new System.Drawing.Point(12, 9);
            this.OutputsLabel.Name = "OutputsLabel";
            this.OutputsLabel.Size = new System.Drawing.Size(119, 32);
            this.OutputsLabel.TabIndex = 0;
            this.OutputsLabel.Text = "Outputs";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rescanAudioDevicesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // rescanAudioDevicesToolStripMenuItem
            // 
            this.rescanAudioDevicesToolStripMenuItem.Name = "rescanAudioDevicesToolStripMenuItem";
            this.rescanAudioDevicesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.rescanAudioDevicesToolStripMenuItem.Text = "&Rescan audio devices";
            this.rescanAudioDevicesToolStripMenuItem.Click += new System.EventHandler(this.RescanAudioDevicesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // inputDevicePanel
            // 
            this.inputDevicePanel.AutoScroll = true;
            this.inputDevicePanel.Controls.Add(this.InputsLabel);
            this.inputDevicePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.inputDevicePanel.Location = new System.Drawing.Point(307, 24);
            this.inputDevicePanel.Name = "inputDevicePanel";
            this.inputDevicePanel.Size = new System.Drawing.Size(200, 406);
            this.inputDevicePanel.TabIndex = 2;
            // 
            // InputsLabel
            // 
            this.InputsLabel.AutoSize = true;
            this.InputsLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InputsLabel.Location = new System.Drawing.Point(12, 9);
            this.InputsLabel.Name = "InputsLabel";
            this.InputsLabel.Size = new System.Drawing.Size(104, 32);
            this.InputsLabel.TabIndex = 0;
            this.InputsLabel.Text = "Inputs";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 430);
            this.Controls.Add(this.inputDevicePanel);
            this.Controls.Add(this.outputDevicePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Audio Device Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.outputDevicePanel.ResumeLayout(false);
            this.outputDevicePanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.inputDevicePanel.ResumeLayout(false);
            this.inputDevicePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel outputDevicePanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem rescanAudioDevicesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label OutputsLabel;
        private Panel inputDevicePanel;
        private Label InputsLabel;
    }
}