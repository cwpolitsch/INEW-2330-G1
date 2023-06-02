namespace Project_G1_SU23
{
    partial class frmTeacher
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
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.mnuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemLogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemSeating = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAttendance = new System.Windows.Forms.MenuStrip();
            this.lblSelectedClass = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.mnuAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasses.Location = new System.Drawing.Point(615, 49);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(86, 26);
            this.lblClasses.TabIndex = 190;
            this.lblClasses.Text = "Classes";
            // 
            // btnGrades
            // 
            this.btnGrades.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrades.Location = new System.Drawing.Point(25, 434);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(176, 56);
            this.btnGrades.TabIndex = 188;
            this.btnGrades.Text = "Grades";
            this.btnGrades.UseVisualStyleBackColor = true;
            // 
            // btnAttendance
            // 
            this.btnAttendance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Location = new System.Drawing.Point(25, 347);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(176, 56);
            this.btnAttendance.TabIndex = 187;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(145, 22);
            this.mnuItemExit.Text = "Exit";
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(243, 90);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.Size = new System.Drawing.Size(826, 419);
            this.dgvTeachers.TabIndex = 189;
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
            this.mnuItemLogOff.Size = new System.Drawing.Size(145, 22);
            this.mnuItemLogOff.Text = "Log Off";
            // 
            // mnuItemEdit
            // 
            this.mnuItemEdit.Name = "mnuItemEdit";
            this.mnuItemEdit.Size = new System.Drawing.Size(145, 22);
            this.mnuItemEdit.Text = "Edit";
            // 
            // mnuItemSeating
            // 
            this.mnuItemSeating.Name = "mnuItemSeating";
            this.mnuItemSeating.Size = new System.Drawing.Size(145, 22);
            this.mnuItemSeating.Text = "Seating Chart";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemSeating,
            this.mnuItemEdit,
            this.mnuItemLogOff,
            this.mnuItemExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
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
            this.mnuAttendance.Size = new System.Drawing.Size(1081, 24);
            this.mnuAttendance.TabIndex = 184;
            this.mnuAttendance.Text = "menuStrip1";
            // 
            // lblSelectedClass
            // 
            this.lblSelectedClass.AutoSize = true;
            this.lblSelectedClass.Location = new System.Drawing.Point(22, 59);
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
            this.lblClassID.Location = new System.Drawing.Point(124, 52);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(65, 26);
            this.lblClassID.TabIndex = 183;
            this.lblClassID.Text = "Class ID";
            this.lblClassID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 521);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.mnuAttendance);
            this.Controls.Add(this.lblSelectedClass);
            this.Controls.Add(this.lblClassID);
            this.Name = "frmTeacher";
            this.Text = "Teacher Main";
            this.Load += new System.EventHandler(this.frmTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.mnuAttendance.ResumeLayout(false);
            this.mnuAttendance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuItemLogOff;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSeating;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.MenuStrip mnuAttendance;
        private System.Windows.Forms.Label lblSelectedClass;
        private System.Windows.Forms.Label lblClassID;
    }
}