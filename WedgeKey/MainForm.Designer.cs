
namespace WedgeKey
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.activeTimer = new System.Windows.Forms.Timer(this.components);
			this.keyLabel = new System.Windows.Forms.Label();
			this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.startStopButton = new System.Windows.Forms.Button();
			this.keyComboBox = new System.Windows.Forms.ComboBox();
			this.msdnLinkLabel = new System.Windows.Forms.LinkLabel();
			this.countToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.countTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.keyCodeTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.keyCodeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.originalThreadRedditcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainTableLayoutPanel.SuspendLayout();
			this.mainStatusStrip.SuspendLayout();
			this.mainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// activeTimer
			// 
			this.activeTimer.Interval = 1000;
			// 
			// keyLabel
			// 
			this.keyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.keyLabel.Location = new System.Drawing.Point(3, 0);
			this.keyLabel.Name = "keyLabel";
			this.keyLabel.Size = new System.Drawing.Size(97, 30);
			this.keyLabel.TabIndex = 0;
			this.keyLabel.Text = "&Key:";
			this.keyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mainTableLayoutPanel
			// 
			this.mainTableLayoutPanel.ColumnCount = 2;
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainTableLayoutPanel.Controls.Add(this.keyLabel, 0, 0);
			this.mainTableLayoutPanel.Controls.Add(this.startStopButton, 0, 2);
			this.mainTableLayoutPanel.Controls.Add(this.keyComboBox, 1, 0);
			this.mainTableLayoutPanel.Controls.Add(this.msdnLinkLabel, 0, 1);
			this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
			this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			this.mainTableLayoutPanel.RowCount = 3;
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.mainTableLayoutPanel.Size = new System.Drawing.Size(206, 126);
			this.mainTableLayoutPanel.TabIndex = 57;
			// 
			// startStopButton
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.startStopButton, 2);
			this.startStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.startStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startStopButton.ForeColor = System.Drawing.Color.DarkGreen;
			this.startStopButton.Location = new System.Drawing.Point(3, 63);
			this.startStopButton.Name = "startStopButton";
			this.startStopButton.Size = new System.Drawing.Size(200, 60);
			this.startStopButton.TabIndex = 4;
			this.startStopButton.Text = "&Start";
			this.startStopButton.UseVisualStyleBackColor = true;
			this.startStopButton.Click += new System.EventHandler(this.OnStartStopButtonClick);
			// 
			// keyComboBox
			// 
			this.keyComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.keyComboBox.FormattingEnabled = true;
			this.keyComboBox.Items.AddRange(new object[] {
									"{BACKSPACE}",
									"{BREAK}",
									"{CAPSLOCK}",
									"{DELETE}",
									"{DOWN}",
									"{END}",
									"{ENTER}",
									"{ESC}",
									"{HELP}",
									"{HOME}",
									"{INSERT}",
									"{LEFT}",
									"{NUMLOCK}",
									"{PGDN}",
									"{PGUP}",
									"{PRTSC}",
									"{RIGHT}",
									"{SCROLLLOCK}",
									"{TAB}",
									"{UP}",
									"{F1}",
									"{F2}",
									"{F3}",
									"{F4}",
									"{F5}",
									"{F6}",
									"{F7}",
									"{F8}",
									"{F9}",
									"{F10}",
									"{F11}",
									"{F12}",
									"{F13}",
									"{F14}",
									"{F15}",
									"{F16}",
									"{ADD}",
									"{SUBTRACT}",
									"{MULTIPLY}",
									"{DIVIDE}"});
			this.keyComboBox.Location = new System.Drawing.Point(106, 3);
			this.keyComboBox.Name = "keyComboBox";
			this.keyComboBox.Size = new System.Drawing.Size(97, 21);
			this.keyComboBox.TabIndex = 5;
			this.keyComboBox.Text = "{F11}";
			// 
			// msdnLinkLabel
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.msdnLinkLabel, 2);
			this.msdnLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.msdnLinkLabel.Location = new System.Drawing.Point(3, 30);
			this.msdnLinkLabel.Name = "msdnLinkLabel";
			this.msdnLinkLabel.Size = new System.Drawing.Size(200, 30);
			this.msdnLinkLabel.TabIndex = 6;
			this.msdnLinkLabel.TabStop = true;
			this.msdnLinkLabel.Text = "MSDN reference";
			this.msdnLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.msdnLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnMsdnLinkLabelLinkClicked);
			// 
			// countToolStripStatusLabel
			// 
			this.countToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.countToolStripStatusLabel.Name = "countToolStripStatusLabel";
			this.countToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
			this.countToolStripStatusLabel.Text = "0";
			// 
			// countTextToolStripStatusLabel
			// 
			this.countTextToolStripStatusLabel.Name = "countTextToolStripStatusLabel";
			this.countTextToolStripStatusLabel.Size = new System.Drawing.Size(43, 17);
			this.countTextToolStripStatusLabel.Text = "Count:";
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.countTextToolStripStatusLabel,
									this.countToolStripStatusLabel,
									this.keyCodeTextToolStripStatusLabel,
									this.keyCodeToolStripStatusLabel});
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 150);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Size = new System.Drawing.Size(206, 22);
			this.mainStatusStrip.SizingGrip = false;
			this.mainStatusStrip.TabIndex = 55;
			// 
			// keyCodeTextToolStripStatusLabel
			// 
			this.keyCodeTextToolStripStatusLabel.Name = "keyCodeTextToolStripStatusLabel";
			this.keyCodeTextToolStripStatusLabel.Size = new System.Drawing.Size(54, 17);
			this.keyCodeTextToolStripStatusLabel.Text = "KeyCode";
			// 
			// keyCodeToolStripStatusLabel
			// 
			this.keyCodeToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.keyCodeToolStripStatusLabel.Name = "keyCodeToolStripStatusLabel";
			this.keyCodeToolStripStatusLabel.Size = new System.Drawing.Size(12, 17);
			this.keyCodeToolStripStatusLabel.Text = "-";
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem1,
									this.optionsToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(206, 24);
			this.mainMenuStrip.TabIndex = 56;
			// 
			// fileToolStripMenuItem1
			// 
			this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.toolStripSeparator3,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
			this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem1.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.alwaysOnTopToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "&Options";
			this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
			// 
			// alwaysOnTopToolStripMenuItem
			// 
			this.alwaysOnTopToolStripMenuItem.Checked = true;
			this.alwaysOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
			this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.freeReleasesPublicDomainisToolStripMenuItem,
									this.originalThreadRedditcomToolStripMenuItem,
									this.sourceCodeGithubcomToolStripMenuItem,
									this.toolStripSeparator2,
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// freeReleasesPublicDomainisToolStripMenuItem
			// 
			this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
			this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
			this.freeReleasesPublicDomainisToolStripMenuItem.Text = "&Free Releases @ PublicDomain.is";
			this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
			// 
			// originalThreadRedditcomToolStripMenuItem
			// 
			this.originalThreadRedditcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadRedditcomToolStripMenuItem.Image")));
			this.originalThreadRedditcomToolStripMenuItem.Name = "originalThreadRedditcomToolStripMenuItem";
			this.originalThreadRedditcomToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
			this.originalThreadRedditcomToolStripMenuItem.Text = "Original thread @ Reddit.com";
			this.originalThreadRedditcomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadRedditcomToolStripMenuItemClick);
			// 
			// sourceCodeGithubcomToolStripMenuItem
			// 
			this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
			this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
			this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
			this.sourceCodeGithubcomToolStripMenuItem.Text = "&Source code @ Github.com";
			this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(243, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AcceptButton = this.startStopButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(206, 172);
			this.Controls.Add(this.mainTableLayoutPanel);
			this.Controls.Add(this.mainStatusStrip);
			this.Controls.Add(this.mainMenuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WedgeKey";
			this.TopMost = true;
			this.mainTableLayoutPanel.ResumeLayout(false);
			this.mainStatusStrip.ResumeLayout(false);
			this.mainStatusStrip.PerformLayout();
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripStatusLabel keyCodeToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel keyCodeTextToolStripStatusLabel;
		private System.Windows.Forms.LinkLabel msdnLinkLabel;
		private System.Windows.Forms.ComboBox keyComboBox;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem originalThreadRedditcomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.StatusStrip mainStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel countTextToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel countToolStripStatusLabel;
		private System.Windows.Forms.Button startStopButton;
		private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
		private System.Windows.Forms.Label keyLabel;
		private System.Windows.Forms.Timer activeTimer;
	}
}
