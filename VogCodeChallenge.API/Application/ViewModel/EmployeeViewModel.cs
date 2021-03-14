namespace VogCodeChallenge.API.Application.ViewModel
{
    using System;

    public class EmployeeViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string ResidenceAddress { get; set; }
        public string Departmentname { get; set; }
        public string CompanyName { get; set; }
    }
}
