namespace Project_G1_SU23
{
    partial class frmDepartmentHead
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
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblSelectedClass = new System.Windows.Forms.Label();
            this.mnuAttendance = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitemGrades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemsStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemsTeachers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemLogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditStudents = new System.Windows.Forms.Button();
            this.btnEditTeachers = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvDepartmentHead = new System.Windows.Forms.DataGridView();
            this.lblClasses = new System.Windows.Forms.Label();
            this.mnuAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentHead)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClassID
            // 
            this.lblClassID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClassID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClassID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClassID.Location = new System.Drawing.Point(124, 46);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(65, 26);
            this.lblClassID.TabIndex = 174;
            this.lblClassID.Text = "Class ID";
            this.lblClassID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedClass
            // 
            this.lblSelectedClass.AutoSize = true;
            this.lblSelectedClass.Location = new System.Drawing.Point(22, 53);
            this.lblSelectedClass.Name = "lblSelectedClass";
            this.lblSelectedClass.Size = new System.Drawing.Size(77, 13);
            this.lblSelectedClass.TabIndex = 173;
            this.lblSelectedClass.Text = "Selected Class";
            // 
            // mnuAttendance
            // 
            this.mnuAttendance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuAttendance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.mnuAttendance.Location = new System.Drawing.Point(0, 0);
            this.mnuAttendance.Name = "mnuAttendance";
            this.mnuAttendance.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuAttendance.Size = new System.Drawing.Size(957, 24);
            this.mnuAttendance.TabIndex = 175;
            this.mnuAttendance.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuitemGrades,
            this.mnuItemEdit,
            this.mnuItemLogOff,
            this.mnuitemExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuitemGrades
            // 
            this.mnuitemGrades.Name = "mnuitemGrades";
            this.mnuitemGrades.Size = new System.Drawing.Size(180, 22);
            this.mnuitemGrades.Text = "Grades";
            this.mnuitemGrades.Click += new System.EventHandler(this.mnuitemGrades_Click);
            // 
            // mnuItemEdit
            // 
            this.mnuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemsStudents,
            this.mnuItemsTeachers});
            this.mnuItemEdit.Name = "mnuItemEdit";
            this.mnuItemEdit.Size = new System.Drawing.Size(180, 22);
            this.mnuItemEdit.Text = "Edit";
            // 
            // mnuItemsStudents
            // 
            this.mnuItemsStudents.Name = "mnuItemsStudents";
            this.mnuItemsStudents.Size = new System.Drawing.Size(180, 22);
            this.mnuItemsStudents.Text = "Students";
            this.mnuItemsStudents.Click += new System.EventHandler(this.mnuItemsStudents_Click);
            // 
            // mnuItemsTeachers
            // 
            this.mnuItemsTeachers.Name = "mnuItemsTeachers";
            this.mnuItemsTeachers.Size = new System.Drawing.Size(180, 22);
            this.mnuItemsTeachers.Text = "Teachers";
            this.mnuItemsTeachers.Click += new System.EventHandler(this.mnuItemsTeachers_Click);
            // 
            // mnuItemLogOff
            // 
            this.mnuItemLogOff.Name = "mnuItemLogOff";
            this.mnuItemLogOff.Size = new System.Drawing.Size(180, 22);
            this.mnuItemLogOff.Text = "Log Off";
            this.mnuItemLogOff.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuitemExit
            // 
            this.mnuitemExit.Name = "mnuitemExit";
            this.mnuitemExit.Size = new System.Drawing.Size(180, 22);
            this.mnuitemExit.Text = "Exit";
            this.mnuitemExit.Click += new System.EventHandler(this.mnuitemExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAbout,
            this.mnuItemHelp});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuItemAbout
            // 
            this.mnuItemAbout.Name = "mnuItemAbout";
            this.mnuItemAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuItemAbout.Text = "About";
            // 
            // mnuItemHelp
            // 
            this.mnuItemHelp.Name = "mnuItemHelp";
            this.mnuItemHelp.Size = new System.Drawing.Size(180, 22);
            this.mnuItemHelp.Text = "Help";
            // 
            // btnEditStudents
            // 
            this.btnEditStudents.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStudents.Location = new System.Drawing.Point(25, 177);
            this.btnEditStudents.Name = "btnEditStudents";
            this.btnEditStudents.Size = new System.Drawing.Size(176, 56);
            this.btnEditStudents.TabIndex = 176;
            this.btnEditStudents.Text = "Edit Students";
            this.btnEditStudents.UseVisualStyleBackColor = true;
            this.btnEditStudents.Click += new System.EventHandler(this.btnEditStudents_Click);
            // 
            // btnEditTeachers
            // 
            this.btnEditTeachers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTeachers.Location = new System.Drawing.Point(25, 254);
            this.btnEditTeachers.Name = "btnEditTeachers";
            this.btnEditTeachers.Size = new System.Drawing.Size(176, 56);
            this.btnEditTeachers.TabIndex = 177;
            this.btnEditTeachers.Text = "Edit Teachers";
            this.btnEditTeachers.UseVisualStyleBackColor = true;
            this.btnEditTeachers.Click += new System.EventHandler(this.btnEditTeachers_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Location = new System.Drawing.Point(25, 341);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(176, 56);
            this.btnAttendance.TabIndex = 178;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(25, 428);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 56);
            this.button4.TabIndex = 179;
            this.button4.Text = "Grades";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvDepartmentHead
            // 
            this.dgvDepartmentHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmentHead.Location = new System.Drawing.Point(250, 76);
            this.dgvDepartmentHead.Name = "dgvDepartmentHead";
            this.dgvDepartmentHead.Size = new System.Drawing.Size(695, 433);
            this.dgvDepartmentHead.TabIndex = 180;
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasses.Location = new System.Drawing.Point(558, 43);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(86, 26);
            this.lblClasses.TabIndex = 181;
            this.lblClasses.Text = "Classes";
            // 
            // frmDepartmentHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 521);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.dgvDepartmentHead);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnEditTeachers);
            this.Controls.Add(this.btnEditStudents);
            this.Controls.Add(this.mnuAttendance);
            this.Controls.Add(this.lblClassID);
            this.Controls.Add(this.lblSelectedClass);
            this.Name = "frmDepartmentHead";
            this.Text = "Department Head Menu";
            this.mnuAttendance.ResumeLayout(false);
            this.mnuAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblSelectedClass;
        private System.Windows.Forms.MenuStrip mnuAttendance;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuitemGrades;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuItemLogOff;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuItemsStudents;
        private System.Windows.Forms.ToolStripMenuItem mnuItemsTeachers;
        private System.Windows.Forms.ToolStripMenuItem mnuitemExit;
        private System.Windows.Forms.Button btnEditStudents;
        private System.Windows.Forms.Button btnEditTeachers;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvDepartmentHead;
        private System.Windows.Forms.Label lblClasses;
    }
}