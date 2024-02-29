namespace Beauty
{
    partial class OkForm
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
            btnOk = new Button();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(115, 7);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(102, 39);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // OkForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 53);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OkForm";
            Text = "OkForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOk;
    }
}