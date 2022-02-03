using System;

public class contract : employee
{
    public int cont()
    {
        //if not regular then calculating 3% of their salary as they are not eligble for bonus
        Double percent=(3*sal)/100;
        ts=sal+percent;
        return ts;

    }
     public override string GetEmployeeSalaryInfo(int employeeId)
        {
            Double ts=sal+bou;
            return ts;
        }
}