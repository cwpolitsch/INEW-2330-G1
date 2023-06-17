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
            this.lblClassID.Location = new System.Drawing.Point(152, 81);
            this.lblClassID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(86, 32);
            this.lblClassID.TabIndex = 176;
            this.lblClassID.Text = "Class ID";
            this.lblClassID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedClass
            // 
            this.lblSelectedClass.AutoSize = true;
            this.lblSelectedClass.Location = new System.Drawing.Point(16, 90);
            this.lblSelectedClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedClass.Name = "lblSelectedClass";
            this.lblSelectedClass.Size = new System.Drawing.Size(101, 17);
            this.lblSelectedClass.TabIndex = 175;
            this.lblSelectedClass.Text = "Selected Class";
            // 
            // dgvGrades
            // 
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(324, 81);
            this.dgvGrades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.RowHeadersWidth = 51;
            this.dgvGrades.Size = new System.Drawing.Size(523, 516);
            this.dgvGrades.TabIndex = 181;
            // 
            // lblSelectedStudent
            // 
            this.lblSelectedStudent.AutoSize = true;
            this.lblSelectedStudent.Location = new System.Drawing.Point(16, 135);
            this.lblSelectedStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedStudent.Name = "lblSelectedStudent";
            this.lblSelectedStudent.Size = new System.Drawing.Size(116, 17);
            this.lblSelectedStudent.TabIndex = 182;
            this.lblSelectedStudent.Text = "Selected Student";
            // 
            // cbxSelectedStudent
            // 
            this.cbxSelectedStudent.FormattingEnabled = true;
            this.cbxSelectedStudent.Location = new System.Drawing.Point(143, 132);
            this.cbxSelectedStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxSelectedStudent.Name = "cbxSelectedStudent";
            this.cbxSelectedStudent.Size = new System.Drawing.Size(140, 24);
            this.cbxSelectedStudent.TabIndex = 183;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 319);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 53);
            this.btnAdd.TabIndex = 184;
            this.btnAdd.Text = "Add Grade";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(176, 319);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 53);
            this.btnDelete.TabIndex = 185;
            this.btnDelete.Text = "Delete Grade";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(35, 402);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 53);
            this.btnEdit.TabIndex = 186;
            this.btnEdit.Text = "Edit Grade";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(176, 402);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 53);
            this.btnCalculate.TabIndex = 187;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(35, 540);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(241, 53);
            this.button5.TabIndex = 188;
            this.button5.Text = "Return to Menu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // mnuGrades
            // 
            this.mnuGrades.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuGrades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuReport,
            this.mnuHelp});
            this.mnuGrades.Location = new System.Drawing.Point(0, 0);
            this.mnuGrades.Name = "mnuGrades";
            this.mnuGrades.Size = new System.Drawing.Size(863, 28);
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
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuItemAttendance
            // 
            this.mnuItemAttendance.Name = "mnuItemAttendance";
            this.mnuItemAttendance.Size = new System.Drawing.Size(224, 26);
            this.mnuItemAttendance.Text = "Attendance";
            this.mnuItemAttendance.Click += new System.EventHandler(this.mnuItemAttendance_Click);
            // 
            // mnuItemReturn
            // 
            this.mnuItemReturn.Name = "mnuItemReturn";
            this.mnuItemReturn.Size = new System.Drawing.Size(224, 26);
            this.mnuItemReturn.Text = "Return to Menu";
            this.mnuItemReturn.Click += new System.EventHandler(this.mnuItemReturn_Click);
            // 
            // mnuItemLogOff
            // 
            this.mnuItemLogOff.Name = "mnuItemLogOff";
            this.mnuItemLogOff.Size = new System.Drawing.Size(224, 26);
            this.mnuItemLogOff.Text = "Log Off";
            this.mnuItemLogOff.Click += new System.EventHandler(this.mnuItemLogOff_Click);
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(224, 26);
            this.mnuItemExit.Text = "Exit";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemMidterm,
            this.mnuItemFinal});
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(68, 24);
            this.mnuReport.Text = "Report";
            // 
            // mnuItemMidterm
            // 
            this.mnuItemMidterm.Name = "mnuItemMidterm";
            this.mnuItemMidterm.Size = new System.Drawing.Size(183, 26);
            this.mnuItemMidterm.Text = "Midterm Print";
            // 
            // mnuItemFinal
            // 
            this.mnuItemFinal.Name = "mnuItemFinal";
            this.mnuItemFinal.Size = new System.Drawing.Size(183, 26);
            this.mnuItemFinal.Text = "Final Print";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAbout,
            this.mnuItemHelp});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(55, 24);
            this.mnuHelp.Text = "Help";
            // 
            // mnuItemAbout
            // 
            this.mnuItemAbout.Name = "mnuItemAbout";
            this.mnuItemAbout.Size = new System.Drawing.Size(137, 26);
            this.mnuItemAbout.Text = "About ";
            // 
            // mnuItemHelp
            // 
            this.mnuItemHelp.Name = "mnuItemHelp";
            this.mnuItemHelp.Size = new System.Drawing.Size(137, 26);
            this.mnuItemHelp.Text = "Help";
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrades.Location = new System.Drawing.Point(333, 30);
            this.lblGrades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(99, 31);
            this.lblGrades.TabIndex = 190;
            this.lblGrades.Text = "Grades";
            // 
            // frmGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 625);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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