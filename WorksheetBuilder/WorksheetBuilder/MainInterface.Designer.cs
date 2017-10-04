namespace WorksheetBuilder
{
    partial class MainInterface
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
            this.QuestionGridView = new System.Windows.Forms.DataGridView();
            this.question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.options = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddTestData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionGridView
            // 
            this.QuestionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuestionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.question,
            this.type,
            this.level,
            this.options,
            this.photo});
            this.QuestionGridView.Location = new System.Drawing.Point(12, 12);
            this.QuestionGridView.Name = "QuestionGridView";
            this.QuestionGridView.Size = new System.Drawing.Size(967, 466);
            this.QuestionGridView.TabIndex = 0;
            // 
            // question
            // 
            this.question.HeaderText = "Question";
            this.question.Name = "question";
            this.question.Width = 300;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            // 
            // level
            // 
            this.level.HeaderText = "Level";
            this.level.Name = "level";
            this.level.Width = 50;
            // 
            // options
            // 
            this.options.HeaderText = "Options";
            this.options.Name = "options";
            this.options.Width = 400;
            // 
            // photo
            // 
            this.photo.HeaderText = "Photo";
            this.photo.Name = "photo";
            this.photo.Width = 50;
            // 
            // AddTestData
            // 
            this.AddTestData.Location = new System.Drawing.Point(76, 485);
            this.AddTestData.Name = "AddTestData";
            this.AddTestData.Size = new System.Drawing.Size(75, 23);
            this.AddTestData.TabIndex = 1;
            this.AddTestData.Text = "Add Test Data";
            this.AddTestData.UseVisualStyleBackColor = true;
            this.AddTestData.Click += new System.EventHandler(this.AddTestData_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 526);
            this.Controls.Add(this.AddTestData);
            this.Controls.Add(this.QuestionGridView);
            this.Name = "MainInterface";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.QuestionGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView QuestionGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn question;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn options;
        private System.Windows.Forms.DataGridViewTextBoxColumn photo;
        private System.Windows.Forms.Button AddTestData;
    }
}

