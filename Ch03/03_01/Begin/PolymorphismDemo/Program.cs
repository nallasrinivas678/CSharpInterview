using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// What’s POLYMORPHISM? 
/// It’s when classes have different functionality while sharing the same interface.
/// REMEMBER TO NOTE!!!: Interfaces or abstract classes can be used
/// </summary>
namespace PolymorphismDemo
{
    public class Employee
    {
        public string EmployeeName { get; set; } = "Srinivas Nalla";
        public int Age { get; set; } = 29;
        public virtual void CalculateWeeklySalary(int weeklyHrs, int wage)
        {
            var salary = 40 * wage;
            Console.WriteLine($" Name {this.EmployeeName } - \n This Employee worked {weeklyHrs} hrs. " +
                $"Paid for 40 hrs w/o overtime at {wage}/hr => {salary}");
            
        }
    }
    public class Contractor : Employee
    {
        public override void CalculateWeeklySalary(int weeklyHrs, int wage)
        {
            var salary = weeklyHrs * wage;
            Console.WriteLine($"Name {this.EmployeeName } - \n This contrat employee worked {weeklyHrs} hrs. " +
                $"Paid for {weeklyHrs} hrs with overtime at {wage}/hr => {salary}");
            
        }
    }
    public class Program
    {
        private static void Main(string[] args)
        {
            //TODO
            const int hours = 50, wage = 70;
            Employee person = new Employee();
            person.CalculateWeeklySalary(hours,wage);

            var contractor = new Contractor();
            contractor.CalculateWeeklySalary(hours, wage);

            Console.ReadLine();
        }

    }
}
