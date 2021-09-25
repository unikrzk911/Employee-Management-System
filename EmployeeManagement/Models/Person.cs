using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Last name required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public char? Gender { get; set; } = 'M';
        public double? Salary { get; set; }

        public static List<Person> GetEmployees()
        {
            //Object Initializer Syntax
            Person emp1 = new Person() { Id = 1, FirstName = "Bishnu", LastName = "Rawal", Address = "Kathmandu", Salary = 200.0 };
            Person emp2 = new Person() { Id = 2, FirstName = "Unique", LastName = "Rajak", Address = "Kathmandu", Salary = 200.0 };
            Person emp3 = new Person() { Id = 3, FirstName = "Ritesh", LastName = "Dhakal", Address = "Kathmandu", Salary = 200.0 };
            Person emp4 = new Person() { Id = 4, FirstName = "Riya", LastName = "Shrestha", Address = "Kathmandu", Salary = 200.0, Gender = 'F' };
            Person emp5 = new Person() { Id = 5, FirstName = "Prajesh", LastName = "Pradhan", Address = "Kathmandu", Salary = 200.0 };

            List<Person> employees = new List<Person>() { emp1, emp2, emp3, emp4, emp5 };
            return employees;
        }
    }

    
}
