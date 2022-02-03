using System;

public class employee
{
    
    int emp_id;
    string na;
    int depid;
    DateTime  j_date;
    string addr;
    double sal;
    double bou;
        public employee(int employeeId , string name, int DepartmentId, DateTime joiningdate , string address, double salary , double bonus )
        {
            this.emp_id=employeeId;
            this.na=name;
            this.sal=salary;
            this.bou=bonus;
            this.j_date=joiningdate.Date;
            this.depid=DepartmentId;
        }

        public virtual void GetEmployeeDetails(int employeeId)
        {
            Console.WriteLine($"employee_id ={emp_id} Name={na} DepartmentId={depid} JoiningDate={j_date}");
        }

        public virtual Double GetEmployeeSalaryInfo(int employeeId)
        {
            Double ts=sal+bou;
            return ts;

        }

    }
