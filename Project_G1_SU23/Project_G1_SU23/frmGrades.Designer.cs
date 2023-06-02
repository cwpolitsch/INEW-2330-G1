namespace Project_G1_SU23
{
    partial class frmGrades
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
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.lblSelectedStudent = new System.Windows.Forms.Label();
            this.cbxSelectedStudent = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.mnuGrades = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAttendance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemLogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemMidterm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemFinal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGrades = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.mnuGrades.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClassID
            // 
            this.lblClassID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClassID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClassID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClassID.Location = new System.Drawing.Point(114, 66);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(65, 26);
            this.lblClassID.TabIndex = 176;
            this.lblClassID.Text = "Class ID";
            this.lblClassID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedClass
            // 
            this.lblSelectedClass.AutoSize = true;
            this.lblSelectedClass.Location = new System.Drawing.Point(12, 73);
            this.lblSelectedClass.Name = "lblSelectedClass";
            this.lblSelectedClass.Size = new System.Drawing.Size(77, 13);
            this.lblSelectedClass.TabIndex = 175;
            this.lblSelectedClass.Text = "Selected Class";
            // 
            // dgvGrades
            // 
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(243, 66);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.Size = new System.Drawing.Size(392, 419);
            this.dgvGrades.TabIndex = 181;
            // 
            // lblSelectedStudent
            // 
            this.lblSelectedStudent.AutoSize = true;
            this.lblSelectedStudent.Location = new System.Drawing.Point(12, 110);
            this.lblSelectedStudent.Name = "lblSelectedStudent";
            this.lblSelectedStudent.Size = new System.Drawing.Size(89, 13);
            this.lblSelectedStudent.TabIndex = 182;
            this.lblSelectedStudent.Text = "Selected Student";
            // 
            // cbxSelectedStudent
            // 
            this.cbxSelectedStudent.FormattingEnabled = true;
            this.cbxSelectedStudent.Location = new System.Drawing.Point(107, 107);
            this.cbxSelectedStudent.Name = "cbxSelectedStudent";
            this.cbxSelectedStudent.Size = new System.Drawing.Size(106, 21);
            this.cbxSelectedStudent.TabIndex = 183;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 259);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 43);
            this.btnAdd.TabIndex = 184;
            this.btnAdd.Text = "Add Grade";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(132, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 43);
            this.btnDelete.TabIndex = 185;
            this.btnDelete.Text = "Delete Grade";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(26, 327);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 43);
            this.btnEdit.TabIndex = 186;
            this.btnEdit.Text = "Edit Grade";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(132, 327);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 43);
            this.btnCalculate.TabIndex = 187;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(26, 439);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 43);
            this.button5.TabIndex = 188;
            this.button5.Text = "Return to Menu";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // mnuGrades
            // 
            this.mnuGrades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuReport,
            this.mnuHelp});
            this.mnuGrades.Location = new System.Drawing.Point(0, 0);
            this.mnuGrades.Name = "mnuGrades";
            this.mnuGrades.Size = new System.Drawing.Size(647, 24);
            this.mnuGrades.TabIndex = 189;
            this.mnuGrades.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAttendance,
            this.mnuItemReturn,
            this.mnuItemLogOff,
            this.mnuItemExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuItemAttendance
            // 
            this.mnuItemAttendance.Name = "mnuItemAttendance";
            this.mnuItemAttendance.Size = new System.Drawing.Size(180, 22);
            this.mnuItemAttendance.Text = "Attendance";
            // 
            // mnuItemReturn
            // 
            this.mnuItemReturn.Name = "mnuItemReturn";
            this.mnuItemReturn.Size = new System.Drawing.Size(180, 22);
            this.mnuItemReturn.Text = "Return to Menu";
            // 
            // mnuItemLogOff
            // 
            this.mnuItemLogOff.Name = "mnuItemLogOff";
            this.mnuItemLogOff.Size = new System.Drawing.Size(180, 22);
            this.mnuItemLogOff.Text = "Log Off";
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(180, 22);
            this.mnuItemExit.Text = "Exit";
            // 
            // mnuReport
            // 
            this.mnuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemMidterm,
            this.mnuItemFinal});
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(54, 20);
            this.mnuReport.Text = "Report";
            // 
            // mnuItemMidterm
            // 
            this.mnuItemMidterm.Name = "mnuItemMidterm";
            this.mnuItemMidterm.Size = new System.Drawing.Size(180, 22);
            this.mnuItemMidterm.Text = "Midterm Print";
            // 
            // mnuItemFinal
            // 
            this.mnuItemFinal.Name = "mnuItemFinal";
            this.mnuItemFinal.Size = new System.Drawing.Size(180, 22);
            this.mnuItemFinal.Text = "Final Print";
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
            this.mnuItemAbout.Text = "About ";
            // 
            // mnuItemHelp
            // 
            this.mnuItemHelp.Name = "mnuItemHelp";
            this.mnuItemHelp.Size = new System.Drawing.Size(180, 22);
            this.mnuItemHelp.Text = "Help";
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrades.Location = new System.Drawing.Point(250, 24);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(74, 24);
            this.lblGrades.TabIndex = 190;
            this.lblGrades.Text = "Grades";
            // 
            // frmGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 508);
            this.Controls.Add(this.lblGrades);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxSelectedStudent);
            this.Controls.Add(this.lblSelectedStudent);
            this.Controls.Add(this.dgvGrades);
            this.Controls.Add(this.lblClassID);
            this.Controls.Add(this.lblSelectedClass);
            this.Controls.Add(this.mnuGrades);
            this.MainMenuStrip = this.mnuGrades;
            this.Name = "frmGrades";
            this.Text = "Grades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.mnuGrades.ResumeLayout(false);
            this.mnuGrades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblSelectedClass;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.Label lblSelectedStudent;
        private System.Windows.Forms.ComboBox cbxSelectedStudent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip mnuGrades;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAttendance;
        private System.Windows.Forms.ToolStripMenuItem mnuItemReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuItemLogOff;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuItemMidterm;
        private System.Windows.Forms.ToolStripMenuItem mnuItemFinal;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHelp;
        private System.Windows.Forms.Label lblGrades;
    }
}