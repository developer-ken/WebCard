namespace WebCard
{
    partial class DefaultWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultWindow));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifybarMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建卡片CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.卡片设置OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.彻底退出QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifybarMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(1, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 87);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "此窗口不应当被显示。如果您看到了此窗口，请联系开发者。";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.notifybarMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WebCard";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // notifybarMenu
            // 
            this.notifybarMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建卡片CToolStripMenuItem,
            this.卡片设置OToolStripMenuItem,
            this.关于AToolStripMenuItem,
            this.彻底退出QToolStripMenuItem});
            this.notifybarMenu.Name = "notifybarMenu";
            this.notifybarMenu.Size = new System.Drawing.Size(143, 92);
            this.notifybarMenu.Opened += new System.EventHandler(this.notifybarMenu_Opened);
            // 
            // 新建卡片CToolStripMenuItem
            // 
            this.新建卡片CToolStripMenuItem.Name = "新建卡片CToolStripMenuItem";
            this.新建卡片CToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.新建卡片CToolStripMenuItem.Text = "新建卡片(&C)";
            this.新建卡片CToolStripMenuItem.Click += new System.EventHandler(this.新建卡片CToolStripMenuItem_Click);
            // 
            // 卡片设置OToolStripMenuItem
            // 
            this.卡片设置OToolStripMenuItem.Name = "卡片设置OToolStripMenuItem";
            this.卡片设置OToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.卡片设置OToolStripMenuItem.Text = "卡片设置(&O)";
            this.卡片设置OToolStripMenuItem.Click += new System.EventHandler(this.卡片设置OToolStripMenuItem_Click);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            // 
            // 彻底退出QToolStripMenuItem
            // 
            this.彻底退出QToolStripMenuItem.Name = "彻底退出QToolStripMenuItem";
            this.彻底退出QToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.彻底退出QToolStripMenuItem.Text = "彻底退出(&Q)";
            this.彻底退出QToolStripMenuItem.Click += new System.EventHandler(this.彻底退出QToolStripMenuItem_Click);
            // 
            // DefaultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 88);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefaultWindow";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "WebCard Backgroud Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DefaultWindow_FormClosing);
            this.Load += new System.EventHandler(this.DefaultWindow_Load);
            this.notifybarMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip notifybarMenu;
        private ToolStripMenuItem 新建卡片CToolStripMenuItem;
        private ToolStripMenuItem 关于AToolStripMenuItem;
        private ToolStripMenuItem 彻底退出QToolStripMenuItem;
        private ToolStripMenuItem 卡片设置OToolStripMenuItem;
    }
}