namespace WinFormsApp7
{
    partial class Form1
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvDictionary = new DataGridView();
            btnAdd = new Button();
            btnLoad = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            colName = new DataGridViewTextBoxColumn();
            colMeaning = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDictionary).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.InactiveCaption;
            txtSearch.Font = new Font("Impact", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            txtSearch.Location = new Point(21, 26);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(457, 54);
            txtSearch.TabIndex = 0;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.AppWorkspace;
            btnSearch.Font = new Font("Impact", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.Desktop;
            btnSearch.Location = new Point(516, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(235, 54);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvDictionary
            // 
            dgvDictionary.BackgroundColor = SystemColors.InactiveCaption;
            dgvDictionary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDictionary.Columns.AddRange(new DataGridViewColumn[] { colName, colMeaning });
            dgvDictionary.Location = new Point(21, 114);
            dgvDictionary.Name = "dgvDictionary";
            dgvDictionary.Size = new Size(730, 204);
            dgvDictionary.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.AppWorkspace;
            btnAdd.Location = new Point(21, 346);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 156);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.AppWorkspace;
            btnLoad.Location = new Point(626, 346);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(125, 156);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "LOAD";
            btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.AppWorkspace;
            btnSave.Location = new Point(477, 346);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 156);
            btnSave.TabIndex = 5;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.AppWorkspace;
            btnDelete.Location = new Point(328, 346);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 156);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.AppWorkspace;
            btnEdit.Location = new Point(172, 346);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 156);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // colName
            // 
            colName.HeaderText = "Слово";
            colName.Name = "colName";
            // 
            // colMeaning
            // 
            colMeaning.HeaderText = "Значення";
            colMeaning.Name = "colMeaning";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(776, 514);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(btnAdd);
            Controls.Add(dgvDictionary);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDictionary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        public Button btnAdd;
        public Button btnLoad;
        public Button btnSave;
        public Button btnDelete;
        public Button btnEdit;
        private DataGridView dgvDictionary;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colMeaning;
    }
}
