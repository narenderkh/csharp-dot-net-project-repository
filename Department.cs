using System;
using System.Collections.Generic;

namespace ThirdProgram;

public partial class Department
{
    public int DeptId { get; set; }

    public string? DeptName { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
