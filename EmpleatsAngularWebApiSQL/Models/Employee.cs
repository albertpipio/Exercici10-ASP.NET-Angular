using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpleatsAngularWebApiSQL.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeePosition { get; set; }
        public decimal EmployeeSalary { get; set; }
        public string DateOfJoining { get; set; }
        public string PhotoFileName { get; set; }
    }
}