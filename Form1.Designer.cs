namespace ThirdProgram
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
            btAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            gvEmployee = new DataGridView();
            cmbDepartment = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gvEmployee).BeginInit();
            SuspendLayout();
            // 
            // btAdd
            // 
            btAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btAdd.Location = new Point(388, 385);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(98, 20);
            btAdd.TabIndex = 1;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.Location = new Point(523, 385);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(76, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(619, 385);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // gvEmployee
            // 
            gvEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvEmployee.Location = new Point(117, 101);
            gvEmployee.Name = "gvEmployee";
            gvEmployee.Size = new Size(516, 257);
            gvEmployee.TabIndex = 4;
            gvEmployee.CellContentClick += gvEmployee_CellContentClick;
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(108, 31);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(121, 23);
            cmbDepartment.TabIndex = 5;
            cmbDepartment.SelectedIndexChanged += cmbDepartmnet_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbDepartment);
            Controls.Add(gvEmployee);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gvEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView gvEmployee;
        private ComboBox cmbDepartment;
    }
}
