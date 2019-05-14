using Microsoft.AspNetCore.Mvc;
using sonar.medium.Models;
using sonar.medium.Tasks;

namespace sonar.medium.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    public class BenefitsEntitlementController
    {
        private readonly IEmployeeEntitlementTask entitlementTask;

        public BenefitsEntitlementController(IEmployeeEntitlementTask task)
        {
            this.entitlementTask = task;
        }
        
        // POST api/values
        [HttpPost]
        public EmployeeEntitlementResponse Post([FromBody] EmployeeEntitlementRequest request)
        {
            return new EmployeeEntitlementResponse(request.Id, entitlementTask.calculateEmployeeCredits(request));
        }
    }
}