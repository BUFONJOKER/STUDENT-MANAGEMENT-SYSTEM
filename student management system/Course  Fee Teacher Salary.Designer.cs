namespace student_management_system
{
    partial class Course__Fee_Teacher_Salary
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
            this.label2 = new System.Windows.Forms.Label();
            this.studentDataSet2 = new student_management_system.studentDataSet2();
            this.moneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moneyTableAdapter = new student_management_system.studentDataSet2TableAdapters.moneyTableAdapter();
            this.money_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 95);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bufon\'s School";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(814, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Course Fee and Teacher Salary according to Course";
            // 
            // studentDataSet2
            // 
            this.studentDataSet2.DataSetName = "studentDataSet2";
            this.studentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moneyBindingSource
            // 
            this.moneyBindingSource.DataMember = "money";
            this.moneyBindingSource.DataSource = this.studentDataSet2;
            // 
            // moneyTableAdapter
            // 
            this.moneyTableAdapter.ClearBeforeFill = true;
            // 
            // money_textBox
            // 
            this.money_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money_textBox.Location = new System.Drawing.Point(215, 351);
            this.money_textBox.Multiline = true;
            this.money_textBox.Name = "money_textBox";
            this.money_textBox.Size = new System.Drawing.Size(729, 209);
            this.money_textBox.TabIndex = 12;
            // 
            // Course__Fee_Teacher_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 743);
            this.Controls.Add(this.money_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Course__Fee_Teacher_Salary";
            this.Text = "Course__Fee_Teacher_Salary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Course__Fee_Teacher_Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private studentDataSet2 studentDataSet2;
        private System.Windows.Forms.BindingSource moneyBindingSource;
        private studentDataSet2TableAdapters.moneyTableAdapter moneyTableAdapter;
        private System.Windows.Forms.TextBox money_textBox;
    }
}