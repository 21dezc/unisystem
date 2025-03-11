namespace UniSystem
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            topG = new Label();
            label8 = new Label();
            gb1 = new GroupBox();
            cmbAdvisor = new ComboBox();
            tStudentID = new TextBox();
            tGrade = new TextBox();
            tMajor = new TextBox();
            tLastName = new TextBox();
            tFirstName = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label15 = new Label();
            Label16 = new Label();
            groupBox2 = new GroupBox();
            label22 = new Label();
            label20 = new Label();
            textBox7 = new TextBox();
            gb2 = new GroupBox();
            tLastNameA = new TextBox();
            label10 = new Label();
            tMajorA = new TextBox();
            label19 = new Label();
            tFirstNameA = new TextBox();
            label17 = new Label();
            XAdvisorMajor = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            btnAddStudent = new Button();
            btnClear = new Button();
            btnAddAdvisor = new Button();
            btnClearA = new Button();
            dgvStudents = new DataGridView();
            label18 = new Label();
            cmbAdvisor22 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gb1.SuspendLayout();
            groupBox2.SuspendLayout();
            gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 68);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "FirstName :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 115);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "LastName :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 202);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 3;
            label4.Text = "Grade :";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(40, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 201);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 155);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 11;
            label5.Text = "Mojor :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 243);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 12;
            label6.Text = "Advisor :";
            // 
            // topG
            // 
            topG.AutoSize = true;
            topG.Location = new Point(40, 422);
            topG.Name = "topG";
            topG.Size = new Size(140, 20);
            topG.TabIndex = 13;
            topG.Text = "Top GradeStudent  :";
           
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 36);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 21;
            label8.Text = " HistoryStudent";
            // 
            // gb1
            // 
            gb1.Controls.Add(cmbAdvisor);
            gb1.Controls.Add(tStudentID);
            gb1.Controls.Add(tGrade);
            gb1.Controls.Add(tMajor);
            gb1.Controls.Add(tLastName);
            gb1.Controls.Add(tFirstName);
            gb1.Controls.Add(label14);
            gb1.Controls.Add(label13);
            gb1.Controls.Add(label12);
            gb1.Controls.Add(label11);
            gb1.Controls.Add(label1);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(label3);
            gb1.Controls.Add(label5);
            gb1.Controls.Add(label4);
            gb1.Controls.Add(label6);
            gb1.Location = new Point(226, 61);
            gb1.Name = "gb1";
            gb1.Size = new Size(276, 284);
            gb1.TabIndex = 23;
            gb1.TabStop = false;
            // 
            // cmbAdvisor
            // 
            cmbAdvisor.FormattingEnabled = true;
            cmbAdvisor.Location = new Point(119, 238);
            cmbAdvisor.Name = "cmbAdvisor";
            cmbAdvisor.Size = new Size(151, 28);
            cmbAdvisor.TabIndex = 38;
            // 
            // tStudentID
            // 
            tStudentID.Location = new Point(118, 17);
            tStudentID.Name = "tStudentID";
            tStudentID.Size = new Size(150, 27);
            tStudentID.TabIndex = 35;
            // 
            // tGrade
            // 
            tGrade.Location = new Point(118, 195);
            tGrade.Name = "tGrade";
            tGrade.Size = new Size(150, 27);
            tGrade.TabIndex = 34;
            // 
            // tMajor
            // 
            tMajor.Location = new Point(118, 148);
            tMajor.Name = "tMajor";
            tMajor.Size = new Size(150, 27);
            tMajor.TabIndex = 32;
            // 
            // tLastName
            // 
            tLastName.Location = new Point(118, 108);
            tLastName.Name = "tLastName";
            tLastName.Size = new Size(150, 27);
            tLastName.TabIndex = 31;
            // 
            // tFirstName
            // 
            tFirstName.Location = new Point(118, 58);
            tFirstName.Name = "tFirstName";
            tFirstName.Size = new Size(150, 27);
            tFirstName.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(118, 198);
            label14.Name = "label14";
            label14.Size = new Size(0, 20);
            label14.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(118, 152);
            label13.Name = "label13";
            label13.Size = new Size(0, 20);
            label13.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(118, 108);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(118, 58);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 24;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(415, 396);
            label15.Name = "label15";
            label15.Size = new Size(0, 20);
            label15.TabIndex = 28;
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Location = new Point(13, 17);
            Label16.Name = "Label16";
            Label16.Size = new Size(0, 20);
            Label16.TabIndex = 23;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Location = new Point(40, 455);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(163, 66);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(14, 18);
            label22.Name = "label22";
            label22.Size = new Size(58, 20);
            label22.TabIndex = 24;
            label22.Text = "label22";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(15, 20);
            label20.Name = "label20";
            label20.Size = new Size(0, 20);
            label20.TabIndex = 23;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(63, 370);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 22;
            // 
            // gb2
            // 
            gb2.Controls.Add(tLastNameA);
            gb2.Controls.Add(label10);
            gb2.Controls.Add(tMajorA);
            gb2.Controls.Add(label19);
            gb2.Controls.Add(tFirstNameA);
            gb2.Controls.Add(label17);
            gb2.Controls.Add(XAdvisorMajor);
            gb2.Controls.Add(Label16);
            gb2.Controls.Add(textBox1);
            gb2.Location = new Point(622, 61);
            gb2.Name = "gb2";
            gb2.Size = new Size(262, 157);
            gb2.TabIndex = 24;
            gb2.TabStop = false;
            // 
            // tLastNameA
            // 
            tLastNameA.Location = new Point(102, 61);
            tLastNameA.Name = "tLastNameA";
            tLastNameA.Size = new Size(150, 27);
            tLastNameA.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(102, 61);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 40;
            // 
            // tMajorA
            // 
            tMajorA.Location = new Point(102, 105);
            tMajorA.Name = "tMajorA";
            tMajorA.Size = new Size(150, 27);
            tMajorA.TabIndex = 40;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(13, 64);
            label19.Name = "label19";
            label19.Size = new Size(82, 20);
            label19.TabIndex = 39;
            label19.Text = "LastName :";
            // 
            // tFirstNameA
            // 
            tFirstNameA.Location = new Point(102, 21);
            tFirstNameA.Name = "tFirstNameA";
            tFirstNameA.Size = new Size(150, 27);
            tFirstNameA.TabIndex = 39;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(13, 24);
            label17.Name = "label17";
            label17.Size = new Size(83, 20);
            label17.TabIndex = 30;
            label17.Text = "FirstName :";
            // 
            // XAdvisorMajor
            // 
            XAdvisorMajor.AutoSize = true;
            XAdvisorMajor.Location = new Point(39, 108);
            XAdvisorMajor.Name = "XAdvisorMajor";
            XAdvisorMajor.Size = new Size(56, 20);
            XAdvisorMajor.TabIndex = 31;
            XAdvisorMajor.Text = "Mojor :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 370);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(673, 37);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 26;
            label9.Text = "ข้อมูลอาจารย์";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(277, 351);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(150, 39);
            btnAddStudent.TabIndex = 35;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click_1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(435, 351);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(67, 39);
            btnClear.TabIndex = 37;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddAdvisor
            // 
            btnAddAdvisor.Location = new Point(652, 224);
            btnAddAdvisor.Name = "btnAddAdvisor";
            btnAddAdvisor.Size = new Size(159, 39);
            btnAddAdvisor.TabIndex = 41;
            btnAddAdvisor.Text = "Add";
            btnAddAdvisor.UseVisualStyleBackColor = true;
            btnAddAdvisor.Click += btnAddAdvisor_Click;
            // 
            // btnClearA
            // 
            btnClearA.Location = new Point(817, 224);
            btnClearA.Name = "btnClearA";
            btnClearA.Size = new Size(67, 39);
            btnClearA.TabIndex = 42;
            btnClearA.Text = "Clear";
            btnClearA.UseVisualStyleBackColor = true;
            btnClearA.Click += btnClearA_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.BackgroundColor = SystemColors.ButtonHighlight;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(622, 349);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(298, 247);
            dgvStudents.TabIndex = 46;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(614, 318);
            label18.Name = "label18";
            label18.Size = new Size(152, 20);
            label18.TabIndex = 47;
            label18.Text = "แสดงรายชื่อนักศึกษาของ";
            // 
            // cmbAdvisor22
            // 
            cmbAdvisor22.FormattingEnabled = true;
            cmbAdvisor22.Location = new Point(773, 315);
            cmbAdvisor22.Name = "cmbAdvisor22";
            cmbAdvisor22.Size = new Size(151, 28);
            cmbAdvisor22.TabIndex = 48;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 611);
            Controls.Add(cmbAdvisor22);
            Controls.Add(label18);
            Controls.Add(dgvStudents);
            Controls.Add(btnClearA);
            Controls.Add(btnAddAdvisor);
            Controls.Add(label15);
            Controls.Add(btnClear);
            Controls.Add(btnAddStudent);
            Controls.Add(label9);
            Controls.Add(gb2);
            Controls.Add(groupBox2);
            Controls.Add(gb1);
            Controls.Add(label8);
            Controls.Add(topG);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label topG;
        private Label label8;
        private GroupBox gb1;
        private GroupBox groupBox2;
        private TextBox textBox7;
        private GroupBox gb2;
        private TextBox textBox1;
        private Label label9;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label Label16;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label XAdvisorMajor;
        private Label label17;
        private Label label16;
        private Button btnAddStudent;
        private TextBox tGrade;
        private TextBox tMajor;
        private TextBox tLastName;
        private TextBox tFirstName;
        private Button btnClear;
        private TextBox tStudentID;
        private ComboBox cmbAdvisor;
        private TextBox tMajorA;
        private TextBox tFirstNameA;
        private Button btnAddAdvisor;
        private Button btnClearA;
        private TextBox tLastNameA;
        private Label label10;
        private DataGridView dgvStudents;
        private Label label18;
        private ComboBox cmbAdvisor22;
        private Label label22;
    }
}
