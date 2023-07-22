namespace student_management_system
{
    partial class student_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateOfBirth_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.addStudent_comboBox = new System.Windows.Forms.ComboBox();
            this.female_radioButton = new System.Windows.Forms.RadioButton();
            this.male_radioButton = new System.Windows.Forms.RadioButton();
            this.gender_label = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.studentFees_textBox = new System.Windows.Forms.TextBox();
            this.fees_label = new System.Windows.Forms.Label();
            this.course_label = new System.Windows.Forms.Label();
            this.studentAddress_textBox = new System.Windows.Forms.TextBox();
            this.studentAddress_label = new System.Windows.Forms.Label();
            this.studentEmail_textBox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.studentContact_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentName_textBox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.studentEducationDetails_label = new System.Windows.Forms.Label();
            this.studentPersonalDetails_label = new System.Windows.Forms.Label();
            this.addStudentData_label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updateStudentFees_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateStudent_comboBox = new System.Windows.Forms.ComboBox();
            this.updateStudent_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.selectStudent_comboBox = new System.Windows.Forms.ComboBox();
            this.studentdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet1 = new student_management_system.studentDataSet1();
            this.selectStudent_label = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.updateStudentFeMale_radioButton = new System.Windows.Forms.RadioButton();
            this.updateStudentMale_radioButton = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.updateStudentAddress_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.updateStudentEmail_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateStudentContactNo_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.updateStudentData_label = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deleteStudent_comboBox = new System.Windows.Forms.ComboBox();
            this.studentdataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deleteStudent_button = new System.Windows.Forms.Button();
            this.studentName_label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.student_dataTableAdapter = new student_management_system.studentDataSet1TableAdapters.student_dataTableAdapter();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 95);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bufon\'s School";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(71, 21);
            this.tabControl1.Location = new System.Drawing.Point(23, 148);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1288, 603);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dateOfBirth_dateTimePicker);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.addStudent_comboBox);
            this.tabPage1.Controls.Add(this.female_radioButton);
            this.tabPage1.Controls.Add(this.male_radioButton);
            this.tabPage1.Controls.Add(this.gender_label);
            this.tabPage1.Controls.Add(this.submit_button);
            this.tabPage1.Controls.Add(this.studentFees_textBox);
            this.tabPage1.Controls.Add(this.fees_label);
            this.tabPage1.Controls.Add(this.course_label);
            this.tabPage1.Controls.Add(this.studentAddress_textBox);
            this.tabPage1.Controls.Add(this.studentAddress_label);
            this.tabPage1.Controls.Add(this.studentEmail_textBox);
            this.tabPage1.Controls.Add(this.email_label);
            this.tabPage1.Controls.Add(this.studentContact_textBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.studentName_textBox);
            this.tabPage1.Controls.Add(this.name_label);
            this.tabPage1.Controls.Add(this.studentEducationDetails_label);
            this.tabPage1.Controls.Add(this.studentPersonalDetails_label);
            this.tabPage1.Controls.Add(this.addStudentData_label);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1280, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Student Data";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dateOfBirth_dateTimePicker
            // 
            this.dateOfBirth_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth_dateTimePicker.Location = new System.Drawing.Point(422, 347);
            this.dateOfBirth_dateTimePicker.Name = "dateOfBirth_dateTimePicker";
            this.dateOfBirth_dateTimePicker.Size = new System.Drawing.Size(296, 26);
            this.dateOfBirth_dateTimePicker.TabIndex = 50;
            this.dateOfBirth_dateTimePicker.Value = new System.DateTime(2023, 5, 21, 20, 54, 18, 0);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(495, 285);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 20);
            this.label18.TabIndex = 48;
            this.label18.Text = "Date of Birth";
            // 
            // addStudent_comboBox
            // 
            this.addStudent_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent_comboBox.FormattingEnabled = true;
            this.addStudent_comboBox.Items.AddRange(new object[] {
            "python",
            "javascript",
            "java",
            "c#",
            ""});
            this.addStudent_comboBox.Location = new System.Drawing.Point(952, 253);
            this.addStudent_comboBox.Name = "addStudent_comboBox";
            this.addStudent_comboBox.Size = new System.Drawing.Size(175, 28);
            this.addStudent_comboBox.TabIndex = 45;
            this.addStudent_comboBox.Text = "Select Course";
            this.addStudent_comboBox.SelectedIndexChanged += new System.EventHandler(this.addStudent_comboBox_SelectedIndexChanged);
            // 
            // female_radioButton
            // 
            this.female_radioButton.AutoSize = true;
            this.female_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_radioButton.Location = new System.Drawing.Point(581, 218);
            this.female_radioButton.Name = "female_radioButton";
            this.female_radioButton.Size = new System.Drawing.Size(85, 24);
            this.female_radioButton.TabIndex = 25;
            this.female_radioButton.TabStop = true;
            this.female_radioButton.Text = "FeMale";
            this.female_radioButton.UseVisualStyleBackColor = true;
            // 
            // male_radioButton
            // 
            this.male_radioButton.AutoSize = true;
            this.male_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_radioButton.Location = new System.Drawing.Point(467, 218);
            this.male_radioButton.Name = "male_radioButton";
            this.male_radioButton.Size = new System.Drawing.Size(66, 24);
            this.male_radioButton.TabIndex = 24;
            this.male_radioButton.TabStop = true;
            this.male_radioButton.Text = "Male";
            this.male_radioButton.UseVisualStyleBackColor = true;
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_label.Location = new System.Drawing.Point(522, 172);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(64, 20);
            this.gender_label.TabIndex = 23;
            this.gender_label.Text = "Gender";
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(432, 447);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(240, 62);
            this.submit_button.TabIndex = 19;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // studentFees_textBox
            // 
            this.studentFees_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentFees_textBox.Location = new System.Drawing.Point(952, 323);
            this.studentFees_textBox.Name = "studentFees_textBox";
            this.studentFees_textBox.Size = new System.Drawing.Size(175, 26);
            this.studentFees_textBox.TabIndex = 16;
            this.studentFees_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fees_label
            // 
            this.fees_label.AutoSize = true;
            this.fees_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fees_label.Location = new System.Drawing.Point(819, 323);
            this.fees_label.Name = "fees_label";
            this.fees_label.Size = new System.Drawing.Size(46, 20);
            this.fees_label.TabIndex = 15;
            this.fees_label.Text = "Fees";
            this.fees_label.Click += new System.EventHandler(this.fees_label_Click);
            // 
            // course_label
            // 
            this.course_label.AutoSize = true;
            this.course_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_label.Location = new System.Drawing.Point(819, 261);
            this.course_label.Name = "course_label";
            this.course_label.Size = new System.Drawing.Size(63, 20);
            this.course_label.TabIndex = 11;
            this.course_label.Text = "Course";
            this.course_label.Click += new System.EventHandler(this.course_label_Click);
            // 
            // studentAddress_textBox
            // 
            this.studentAddress_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentAddress_textBox.Location = new System.Drawing.Point(155, 409);
            this.studentAddress_textBox.Multiline = true;
            this.studentAddress_textBox.Name = "studentAddress_textBox";
            this.studentAddress_textBox.Size = new System.Drawing.Size(175, 49);
            this.studentAddress_textBox.TabIndex = 10;
            this.studentAddress_textBox.TextChanged += new System.EventHandler(this.studentAddress_textBox_TextChanged);
            // 
            // studentAddress_label
            // 
            this.studentAddress_label.AutoSize = true;
            this.studentAddress_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentAddress_label.Location = new System.Drawing.Point(22, 409);
            this.studentAddress_label.Name = "studentAddress_label";
            this.studentAddress_label.Size = new System.Drawing.Size(71, 20);
            this.studentAddress_label.TabIndex = 9;
            this.studentAddress_label.Text = "Address";
            this.studentAddress_label.Click += new System.EventHandler(this.studentAddress_label_Click);
            // 
            // studentEmail_textBox
            // 
            this.studentEmail_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEmail_textBox.Location = new System.Drawing.Point(155, 340);
            this.studentEmail_textBox.Name = "studentEmail_textBox";
            this.studentEmail_textBox.Size = new System.Drawing.Size(175, 26);
            this.studentEmail_textBox.TabIndex = 8;
            this.studentEmail_textBox.TextChanged += new System.EventHandler(this.studentEmail_textBox_TextChanged);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(22, 340);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(51, 20);
            this.email_label.TabIndex = 7;
            this.email_label.Text = "Email";
            this.email_label.Click += new System.EventHandler(this.email_label_Click);
            // 
            // studentContact_textBox
            // 
            this.studentContact_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentContact_textBox.Location = new System.Drawing.Point(155, 274);
            this.studentContact_textBox.Name = "studentContact_textBox";
            this.studentContact_textBox.Size = new System.Drawing.Size(175, 26);
            this.studentContact_textBox.TabIndex = 6;
            this.studentContact_textBox.TextChanged += new System.EventHandler(this.studentContact_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contact No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // studentName_textBox
            // 
            this.studentName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName_textBox.Location = new System.Drawing.Point(155, 205);
            this.studentName_textBox.Name = "studentName_textBox";
            this.studentName_textBox.Size = new System.Drawing.Size(175, 26);
            this.studentName_textBox.TabIndex = 4;
            this.studentName_textBox.TextChanged += new System.EventHandler(this.studentName_textBox_TextChanged);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(22, 205);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(53, 20);
            this.name_label.TabIndex = 3;
            this.name_label.Text = "Name";
            this.name_label.Click += new System.EventHandler(this.name_label_Click);
            // 
            // studentEducationDetails_label
            // 
            this.studentEducationDetails_label.AutoSize = true;
            this.studentEducationDetails_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEducationDetails_label.Location = new System.Drawing.Point(806, 159);
            this.studentEducationDetails_label.Name = "studentEducationDetails_label";
            this.studentEducationDetails_label.Size = new System.Drawing.Size(346, 48);
            this.studentEducationDetails_label.TabIndex = 2;
            this.studentEducationDetails_label.Text = "Education Details";
            this.studentEducationDetails_label.Click += new System.EventHandler(this.studentEducationDetails_label_Click);
            // 
            // studentPersonalDetails_label
            // 
            this.studentPersonalDetails_label.AutoSize = true;
            this.studentPersonalDetails_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentPersonalDetails_label.Location = new System.Drawing.Point(18, 111);
            this.studentPersonalDetails_label.Name = "studentPersonalDetails_label";
            this.studentPersonalDetails_label.Size = new System.Drawing.Size(325, 48);
            this.studentPersonalDetails_label.TabIndex = 1;
            this.studentPersonalDetails_label.Text = "Personal Details";
            this.studentPersonalDetails_label.Click += new System.EventHandler(this.studentPersonalDetails_label_Click);
            // 
            // addStudentData_label
            // 
            this.addStudentData_label.AutoSize = true;
            this.addStudentData_label.Location = new System.Drawing.Point(422, 14);
            this.addStudentData_label.Name = "addStudentData_label";
            this.addStudentData_label.Size = new System.Drawing.Size(419, 58);
            this.addStudentData_label.TabIndex = 0;
            this.addStudentData_label.Text = "Add Student Data";
            this.addStudentData_label.Click += new System.EventHandler(this.addStudentData_label_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.updateStudentFees_textBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.updateStudent_comboBox);
            this.tabPage2.Controls.Add(this.updateStudent_dateTimePicker);
            this.tabPage2.Controls.Add(this.selectStudent_comboBox);
            this.tabPage2.Controls.Add(this.selectStudent_label);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.updateStudentFeMale_radioButton);
            this.tabPage2.Controls.Add(this.updateStudentMale_radioButton);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.update_button);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.updateStudentAddress_textBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.updateStudentEmail_textBox);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.updateStudentContactNo_textBox);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.updateStudentData_label);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1280, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Student Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // updateStudentFees_textBox
            // 
            this.updateStudentFees_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudentFees_textBox.Location = new System.Drawing.Point(997, 323);
            this.updateStudentFees_textBox.Name = "updateStudentFees_textBox";
            this.updateStudentFees_textBox.Size = new System.Drawing.Size(175, 26);
            this.updateStudentFees_textBox.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(864, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Fees";
            // 
            // updateStudent_comboBox
            // 
            this.updateStudent_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudent_comboBox.FormattingEnabled = true;
            this.updateStudent_comboBox.Items.AddRange(new object[] {
            "python",
            "javascript",
            "java",
            "c#"});
            this.updateStudent_comboBox.Location = new System.Drawing.Point(997, 257);
            this.updateStudent_comboBox.Name = "updateStudent_comboBox";
            this.updateStudent_comboBox.Size = new System.Drawing.Size(175, 28);
            this.updateStudent_comboBox.TabIndex = 53;
            this.updateStudent_comboBox.Text = "Select Course";
            this.updateStudent_comboBox.SelectedIndexChanged += new System.EventHandler(this.updateStudent_comboBox_SelectedIndexChanged);
            // 
            // updateStudent_dateTimePicker
            // 
            this.updateStudent_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudent_dateTimePicker.Location = new System.Drawing.Point(490, 376);
            this.updateStudent_dateTimePicker.Name = "updateStudent_dateTimePicker";
            this.updateStudent_dateTimePicker.Size = new System.Drawing.Size(300, 26);
            this.updateStudent_dateTimePicker.TabIndex = 52;
            // 
            // selectStudent_comboBox
            // 
            this.selectStudent_comboBox.DataSource = this.studentdataBindingSource;
            this.selectStudent_comboBox.DisplayMember = "Name";
            this.selectStudent_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectStudent_comboBox.FormattingEnabled = true;
            this.selectStudent_comboBox.Location = new System.Drawing.Point(169, 196);
            this.selectStudent_comboBox.Name = "selectStudent_comboBox";
            this.selectStudent_comboBox.Size = new System.Drawing.Size(187, 28);
            this.selectStudent_comboBox.TabIndex = 51;
            this.selectStudent_comboBox.SelectedIndexChanged += new System.EventHandler(this.selectStudent_comboBox_SelectedIndexChanged);
            // 
            // studentdataBindingSource
            // 
            this.studentdataBindingSource.DataMember = "student_data";
            this.studentdataBindingSource.DataSource = this.studentDataSet1BindingSource;
            // 
            // studentDataSet1BindingSource
            // 
            this.studentDataSet1BindingSource.DataSource = this.studentDataSet1;
            this.studentDataSet1BindingSource.Position = 0;
            // 
            // studentDataSet1
            // 
            this.studentDataSet1.DataSetName = "studentDataSet1";
            this.studentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectStudent_label
            // 
            this.selectStudent_label.AutoSize = true;
            this.selectStudent_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectStudent_label.Location = new System.Drawing.Point(35, 196);
            this.selectStudent_label.Name = "selectStudent_label";
            this.selectStudent_label.Size = new System.Drawing.Size(118, 20);
            this.selectStudent_label.TabIndex = 50;
            this.selectStudent_label.Text = "Select Student";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(486, 302);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 20);
            this.label19.TabIndex = 48;
            this.label19.Text = "Date of Birth";
            // 
            // updateStudentFeMale_radioButton
            // 
            this.updateStudentFeMale_radioButton.AutoSize = true;
            this.updateStudentFeMale_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudentFeMale_radioButton.Location = new System.Drawing.Point(630, 235);
            this.updateStudentFeMale_radioButton.Name = "updateStudentFeMale_radioButton";
            this.updateStudentFeMale_radioButton.Size = new System.Drawing.Size(85, 24);
            this.updateStudentFeMale_radioButton.TabIndex = 42;
            this.updateStudentFeMale_radioButton.TabStop = true;
            this.updateStudentFeMale_radioButton.Text = "FeMale";
            this.updateStudentFeMale_radioButton.UseVisualStyleBackColor = true;
            // 
            // updateStudentMale_radioButton
            // 
            this.updateStudentMale_radioButton.AutoSize = true;
            this.updateStudentMale_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudentMale_radioButton.Location = new System.Drawing.Point(525, 235);
            this.updateStudentMale_radioButton.Name = "updateStudentMale_radioButton";
            this.updateStudentMale_radioButton.Size = new System.Drawing.Size(66, 24);
            this.updateStudentMale_radioButton.TabIndex = 41;
            this.updateStudentMale_radioButton.TabStop = true;
            this.updateStudentMale_radioButton.Text = "Male";
            this.updateStudentMale_radioButton.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(568, 199);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 20);
            this.label17.TabIndex = 40;
            this.label17.Text = "Gender";
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(500, 471);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(240, 73);
            this.update_button.TabIndex = 39;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(864, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Course";
            // 
            // updateStudentAddress_textBox
            // 
            this.updateStudentAddress_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudentAddress_textBox.Location = new System.Drawing.Point(169, 403);
            this.updateStudentAddress_textBox.Multiline = true;
            this.updateStudentAddress_textBox.Name = "updateStudentAddress_textBox";
            this.updateStudentAddress_textBox.Size = new System.Drawing.Size(175, 49);
            this.updateStudentAddress_textBox.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Address";
            // 
            // updateStudentEmail_textBox
            // 
            this.updateStudentEmail_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudentEmail_textBox.Location = new System.Drawing.Point(169, 334);
            this.updateStudentEmail_textBox.Name = "updateStudentEmail_textBox";
            this.updateStudentEmail_textBox.Size = new System.Drawing.Size(175, 26);
            this.updateStudentEmail_textBox.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Email";
            // 
            // updateStudentContactNo_textBox
            // 
            this.updateStudentContactNo_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudentContactNo_textBox.Location = new System.Drawing.Point(169, 268);
            this.updateStudentContactNo_textBox.Name = "updateStudentContactNo_textBox";
            this.updateStudentContactNo_textBox.Size = new System.Drawing.Size(175, 26);
            this.updateStudentContactNo_textBox.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Contact No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(854, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(346, 48);
            this.label12.TabIndex = 22;
            this.label12.Text = "Education Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(325, 48);
            this.label13.TabIndex = 21;
            this.label13.Text = "Personal Details";
            // 
            // updateStudentData_label
            // 
            this.updateStudentData_label.AutoSize = true;
            this.updateStudentData_label.Location = new System.Drawing.Point(438, 25);
            this.updateStudentData_label.Name = "updateStudentData_label";
            this.updateStudentData_label.Size = new System.Drawing.Size(492, 58);
            this.updateStudentData_label.TabIndex = 20;
            this.updateStudentData_label.Text = "Update Student Data";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleteStudent_comboBox);
            this.tabPage3.Controls.Add(this.deleteStudent_button);
            this.tabPage3.Controls.Add(this.studentName_label);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1280, 574);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Student Data";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // deleteStudent_comboBox
            // 
            this.deleteStudent_comboBox.DataSource = this.studentdataBindingSource1;
            this.deleteStudent_comboBox.DisplayMember = "Name";
            this.deleteStudent_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteStudent_comboBox.FormattingEnabled = true;
            this.deleteStudent_comboBox.Location = new System.Drawing.Point(579, 202);
            this.deleteStudent_comboBox.Name = "deleteStudent_comboBox";
            this.deleteStudent_comboBox.Size = new System.Drawing.Size(243, 46);
            this.deleteStudent_comboBox.TabIndex = 29;
            // 
            // studentdataBindingSource1
            // 
            this.studentdataBindingSource1.DataMember = "student_data";
            this.studentdataBindingSource1.DataSource = this.studentDataSet1BindingSource1;
            // 
            // studentDataSet1BindingSource1
            // 
            this.studentDataSet1BindingSource1.DataSource = this.studentDataSet1;
            this.studentDataSet1BindingSource1.Position = 0;
            // 
            // deleteStudent_button
            // 
            this.deleteStudent_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.deleteStudent_button.Location = new System.Drawing.Point(477, 324);
            this.deleteStudent_button.Name = "deleteStudent_button";
            this.deleteStudent_button.Size = new System.Drawing.Size(246, 71);
            this.deleteStudent_button.TabIndex = 23;
            this.deleteStudent_button.Text = "Delete";
            this.deleteStudent_button.UseVisualStyleBackColor = true;
            this.deleteStudent_button.Click += new System.EventHandler(this.deleteStudent_button_Click);
            // 
            // studentName_label
            // 
            this.studentName_label.AutoSize = true;
            this.studentName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName_label.Location = new System.Drawing.Point(151, 202);
            this.studentName_label.Name = "studentName_label";
            this.studentName_label.Size = new System.Drawing.Size(324, 39);
            this.studentName_label.TabIndex = 22;
            this.studentName_label.Text = "Enter Student Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(469, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(395, 48);
            this.label14.TabIndex = 21;
            this.label14.Text = "Delete Student Data";
            // 
            // student_dataTableAdapter
            // 
            this.student_dataTableAdapter.ClearBeforeFill = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(486, 340);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(347, 20);
            this.label15.TabIndex = 56;
            this.label15.Text = "Updation of Date Of Birth is compulsory";
            // 
            // student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 743);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "student_form";
            this.Text = "student_form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.student_form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.TextBox studentFees_textBox;
        private System.Windows.Forms.Label fees_label;
        private System.Windows.Forms.Label course_label;
        private System.Windows.Forms.TextBox studentAddress_textBox;
        private System.Windows.Forms.Label studentAddress_label;
        private System.Windows.Forms.TextBox studentEmail_textBox;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox studentContact_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentName_textBox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label studentEducationDetails_label;
        private System.Windows.Forms.Label studentPersonalDetails_label;
        private System.Windows.Forms.Label addStudentData_label;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox updateStudentAddress_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox updateStudentEmail_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox updateStudentContactNo_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label updateStudentData_label;
        private System.Windows.Forms.Button deleteStudent_button;
        private System.Windows.Forms.Label studentName_label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton female_radioButton;
        private System.Windows.Forms.RadioButton male_radioButton;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.RadioButton updateStudentFeMale_radioButton;
        private System.Windows.Forms.RadioButton updateStudentMale_radioButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox addStudent_comboBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dateOfBirth_dateTimePicker;
        private System.Windows.Forms.ComboBox selectStudent_comboBox;
        private System.Windows.Forms.Label selectStudent_label;
        private System.Windows.Forms.ComboBox deleteStudent_comboBox;
        private System.Windows.Forms.DateTimePicker updateStudent_dateTimePicker;
        private System.Windows.Forms.ComboBox updateStudent_comboBox;
        private System.Windows.Forms.TextBox updateStudentFees_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource studentDataSet1BindingSource;
        private studentDataSet1 studentDataSet1;
        private System.Windows.Forms.BindingSource studentdataBindingSource;
        private studentDataSet1TableAdapters.student_dataTableAdapter student_dataTableAdapter;
        private System.Windows.Forms.BindingSource studentdataBindingSource1;
        private System.Windows.Forms.BindingSource studentDataSet1BindingSource1;
        private System.Windows.Forms.Label label15;
    }
}