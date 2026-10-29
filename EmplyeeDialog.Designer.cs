namespace ThirdProgram
{
    partial class EmplyeeDialog
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
            label1 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtSalary = new TextBox();
            label2 = new Label();
            label5 = new Label();
            dtpDateofBirth = new DateTimePicker();
            cmbDepartment = new ComboBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 92);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(350, 92);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 146);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 0;
            label3.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(350, 145);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 1;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 184);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 0;
            label4.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(350, 181);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(100, 23);
            txtSalary.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 232);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 0;
            label2.Text = "Date Of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(216, 267);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 0;
            label5.Text = "Department";
            // 
            // dtpDateofBirth
            // 
            dtpDateofBirth.Location = new Point(350, 221);
            dtpDateofBirth.Name = "dtpDateofBirth";
            dtpDateofBirth.Size = new Size(128, 23);
            dtpDateofBirth.TabIndex = 2;
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(350, 264);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(100, 23);
            cmbDepartment.TabIndex = 3;
            cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(350, 346);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(461, 346);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button2_Click;
            // 
            // EmplyeeDialog
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(799, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(cmbDepartment);
            Controls.Add(dtpDateofBirth);
            Controls.Add(txtSalary);
            Controls.Add(txtLastName);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "EmplyeeDialog";
            Text = "EmplyeeDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtSalary;
        private Label label2;
        private Label label5;
        private DateTimePicker dtpDateofBirth;
        private ComboBox cmbDepartment;
        private Button btnOK;
        private Button btnCancel;
    }
}