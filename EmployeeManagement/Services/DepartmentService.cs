using EmployeeManagement.Data;
using EmployeeMangement.Shared;

namespace EmployeeManagement.Services
{
    public class DepartmentService : ServiceBase<Department> 
    {
        public DepartmentService(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}