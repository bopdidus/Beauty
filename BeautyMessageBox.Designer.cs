namespace Beauty
{
    partial class BeautyMessageBox
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
            paneltheme = new Panel();
            panel2 = new Panel();
            lbTitle = new Label();
            lbClose = new Label();
            panelfooter = new Panel();
            panelIcon = new Panel();
            lbIcon = new Label();
            lbMessage = new Label();
            panel2.SuspendLayout();
            panelIcon.SuspendLayout();
            SuspendLayout();
            // 
            // paneltheme
            // 
            paneltheme.BackColor = Color.Orange;
            paneltheme.Dock = DockStyle.Left;
            paneltheme.Location = new Point(0, 0);
            paneltheme.Name = "paneltheme";
            paneltheme.Size = new Size(22, 199);
            paneltheme.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbTitle);
            panel2.Controls.Add(lbClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(22, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 30);
            panel2.TabIndex = 1;
            // 
            // lbTitle
            // 
            lbTitle.Dock = DockStyle.Fill;
            lbTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTitle.Location = new Point(0, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(385, 30);
            lbTitle.TabIndex = 4;
            lbTitle.Text = "label1";
            lbTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbClose
            // 
            lbClose.AutoSize = true;
            lbClose.Dock = DockStyle.Right;
            lbClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbClose.Location = new Point(385, 0);
            lbClose.Name = "lbClose";
            lbClose.Size = new Size(21, 23);
            lbClose.TabIndex = 3;
            lbClose.Text = "X";
            lbClose.Click += lbClose_Click;
            // 
            // panelfooter
            // 
            panelfooter.Dock = DockStyle.Bottom;
            panelfooter.Location = new Point(22, 144);
            panelfooter.Name = "panelfooter";
            panelfooter.Size = new Size(406, 55);
            panelfooter.TabIndex = 2;
            // 
            // panelIcon
            // 
            panelIcon.Controls.Add(lbIcon);
            panelIcon.Dock = DockStyle.Left;
            panelIcon.Location = new Point(22, 30);
            panelIcon.Name = "panelIcon";
            panelIcon.Size = new Size(103, 114);
            panelIcon.TabIndex = 3;
            // 
            // lbIcon
            // 
            lbIcon.Dock = DockStyle.Fill;
            lbIcon.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lbIcon.Location = new Point(0, 0);
            lbIcon.Name = "lbIcon";
            lbIcon.Size = new Size(103, 114);
            lbIcon.TabIndex = 4;
            // 
            // lbMessage
            // 
            lbMessage.Dock = DockStyle.Fill;
            lbMessage.Location = new Point(125, 30);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(303, 114);
            lbMessage.TabIndex = 4;
            lbMessage.Text = "label1";
            lbMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BeautyMessageBox
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 199);
            Controls.Add(lbMessage);
            Controls.Add(panelIcon);
            Controls.Add(panelfooter);
            Controls.Add(panel2);
            Controls.Add(paneltheme);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BeautyMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelIcon.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel paneltheme;
        private Panel panel2;
        private Label lbClose;
        private Panel panelfooter;
        private Panel panelIcon;
        private Label lbIcon;
        private Label lbTitle;
        private Label lbMessage;
    }
}