namespace VanEppsProject4
{
    partial class frmCourses
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourses));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxCourse = new System.Windows.Forms.ComboBox();
            this.springBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesDataSet = new VanEppsProject4.CoursesDataSet();
            this.gbxType = new System.Windows.Forms.GroupBox();
            this.rdoHybrid = new System.Windows.Forms.RadioButton();
            this.rdoOnline = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calDate = new System.Windows.Forms.MonthCalendar();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLoad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDisplayCourse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDisplayType = new System.Windows.Forms.TextBox();
            this.txtDisplayCourse = new System.Windows.Forms.TextBox();
            this.txtDisplayDate = new System.Windows.Forms.TextBox();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtDisplayLoad = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this._2019SpringTableAdapter = new VanEppsProject4.CoursesDataSetTableAdapters._2019SpringTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.springBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            this.gbxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.ForeColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.cbxCourse);
            this.splitContainer1.Panel1.Controls.Add(this.gbxType);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.calDate);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddCourse);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtName);
            this.splitContainer1.Panel1.Controls.Add(this.txtLoad);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.btnDisplayCourse);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtDisplayType);
            this.splitContainer1.Panel2.Controls.Add(this.txtDisplayCourse);
            this.splitContainer1.Panel2.Controls.Add(this.txtDisplayDate);
            this.splitContainer1.Panel2.Controls.Add(this.txtDisplayName);
            this.splitContainer1.Panel2.Controls.Add(this.txtDisplayLoad);
            this.splitContainer1.Size = new System.Drawing.Size(843, 518);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.TabIndex = 23;
            this.splitContainer1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.GhostWhite;
            this.label12.Location = new System.Drawing.Point(16, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 22);
            this.label12.TabIndex = 35;
            this.label12.Text = "Course Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.GhostWhite;
            this.label10.Location = new System.Drawing.Point(111, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 39);
            this.label10.TabIndex = 24;
            this.label10.Text = "Add Course";
            // 
            // cbxCourse
            // 
            this.cbxCourse.BackColor = System.Drawing.Color.GhostWhite;
            this.cbxCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxCourse.DataSource = this.springBindingSource;
            this.cbxCourse.DisplayMember = "CourseNumber";
            this.cbxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCourse.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCourse.FormattingEnabled = true;
            this.cbxCourse.Location = new System.Drawing.Point(160, 343);
            this.cbxCourse.Name = "cbxCourse";
            this.cbxCourse.Size = new System.Drawing.Size(227, 28);
            this.cbxCourse.TabIndex = 3;
            this.cbxCourse.Tag = "Course Number";
            this.cbxCourse.ValueMember = "CourseID";
            // 
            // springBindingSource
            // 
            this.springBindingSource.DataMember = "2019Spring";
            this.springBindingSource.DataSource = this.coursesDataSet;
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "CoursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbxType
            // 
            this.gbxType.BackColor = System.Drawing.Color.Transparent;
            this.gbxType.Controls.Add(this.rdoHybrid);
            this.gbxType.Controls.Add(this.rdoOnline);
            this.gbxType.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxType.ForeColor = System.Drawing.Color.GhostWhite;
            this.gbxType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbxType.Location = new System.Drawing.Point(160, 375);
            this.gbxType.Margin = new System.Windows.Forms.Padding(0);
            this.gbxType.Name = "gbxType";
            this.gbxType.Padding = new System.Windows.Forms.Padding(0);
            this.gbxType.Size = new System.Drawing.Size(227, 47);
            this.gbxType.TabIndex = 4;
            this.gbxType.TabStop = false;
            this.gbxType.Tag = "Course Type";
            // 
            // rdoHybrid
            // 
            this.rdoHybrid.AutoSize = true;
            this.rdoHybrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoHybrid.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHybrid.Location = new System.Drawing.Point(19, 17);
            this.rdoHybrid.Name = "rdoHybrid";
            this.rdoHybrid.Size = new System.Drawing.Size(79, 24);
            this.rdoHybrid.TabIndex = 5;
            this.rdoHybrid.TabStop = true;
            this.rdoHybrid.Tag = "Course Type";
            this.rdoHybrid.Text = "Hybrid";
            this.rdoHybrid.UseVisualStyleBackColor = true;
            // 
            // rdoOnline
            // 
            this.rdoOnline.AutoSize = true;
            this.rdoOnline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOnline.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOnline.Location = new System.Drawing.Point(136, 17);
            this.rdoOnline.Name = "rdoOnline";
            this.rdoOnline.Size = new System.Drawing.Size(76, 24);
            this.rdoOnline.TabIndex = 6;
            this.rdoOnline.TabStop = true;
            this.rdoOnline.Tag = "Course Type";
            this.rdoOnline.Text = "Online";
            this.rdoOnline.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(16, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 34;
            this.label4.Text = "Course Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Course Load";
            // 
            // calDate
            // 
            this.calDate.BackColor = System.Drawing.Color.GhostWhite;
            this.calDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calDate.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calDate.Location = new System.Drawing.Point(160, 160);
            this.calDate.MaxDate = new System.DateTime(2019, 1, 31, 0, 0, 0, 0);
            this.calDate.MaxSelectionCount = 1;
            this.calDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.calDate.Name = "calDate";
            this.calDate.ShowToday = false;
            this.calDate.ShowTodayCircle = false;
            this.calDate.TabIndex = 2;
            this.calDate.Tag = "Start Date";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.BackgroundImage")));
            this.btnAddCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCourse.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAddCourse.Location = new System.Drawing.Point(137, 457);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(141, 45);
            this.btnAddCourse.TabIndex = 7;
            this.btnAddCourse.Text = "&Save";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(16, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(16, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Student Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.GhostWhite;
            this.txtName.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(160, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 27);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "Student Name";
            // 
            // txtLoad
            // 
            this.txtLoad.BackColor = System.Drawing.Color.GhostWhite;
            this.txtLoad.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoad.Location = new System.Drawing.Point(160, 80);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.Size = new System.Drawing.Size(227, 27);
            this.txtLoad.TabIndex = 0;
            this.txtLoad.Tag = "Course Load";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.GhostWhite;
            this.label6.Location = new System.Drawing.Point(21, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "Student Name";
            // 
            // btnDisplayCourse
            // 
            this.btnDisplayCourse.BackColor = System.Drawing.Color.Transparent;
            this.btnDisplayCourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisplayCourse.BackgroundImage")));
            this.btnDisplayCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDisplayCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayCourse.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayCourse.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnDisplayCourse.Location = new System.Drawing.Point(138, 457);
            this.btnDisplayCourse.Name = "btnDisplayCourse";
            this.btnDisplayCourse.Size = new System.Drawing.Size(141, 45);
            this.btnDisplayCourse.TabIndex = 13;
            this.btnDisplayCourse.Text = "&Display";
            this.btnDisplayCourse.UseVisualStyleBackColor = false;
            this.btnDisplayCourse.Click += new System.EventHandler(this.btnDisplayCourse_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.GhostWhite;
            this.label7.Location = new System.Drawing.Point(21, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 32;
            this.label7.Text = "Start Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.GhostWhite;
            this.label8.Location = new System.Drawing.Point(21, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 22);
            this.label8.TabIndex = 33;
            this.label8.Text = "Course Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.GhostWhite;
            this.label9.Location = new System.Drawing.Point(21, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 22);
            this.label9.TabIndex = 34;
            this.label9.Text = "Course Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.GhostWhite;
            this.label11.Location = new System.Drawing.Point(86, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(245, 39);
            this.label11.TabIndex = 23;
            this.label11.Text = "Display Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(21, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Course Load";
            // 
            // txtDisplayType
            // 
            this.txtDisplayType.BackColor = System.Drawing.Color.GhostWhite;
            this.txtDisplayType.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayType.Location = new System.Drawing.Point(162, 388);
            this.txtDisplayType.Name = "txtDisplayType";
            this.txtDisplayType.ReadOnly = true;
            this.txtDisplayType.Size = new System.Drawing.Size(227, 27);
            this.txtDisplayType.TabIndex = 12;
            // 
            // txtDisplayCourse
            // 
            this.txtDisplayCourse.BackColor = System.Drawing.Color.GhostWhite;
            this.txtDisplayCourse.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayCourse.Location = new System.Drawing.Point(162, 311);
            this.txtDisplayCourse.Name = "txtDisplayCourse";
            this.txtDisplayCourse.ReadOnly = true;
            this.txtDisplayCourse.Size = new System.Drawing.Size(227, 27);
            this.txtDisplayCourse.TabIndex = 11;
            // 
            // txtDisplayDate
            // 
            this.txtDisplayDate.BackColor = System.Drawing.Color.GhostWhite;
            this.txtDisplayDate.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayDate.Location = new System.Drawing.Point(162, 234);
            this.txtDisplayDate.Name = "txtDisplayDate";
            this.txtDisplayDate.ReadOnly = true;
            this.txtDisplayDate.Size = new System.Drawing.Size(227, 27);
            this.txtDisplayDate.TabIndex = 10;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.BackColor = System.Drawing.Color.GhostWhite;
            this.txtDisplayName.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayName.Location = new System.Drawing.Point(162, 157);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.ReadOnly = true;
            this.txtDisplayName.Size = new System.Drawing.Size(227, 27);
            this.txtDisplayName.TabIndex = 9;
            // 
            // txtDisplayLoad
            // 
            this.txtDisplayLoad.BackColor = System.Drawing.Color.GhostWhite;
            this.txtDisplayLoad.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayLoad.Location = new System.Drawing.Point(162, 80);
            this.txtDisplayLoad.Name = "txtDisplayLoad";
            this.txtDisplayLoad.ReadOnly = true;
            this.txtDisplayLoad.Size = new System.Drawing.Size(227, 27);
            this.txtDisplayLoad.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnClose.Location = new System.Drawing.Point(384, 477);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 38);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "E&xit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // _2019SpringTableAdapter
            // 
            this._2019SpringTableAdapter.ClearBeforeFill = true;
            // 
            // frmCourses
            // 
            this.AcceptButton = this.btnAddCourse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(847, 522);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spring 2019 Course Selection";
            this.Load += new System.EventHandler(this.frmCourses_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.springBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            this.gbxType.ResumeLayout(false);
            this.gbxType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxCourse;
        private System.Windows.Forms.GroupBox gbxType;
        private System.Windows.Forms.RadioButton rdoHybrid;
        private System.Windows.Forms.RadioButton rdoOnline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar calDate;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLoad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDisplayCourse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDisplayType;
        private System.Windows.Forms.TextBox txtDisplayCourse;
        private System.Windows.Forms.TextBox txtDisplayDate;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtDisplayLoad;
        private System.Windows.Forms.Button btnClose;
        private CoursesDataSet coursesDataSet;
        private System.Windows.Forms.BindingSource springBindingSource;
        private CoursesDataSetTableAdapters._2019SpringTableAdapter _2019SpringTableAdapter;
    }
}

