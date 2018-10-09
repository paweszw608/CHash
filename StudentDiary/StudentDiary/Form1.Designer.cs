namespace StudentDiary
{
    partial class mainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentButton = new System.Windows.Forms.Button();
            this.studentListView1 = new System.Windows.Forms.ListView();
            this.studentsColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentsColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // studentButton
            // 
            this.studentButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.studentButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentButton.Location = new System.Drawing.Point(23, 6);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(83, 33);
            this.studentButton.TabIndex = 2;
            this.studentButton.Text = "Students";
            this.studentButton.UseVisualStyleBackColor = false;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // studentListView1
            // 
            this.studentListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentsColumnHeader1,
            this.studentsColumnHeader2});
            this.studentListView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentListView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentListView1.GridLines = true;
            this.studentListView1.Location = new System.Drawing.Point(23, 45);
            this.studentListView1.Name = "studentListView1";
            this.studentListView1.Size = new System.Drawing.Size(176, 223);
            this.studentListView1.TabIndex = 3;
            this.studentListView1.UseCompatibleStateImageBehavior = false;
            this.studentListView1.View = System.Windows.Forms.View.Details;
            this.studentListView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // studentsColumnHeader1
            // 
            this.studentsColumnHeader1.Text = "Name";
            this.studentsColumnHeader1.Width = 70;
            // 
            // studentsColumnHeader2
            // 
            this.studentsColumnHeader2.Text = "Surname";
            this.studentsColumnHeader2.Width = 102;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(409, 359);
            this.Controls.Add(this.studentListView1);
            this.Controls.Add(this.studentButton);
            this.Name = "mainForm";
            this.Text = "Student Diary";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.ListView studentListView1;
        private System.Windows.Forms.ColumnHeader studentsColumnHeader1;
        private System.Windows.Forms.ColumnHeader studentsColumnHeader2;
    }
}

