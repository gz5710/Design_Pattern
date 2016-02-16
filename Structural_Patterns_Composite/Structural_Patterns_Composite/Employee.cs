using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Composite
{
    class Employee
    {
        public string Position { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        private List<Employee> Decendant { get; set; }

        public Employee()
        {
            this.Decendant = new List<Employee>();
        }

        public void Add(Employee emp)
        {
            this.Decendant.Add(emp);
        }
        public List<Employee> GetEmpList()
        {
            return this.Decendant;
        }

        public string ToString(int depth)
        {
            string str = $" {new string('-', depth)}{this.Position}, {this.Age} years old, in the {this.Department} department.";
            this.Decendant.ForEach(e => str = $"{str}\n{e.ToString(depth + 2)}");
            return str;
        }
    }
}
