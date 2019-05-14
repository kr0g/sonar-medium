using sonar.medium.Models;

namespace sonar.medium.Tasks
{
    public class EmployeeEntitlementTask : IEmployeeEntitlementTask
    {
        public double calculateEmployeeCredits(EmployeeEntitlementRequest request)
        {
            double credits = 0;
            
            // determine credits for years of service
            if (request.YearsOfService <=2)
                    credits += 200;
            else if (request.YearsOfService <= 5)
                    credits += 600;
            else if (request.YearsOfService <= 10)
                    credits += 1000;
            else if (request.YearsOfService <= 15)
                credits += 2000;
            else if (request.YearsOfService <= 20)
                credits += 2500;
            else if (request.YearsOfService > 20)
                credits += 3500;
            else
                credits += 50;
            
            //determine credits based on salary
            if (request.Salary <= 50000)
                credits += 200;
            else if (request.Salary <= 75000)
                credits += 600;
            else if (request.Salary <= 100000)
                credits += 1000;
            else if (request.Salary <= 150000)
                credits += 2000;
            else if (request.Salary <= 200000)
                credits += 2500;
            else if (request.Salary > 200000)
                credits += 3500;
            else
                credits += 50;
            
            //determine credits based on salary band
            if (request.SalaryBand == SalaryBand.PartTime)
                credits += 200;
            else if (request.SalaryBand == SalaryBand.FullTime)
                credits += 600;
            else if (request.SalaryBand == SalaryBand.Manager)
                credits += 1000;
            else if (request.SalaryBand == SalaryBand.Executive)
                credits += 2000;
            else if (request.SalaryBand == SalaryBand.SeniorExecutive)
                credits += 2500;
            
            return credits;
        }
    }
}