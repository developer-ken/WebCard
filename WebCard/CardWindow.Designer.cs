namespace WebCard
{
    partial class CardWindow
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webview = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.movepannel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resizePannel = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Minsize = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webview)).BeginInit();
            this.movepannel.SuspendLayout();
            this.CloseBtn.SuspendLayout();
            this.Minsize.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.webview);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 255);
            this.panel1.TabIndex = 0;
            // 
            // webview
            // 
            this.webview.AllowExternalDrop = true;
            this.webview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webview.CreationProperties = null;
            this.webview.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webview.Location = new System.Drawing.Point(0, 0);
            this.webview.Name = "webview";
            this.webview.Size = new System.Drawing.Size(278, 255);
            this.webview.TabIndex = 0;
            this.webview.ZoomFactor = 1D;
            // 
            // movepannel
            // 
            this.movepannel.BackColor = System.Drawing.Color.DarkViolet;
            this.movepannel.Controls.Add(this.panel2);
            this.movepannel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.movepannel.Location = new System.Drawing.Point(0, 0);
            this.movepannel.Name = "movepannel";
            this.movepannel.Size = new System.Drawing.Size(23, 23);
            this.movepannel.TabIndex = 1;
            this.movepannel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.movepannel_MouseClick);
            this.movepannel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movepannel_MouseDown);
            this.movepannel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movepannel_MouseMove);
            this.movepannel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.movepannel_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkViolet;
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Location = new System.Drawing.Point(55, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(23, 22);
            this.panel2.TabIndex = 2;
            // 
            // resizePannel
            // 
            this.resizePannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizePannel.BackColor = System.Drawing.Color.Lime;
            this.resizePannel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.resizePannel.Location = new System.Drawing.Point(261, 239);
            this.resizePannel.Name = "resizePannel";
            this.resizePannel.Size = new System.Drawing.Size(23, 23);
            this.resizePannel.TabIndex = 2;
            this.resizePannel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizePannel_MouseDown);
            this.resizePannel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resizePannel_MouseMove);
            this.resizePannel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizePannel_MouseUp);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.Red;
            this.CloseBtn.Controls.Add(this.panel4);
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Location = new System.Drawing.Point(261, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(23, 23);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseBtn_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkViolet;
            this.panel4.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel4.Location = new System.Drawing.Point(55, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 22);
            this.panel4.TabIndex = 2;
            // 
            // Minsize
            // 
            this.Minsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Minsize.BackColor = System.Drawing.Color.Gold;
            this.Minsize.Controls.Add(this.panel5);
            this.Minsize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minsize.Location = new System.Drawing.Point(0, 239);
            this.Minsize.Name = "Minsize";
            this.Minsize.Size = new System.Drawing.Size(23, 23);
            this.Minsize.TabIndex = 4;
            this.Minsize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minsize_MouseClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkViolet;
            this.panel5.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel5.Location = new System.Drawing.Point(55, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(23, 22);
            this.panel5.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.movepannel);
            this.Controls.Add(this.resizePannel);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Minsize);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CardWindow";
            this.Opacity = 0.5D;
            this.Text = "WebCard";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CardWindow_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movepannel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movepannel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.movepannel_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webview)).EndInit();
            this.movepannel.ResumeLayout(false);
            this.CloseBtn.ResumeLayout(false);
            this.Minsize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webview;
        private Panel movepannel;
        private Panel resizePannel;
        private Panel panel2;
        private Panel CloseBtn;
        private Panel panel4;
        private Panel Minsize;
        private Panel panel5;
        private System.Windows.Forms.Timer timer1;
    }
}