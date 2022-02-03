using System;

public class regular : employee
{
    public int reg()
    {
        //if a regular employee then bonus is added in salary
    ts = sal + bou;
    return ts;
    }
     public override string GetEmployeeSalaryInfo(int employeeId)
        {
            Double ts=sal+bou;
            return ts;
        }
}