namespace EmployeeAdminPortal.Models.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public string? Phone { get; set; }

        public decimal Salary { get; set; }
    }

    //1. required : Name:stirng must be initialized while creating an object..
    // same for Email

    //2. ? this field need not to be initialized or can nullable..


}
