namespace WinFormsApp7
{
    partial class Form2
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
            txtWord = new TextBox();
            btnSaveWord = new Button();
            btnCancel = new Button();
            txtMeaning = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtWord
            // 
            txtWord.BackColor = SystemColors.InactiveCaption;
            txtWord.Font = new Font("Impact", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            txtWord.Location = new Point(149, 68);
            txtWord.Multiline = true;
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(457, 54);
            txtWord.TabIndex = 1;
            txtWord.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSaveWord
            // 
            btnSaveWord.BackColor = SystemColors.AppWorkspace;
            btnSaveWord.Font = new Font("Impact", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSaveWord.ForeColor = SystemColors.Desktop;
            btnSaveWord.Location = new Point(52, 387);
            btnSaveWord.Name = "btnSaveWord";
            btnSaveWord.Size = new Size(235, 54);
            btnSaveWord.TabIndex = 2;
            btnSaveWord.Text = "SAVE";
            btnSaveWord.UseVisualStyleBackColor = false;
            btnSaveWord.Click += btnSaveWord_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.AppWorkspace;
            btnCancel.Font = new Font("Impact", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.Desktop;
            btnCancel.Location = new Point(451, 387);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(235, 54);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancelWord_Click;
            // 
            // txtMeaning
            // 
            txtMeaning.BackColor = SystemColors.InactiveCaption;
            txtMeaning.Font = new Font("Impact", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            txtMeaning.Location = new Point(149, 201);
            txtMeaning.Multiline = true;
            txtMeaning.Name = "txtMeaning";
            txtMeaning.Size = new Size(457, 54);
            txtMeaning.TabIndex = 4;
            txtMeaning.TextAlign = HorizontalAlignment.Center;
            txtMeaning.Click += btnSaveWord_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 32);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "WORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 173);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 6;
            label2.Text = "MEANING";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(746, 515);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMeaning);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveWord);
            Controls.Add(txtWord);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        public TextBox txtWord;
        public TextBox txtMeaning;
        public Button btnSaveWord;
        public Button btnCancel;
    }
}