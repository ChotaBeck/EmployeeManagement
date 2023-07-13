using EmployeeManagement.Data;
using EmployeeMangement.Shared;

namespace EmployeeManagement.Services
{
    public class EmployeeService : ServiceBase<Employee> 
    {   
        public EmployeeService(ApplicationDbContext context) :base(context)
        {
            
        }
    }
}