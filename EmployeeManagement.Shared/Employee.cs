namespace EmployeeMangement.Shared
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public string ManNumber { get; set; }
        public int PhoneNumber { get; set; }
        public string NrcNumber { get; set; }
        public int SocialSecurityNumber { get; set; }
        public int NhimaNumber { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}