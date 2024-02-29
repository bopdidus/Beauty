namespace Beauty
{
    partial class YesNoForm
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
            btnNo = new Button();
            btnYes = new Button();
            SuspendLayout();
            // 
            // btnNo
            // 
            btnNo.Location = new Point(13, 7);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(102, 39);
            btnNo.TabIndex = 0;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // btnYes
            // 
            btnYes.Location = new Point(211, 7);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(102, 39);
            btnYes.TabIndex = 1;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // YesNoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 53);
            Controls.Add(btnYes);
            Controls.Add(btnNo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "YesNoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "YesNoForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNo;
        private Button btnYes;
    }
}