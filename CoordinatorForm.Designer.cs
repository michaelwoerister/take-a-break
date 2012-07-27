namespace take_a_break
{
    partial class CoordinatorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoordinatorForm));
            this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this._notifyIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._workTimer = new System.Windows.Forms.Timer(this.components);
            this._notifyIconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _notifyIcon
            // 
            this._notifyIcon.ContextMenuStrip = this._notifyIconContextMenu;
            this._notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("_notifyIcon.Icon")));
            this._notifyIcon.Text = "take-a-break";
            this._notifyIcon.Visible = true;
            // 
            // _notifyIconContextMenu
            // 
            this._notifyIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this._notifyIconContextMenu.Name = "_notifyIconContextMenu";
            this._notifyIconContextMenu.Size = new System.Drawing.Size(153, 48);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // _workTimer
            // 
            this._workTimer.Enabled = true;
            this._workTimer.Interval = 500;
            this._workTimer.Tick += new System.EventHandler(this.WorkTimerTick);
            // 
            // CoordinatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 71);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CoordinatorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "take-a-break coordinator form";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.CoordinatorFormLoad);
            this._notifyIconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon _notifyIcon;
        private System.Windows.Forms.Timer _workTimer;
        private System.Windows.Forms.ContextMenuStrip _notifyIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}