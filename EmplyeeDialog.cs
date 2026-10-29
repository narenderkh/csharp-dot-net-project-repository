using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThirdProgram
{
    public partial class EmplyeeDialog : Form
    {
        public EmplyeeDialog()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FirstNAme
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LastName
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Decimal Salary
        {
            get { return Decimal.Parse(txtSalary.Text); }
            set { txtSalary.Text = value.ToString(); }

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateOnly DateOfBirth
        {
            get { return DateOnly.Parse(dtpDateofBirth.Text); }
            set { dtpDateofBirth.Text = value.ToString(); }

        }

        public void FillComboBox(EfdemoDbContext context)
        {
            cmbDepartment.DisplayMember = "DeptName";
            cmbDepartment.ValueMember = "DeptId";
            cmbDepartment.DataSource = context.Departments.ToList();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Deptid
        {
            get { return (int)cmbDepartment.SelectedValue; }
            set { cmbDepartment.SelectedValue = value; }

        }

    }
}
