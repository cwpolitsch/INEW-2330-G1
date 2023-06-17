namespace Project_G1_SU23
{
    partial class frmStudentAssign
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
            this.dgvStudentAssign = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudentAssignTwo = new System.Windows.Forms.DataGridView();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.tbxStudent = new System.Windows.Forms.TextBox();
            this.tbxClassID = new System.Windows.Forms.TextBox();
            this.btnAssignStudent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentAssign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentAssignTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentAssign
            // 
            this.dgvStudentAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentAssign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FirstName,
            this.LastName});
            this.dgvStudentAssign.Location = new System.Drawing.Point(12, 32);
            this.dgvStudentAssign.Name = "dgvStudentAssign";
            this.dgvStudentAssign.Size = new System.Drawing.Size(344, 280);
            this.dgvStudentAssign.TabIndex = 0;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.Name = "StudentID";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // dgvStudentAssignTwo
            // 
            this.dgvStudentAssignTwo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentAssignTwo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassID,
            this.ClassName});
            this.dgvStudentAssignTwo.Location = new System.Drawing.Point(12, 318);
            this.dgvStudentAssignTwo.Name = "dgvStudentAssignTwo";
            this.dgvStudentAssignTwo.Size = new System.Drawing.Size(344, 251);
            this.dgvStudentAssignTwo.TabIndex = 1;
            // 
            // ClassID
            // 
            this.ClassID.HeaderText = "ClassID";
            this.ClassID.Name = "ClassID";
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "Class Name";
            this.ClassName.Name = "ClassName";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(457, 97);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(61, 13);
            this.lblStudentID.TabIndex = 2;
            this.lblStudentID.Text = "StudentID: ";
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Location = new System.Drawing.Point(469, 149);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(49, 13);
            this.lblClassID.TabIndex = 3;
            this.lblClassID.Text = "ClassID: ";
            // 
            // tbxStudent
            // 
            this.tbxStudent.Location = new System.Drawing.Point(524, 94);
            this.tbxStudent.Name = "tbxStudent";
            this.tbxStudent.Size = new System.Drawing.Size(146, 20);
            this.tbxStudent.TabIndex = 4;
            // 
            // tbxClassID
            // 
            this.tbxClassID.Location = new System.Drawing.Point(524, 146);
            this.tbxClassID.Name = "tbxClassID";
            this.tbxClassID.Size = new System.Drawing.Size(146, 20);
            this.tbxClassID.TabIndex = 5;
            // 
            // btnAssignStudent
            // 
            this.btnAssignStudent.Location = new System.Drawing.Point(472, 188);
            this.btnAssignStudent.Name = "btnAssignStudent";
            this.btnAssignStudent.Size = new System.Drawing.Size(108, 44);
            this.btnAssignStudent.TabIndex = 6;
            this.btnAssignStudent.Text = "Assign Student";
            this.btnAssignStudent.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmStudentAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAssignStudent);
            this.Controls.Add(this.tbxClassID);
            this.Controls.Add(this.tbxStudent);
            this.Controls.Add(this.lblClassID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.dgvStudentAssignTwo);
            this.Controls.Add(this.dgvStudentAssign);
            this.Name = "frmStudentAssign";
            this.Text = "Assign Student";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentAssign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentAssignTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentAssign;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridView dgvStudentAssignTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.TextBox tbxStudent;
        private System.Windows.Forms.TextBox tbxClassID;
        private System.Windows.Forms.Button btnAssignStudent;
        private System.Windows.Forms.Button button1;
    }
}