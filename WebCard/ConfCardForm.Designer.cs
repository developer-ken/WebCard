namespace WebCard
{
    partial class ConfCardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.uuidb = new System.Windows.Forms.TextBox();
            this.urlbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gobutton = new System.Windows.Forms.Button();
            this.mopc = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.topmost = new System.Windows.Forms.CheckBox();
            this.clickthrough = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mopc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "UUID";
            // 
            // uuidb
            // 
            this.uuidb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uuidb.Location = new System.Drawing.Point(55, 6);
            this.uuidb.Name = "uuidb";
            this.uuidb.ReadOnly = true;
            this.uuidb.Size = new System.Drawing.Size(358, 16);
            this.uuidb.TabIndex = 1;
            // 
            // urlbox
            // 
            this.urlbox.Location = new System.Drawing.Point(55, 35);
            this.urlbox.Name = "urlbox";
            this.urlbox.Size = new System.Drawing.Size(299, 23);
            this.urlbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Url";
            // 
            // gobutton
            // 
            this.gobutton.Location = new System.Drawing.Point(360, 35);
            this.gobutton.Name = "gobutton";
            this.gobutton.Size = new System.Drawing.Size(53, 23);
            this.gobutton.TabIndex = 4;
            this.gobutton.Text = "Go";
            this.gobutton.UseVisualStyleBackColor = true;
            // 
            // mopc
            // 
            this.mopc.Location = new System.Drawing.Point(55, 64);
            this.mopc.Maximum = 99;
            this.mopc.Name = "mopc";
            this.mopc.Size = new System.Drawing.Size(358, 45);
            this.mopc.SmallChange = 5;
            this.mopc.TabIndex = 5;
            this.mopc.Value = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "透明度";
            // 
            // topmost
            // 
            this.topmost.AutoSize = true;
            this.topmost.Location = new System.Drawing.Point(11, 103);
            this.topmost.Name = "topmost";
            this.topmost.Size = new System.Drawing.Size(51, 21);
            this.topmost.TabIndex = 7;
            this.topmost.Text = "置顶";
            this.topmost.UseVisualStyleBackColor = true;
            // 
            // clickthrough
            // 
            this.clickthrough.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clickthrough.AutoSize = true;
            this.clickthrough.Location = new System.Drawing.Point(95, 103);
            this.clickthrough.Name = "clickthrough";
            this.clickthrough.Size = new System.Drawing.Size(75, 21);
            this.clickthrough.TabIndex = 8;
            this.clickthrough.Text = "鼠标穿透";
            this.clickthrough.UseVisualStyleBackColor = true;
            // 
            // ConfCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 128);
            this.Controls.Add(this.clickthrough);
            this.Controls.Add(this.topmost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mopc);
            this.Controls.Add(this.gobutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urlbox);
            this.Controls.Add(this.uuidb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfCardForm";
            this.Text = "卡片设置 - WebCard";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfCardForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mopc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox uuidb;
        public TextBox urlbox;
        public Button gobutton;
        public TrackBar mopc;
        public CheckBox topmost;
        public CheckBox clickthrough;
    }
}