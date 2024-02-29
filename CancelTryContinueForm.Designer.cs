namespace Beauty
{
    partial class CancelTryContinueForm
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
            btncontinue = new Button();
            btnCancel = new Button();
            btnTry = new Button();
            SuspendLayout();
            // 
            // btncontinue
            // 
            btncontinue.Location = new Point(225, 7);
            btncontinue.Name = "btncontinue";
            btncontinue.Size = new Size(102, 39);
            btncontinue.TabIndex = 5;
            btncontinue.Text = "Continue";
            btncontinue.UseVisualStyleBackColor = true;
            btncontinue.Click += btncontinue_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(8, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 39);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnTry
            // 
            btnTry.Location = new Point(115, 7);
            btnTry.Name = "btnTry";
            btnTry.Size = new Size(102, 39);
            btnTry.TabIndex = 6;
            btnTry.Text = "Try";
            btnTry.UseVisualStyleBackColor = true;
            btnTry.Click += btnTry_Click;
            // 
            // CancelTryContinueForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 53);
            Controls.Add(btnTry);
            Controls.Add(btncontinue);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CancelTryContinueForm";
            Text = "CancelTryContinueForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btncontinue;
        private Button btnCancel;
        private Button btnTry;
    }
}