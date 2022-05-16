// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace WedgeKey
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Reflection;
    using System.Windows.Forms;
    using Gma.System.MouseKeyHook;
    using PublicDomain;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The count.
        /// </summary>
        private int count = 0;

        /// <summary>
        /// The key code.
        /// </summary>
        private Keys keyCode;

        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// The m global hook.
        /// </summary>
        private IKeyboardMouseEvents m_GlobalHook;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:WedgeKey.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Set icons */

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set icon for Free Releases @ PublicDomain.is menu item
            this.freeReleasesPublicDomainisToolStripMenuItem.Image = this.associatedIcon.ToBitmap();
        }

        /// <summary>
        /// Handles the msdn link label link clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMsdnLinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open MSDN
            Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=windowsdesktop-6.0");
        }

        /// <summary>
        /// Handles the start stop button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnStartStopButtonClick(object sender, EventArgs e)
        {
            // Check for Star(t) vs Sto(p)
            if (this.startStopButton.Text.EndsWith("t", StringComparison.InvariantCulture))
            {
                // Subscribe
                this.Subscribe();

                // Change to stop
                this.startStopButton.Text = "&Stop";
                this.startStopButton.ForeColor = Color.Red;
            }
            else
            {
                // Unsubscribe
                this.Unsubscribe();

                // Reset to start
                this.startStopButton.Text = "&Start";
                this.startStopButton.ForeColor = Color.DarkGreen;
            }
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check for Star(t) vs Sto(p)
            if (this.startStopButton.Text.EndsWith("p", StringComparison.InvariantCulture))
            {
                // Click the button to stop
                this.startStopButton.PerformClick();
            }

            // Reset count
            this.count = 0;

            // Reset labels
            this.countToolStripStatusLabel.Text = "0";
            this.keyCodeToolStripStatusLabel.Text = "-";
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our website
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread redditcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadRedditcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.reddit.com/r/software/comments/uqvjoq/software_to_assign_a_keyboard_key_to_an_external/");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/wedge-key");
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"MouseKeyHook library by gmamaladze - MIT License{Environment.NewLine}" +
                $"https://github.com/gmamaladze/globalmousekeyhook{Environment.NewLine}{Environment.NewLine}" +
                $"Wedges-wood icon by cocoparisienne - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/photos/wooden-wedges-wood-wedges-wedge-340632/s{Environment.NewLine}{Environment.NewLine}" +
                $"Reddit icon used according to published brand guidelines{Environment.NewLine}" +
                $"https://www.redditinc.com/brand{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"PublicDomain icon is based on the following source images:{Environment.NewLine}{Environment.NewLine}" +
                $"Bitcoin by GDJ - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/bitcoin-digital-currency-4130319/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter P by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/p-glamour-gold-lights-2790632/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter D by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/d-glamour-gold-lights-2790573/{Environment.NewLine}{Environment.NewLine}";

            // Prepend supporters
            licenseText = $"RELEASE SUPPORTERS:{Environment.NewLine}{Environment.NewLine}* Jesse Reichler{Environment.NewLine}* Max P.{Environment.NewLine}* Kathryn S.{Environment.NewLine}* Y0himba{Environment.NewLine}{Environment.NewLine}=========={Environment.NewLine}{Environment.NewLine}" + licenseText;

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for: u/Clemobide{ Environment.NewLine}Reddit.com{Environment.NewLine}Day #136, Week #20 @ May 16, 2022",
                licenseText,
                this.Icon.ToBitmap())
            {
                // Set about form icon
                Icon = this.associatedIcon,

                // Set always on top
                TopMost = this.TopMost
            };

            // Show about form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Subscribe this instance.
        /// </summary>
        public void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.KeyDown += OnGlobalHookKeyDown;
        }

        /// <summary>
        /// Unsubscribe this instance.
        /// </summary>
        public void Unsubscribe()
        {
            m_GlobalHook.KeyDown -= OnGlobalHookKeyDown;

            m_GlobalHook.Dispose();
        }

        /// <summary>
        /// Handles the global hook key down.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnGlobalHookKeyDown(object sender, KeyEventArgs e)
        {
            // Raise count
            this.count++;

            // Update count label
            this.countToolStripStatusLabel.Text = $"{this.count}";

            // Update KeyCode label
            this.keyCodeToolStripStatusLabel.Text = $"{Convert.ToInt32(e.KeyCode)}";

            // Send key
            try
            {
                SendKeys.SendWait(this.keyComboBox.Text);
            }
            catch (Exception ex)
            {
                // Let it wall through
            }
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }
    }
}
