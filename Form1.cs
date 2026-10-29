namespace ThirdProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EfdemoDbContext context = new EfdemoDbContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            gvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvEmployee.MultiSelect = false;

            cmbDepartment.DisplayMember = "DeptName";
            cmbDepartment.ValueMember = "DeptId";
            cmbDepartment.DataSource = context.Departments.ToList();

            BindDataToGrid();
        }

        private void BindDataToGrid()
        {
            var qry = from emp in context.Employees
                      where emp.DeptId == (int)cmbDepartment.SelectedValue
                      select new
                      {
                          emp.EmpId,
                          emp.FirstName,
                          emp.LastName,
                          emp.Salary,
                          emp.DateofBirth,
                          emp.Dept.DeptName
                      };

            gvEmployee.DataSource = qry.ToList();

        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            EmplyeeDialog dlg = new EmplyeeDialog();
            dlg.FillComboBox(context);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Employee emp = new Employee();
                emp.FirstName = dlg.FirstNAme;
                emp.LastName = dlg.LastName;
                emp.Salary = dlg.Salary;
                emp.DateofBirth = dlg.DateOfBirth;
                emp.DeptId = dlg.Deptid;
                context.Employees.Add(emp);
                context.SaveChanges();

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDepartmnet_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDataToGrid();
        }

        private void gvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = (int)gvEmployee.SelectedRows[0].Cells[0].Value;
            
            Employee emp = context.Employees.Find(id);

             //MessageBox.Show(emp.FirstName);
            EmplyeeDialog dlg = new EmplyeeDialog();

            dlg.FirstNAme = emp.FirstName;
            dlg.LastName = emp.LastName;
            dlg.Salary = emp.Salary;
            dlg.DateOfBirth = emp.DateofBirth;
            dlg.Deptid = emp.DeptId;

            dlg.FillComboBox(context);
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Employee emp = new Employee();
                emp.FirstName = dlg.FirstNAme;
                emp.LastName = dlg.LastName;
                emp.Salary = dlg.Salary;
                emp.DateofBirth = dlg.DateOfBirth;
                emp.DeptId = dlg.Deptid;
                context.SaveChanges();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int id = (int)gvEmployee.SelectedRows[0].Cells[0].Value;
            Employee emp = context.Employees.Find(id);
            context.Employees.Remove(emp);
            context.SaveChanges();
            BindDataToGrid();

        }
    }
}
