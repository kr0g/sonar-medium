namespace sonar.medium.Models
{
    public class EmployeeEntitlementRequest
    {
        public long Id { get; set; }
        public double Salary { get; set; }
        public SalaryBand SalaryBand { get; set; }
        public double YearsOfService { get; set; }

        public EmployeeEntitlementRequest() { }
    }
}