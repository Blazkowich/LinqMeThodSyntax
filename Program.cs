using EmployeeNamespace;
namespace ternaryoperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var filteredList = new List<Employees>();
            var listOfEmployees = new List<Employees>
            {
                new Employees {EmployeeID=1150, FirstName="Jack",
                LastName="Stevenson", Salary=5000m, Age=35,
                Appraisal = new List<int>{7,7,8,9,7 } },

                new Employees {EmployeeID=1151, FirstName="Goga",
                LastName="Talakhadze", Salary=6000m, Age=37,
                Appraisal = new List<int>{9,9,8,9,8 } },

                new Employees {EmployeeID=1152, FirstName="Vaja",
                LastName="Talakhadze", Salary=7000m, Age=41,
                Appraisal = new List<int>{9,9,8,9,8 } }
            };

            Employees.DisplayWithAppraisal(listOfEmployees, "All Employees");

            //This Or Next
            //IEnumerable<Employees> list = listOfEmployees.Where(e=>e.Salary>=6000 && e.Age > 40)
            filteredList = listOfEmployees.Where(e => e.Salary >= 6000 && e.Age > 40).ToList();



            foreach (var employee in filteredList)
            {

                Console.WriteLine(employee.FirstName);


            }
            Console.WriteLine();

        }
    }
}
