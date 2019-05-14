namespace sonar.medium.Models
{
    public class EmployeeEntitlementResponse
    {
        public long Id { get; set; }
        public double BenefitsCredits { get; set; }

        public EmployeeEntitlementResponse()
        { 
        }
        
        public EmployeeEntitlementResponse(long id, double credits)
        {
            Id = id;
            BenefitsCredits = credits;
        }
    }
}