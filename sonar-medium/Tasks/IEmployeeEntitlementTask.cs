using sonar.medium.Models;

namespace sonar.medium.Tasks
{
    public interface IEmployeeEntitlementTask
    {
        double calculateEmployeeCredits(EmployeeEntitlementRequest request);
    }
}