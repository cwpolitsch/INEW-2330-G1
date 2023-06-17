namespace Project_G1_SU23
{
    partial class frmAdmin
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
            this.lblClasses = new System.Windows.Forms.Label();
            this.btnClasses = new System.Windows.Forms.Button();
            this.btnEditTeachers = new System.Windows.Forms.Button();
            this.btnEditStudents = new System.Windows.Forms.Button();
            this.mnuItemsTeachers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemsStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDepartmentHead = new System.Windows.Forms.DataGridView();
            this.mnuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemLogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitemGrades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAttendance = new System.Windows.Forms.MenuStrip();
            this.lblSelectedClass = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentHead)).BeginInit();
            this.mnuAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasses.Location = new System.Drawing.Point(583, 55);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(86, 26);
            this.lblClasses.TabIndex = 190;
            this.lblClasses.Text = "Classes";
            // 
            // btnClasses
            // 
            this.btnClasses.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasses.Location = new System.Drawing.Point(48, 405);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Size = new System.Drawing.Size(176, 56);
            this.btnClasses.TabIndex = 187;
            this.btnClasses.Text = "Classes";
            this.btnClasses.UseVisualStyleBackColor = true;
            this.btnClasses.Click += new System.EventHandler(this.btnClasses_Click);
            // 
            // btnEditTeachers
            // 
            this.btnEditTeachers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTeachers.Location = new System.Drawing.Point(48, 318);
            this.btnEditTeachers.Name = "btnEditTeachers";
            this.btnEditTeachers.Size = new System.Drawing.Size(176, 56);
            this.btnEditTeachers.TabIndex = 186;
            this.btnEditTeachers.Text = "Edit Teachers";
            this.btnEditTeachers.UseVisualStyleBackColor = true;
            this.btnEditTeachers.Click += new System.EventHandler(this.btnEditTeachers_Click);
            // 
            // btnEditStudents
            // 
            this.btnEditStudents.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStudents.Location = new System.Drawing.Point(48, 241);
            this.btnEditStudents.Name = "btnEditStudents";
            this.btnEditStudents.Size = new System.Drawing.Size(176, 56);
            this.btnEditStudents.TabIndex = 185;
            this.btnEditStudents.Text = "Edit Students";
            this.btnEditStudents.UseVisualStyleBackColor = true;
            this.btnEditStudents.Click += new System.EventHandler(this.btnEditStudents_Click);
            // 
            // mnuItemsTeachers
            // 
            this.mnuItemsTeachers.Name = "mnuItemsTeachers";
            this.mnuItemsTeachers.Size = new System.Drawing.Size(180, 22);
            this.mnuItemsTeachers.Text = "Teachers";
            this.mnuItemsTeachers.Click += new System.EventHandler(this.mnuItemsTeachers_Click);
            // 
            // mnuItemsStudents
            // 
            this.mnuItemsStudents.Name = "mnuItemsStudents";
            this.mnuItemsStudents.Size = new System.Drawing.Size(180, 22);
            this.mnuItemsStudents.Text = "Students";
            this.mnuItemsStudents.Click += new System.EventHandler(this.mnuItemsStudents_Click);
            // 
            // mnuitemExit
            // 
            this.mnuitemExit.Name = "mnuitemExit";
            this.mnuitemExit.Size = new System.Drawing.Size(180, 22);
            this.mnuitemExit.Text = "Exit";
            this.mnuitemExit.Click += new System.EventHandler(this.mnuitemExit_Click);
            // 
            // dgvDepartmentHead
            // 
            this.dgvDepartmentHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmentHead.Location = new System.Drawing.Point(275, 88);
            this.dgvDepartmentHead.Name = "dgvDepartmentHead";
            this.dgvDepartmentHead.RowHeadersWidth = 51;
            this.dgvDepartmentHead.Size = new System.Drawing.Size(695, 433);
            this.dgvDepartmentHead.TabIndex = 189;
            // 
            // mnuItemHelp
            // 
            this.mnuItemHelp.Name = "mnuItemHelp";
            this.mnuItemHelp.Size = new System.Drawing.Size(107, 22);
            this.mnuItemHelp.Text = "Help";
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
            this.mnuItemAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuItemAbout.Text = "About";
            // 
            // mnuItemLogOff
            // 
            this.mnuItemLogOff.Name = "mnuItemLogOff";
            this.mnuItemLogOff.Size = new System.Drawing.Size(180, 22);
            this.mnuItemLogOff.Text = "Log Off";
            this.mnuItemLogOff.Click += new System.EventHandler(this.mnuItemLogOff_Click);
            // 
            // mnuItemEdit
            // 
            this.mnuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemsStudents,
            this.mnuItemsTeachers,
            this.classesToolStripMenuItem});
            this.mnuItemEdit.Name = "mnuItemEdit";
            this.mnuItemEdit.Size = new System.Drawing.Size(180, 22);
            this.mnuItemEdit.Text = "Edit";
            // 
            // mnuitemGrades
            // 
            this.mnuitemGrades.Name = "mnuitemGrades";
            this.mnuitemGrades.Size = new System.Drawing.Size(180, 22);
            this.mnuitemGrades.Text = "Grades";
            this.mnuitemGrades.Click += new System.EventHandler(this.mnuitemGrades_Click);
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
            // mnuAttendance
            // 
            this.mnuAttendance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnuAttendance.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAttendance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.mnuAttendance.Location = new System.Drawing.Point(0, 0);
            this.mnuAttendance.Name = "mnuAttendance";
            this.mnuAttendance.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuAttendance.Size = new System.Drawing.Size(981, 24);
            this.mnuAttendance.TabIndex = 184;
            this.mnuAttendance.Text = "menuStrip1";
            // 
            // lblSelectedClass
            // 
            this.lblSelectedClass.AutoSize = true;
            this.lblSelectedClass.Location = new System.Drawing.Point(33, 65);
            this.lblSelectedClass.Name = "lblSelectedClass";
            this.lblSelectedClass.Size = new System.Drawing.Size(77, 13);
            this.lblSelectedClass.TabIndex = 182;
            this.lblSelectedClass.Text = "Selected Class";
            // 
            // lblClassID
            // 
            this.lblClassID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClassID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClassID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClassID.Location = new System.Drawing.Point(135, 58);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(65, 26);
            this.lblClassID.TabIndex = 183;
            this.lblClassID.Text = "Class ID";
            this.lblClassID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.classesToolStripMenuItem.Text = "Classes";
            this.classesToolStripMenuItem.Click += new System.EventHandler(this.classesToolStripMenuItem_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 525);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.btnClasses);
            this.Controls.Add(this.btnEditTeachers);
            this.Controls.Add(this.btnEditStudents);
            this.Controls.Add(this.dgvDepartmentHead);
            this.Controls.Add(this.mnuAttendance);
            this.Controls.Add(this.lblSelectedClass);
            this.Controls.Add(this.lblClassID);
            this.Name = "frmAdmin";
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentHead)).EndInit();
            this.mnuAttendance.ResumeLayout(false);
            this.mnuAttendance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.Button btnClasses;
        private System.Windows.Forms.Button btnEditTeachers;
        private System.Windows.Forms.Button btnEditStudents;
        private System.Windows.Forms.ToolStripMenuItem mnuItemsTeachers;
        private System.Windows.Forms.ToolStripMenuItem mnuItemsStudents;
        private System.Windows.Forms.ToolStripMenuItem mnuitemExit;
        private System.Windows.Forms.DataGridView dgvDepartmentHead;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuItemLogOff;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuitemGrades;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.MenuStrip mnuAttendance;
        private System.Windows.Forms.Label lblSelectedClass;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
    }
}