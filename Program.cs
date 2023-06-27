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
                LastName="Talakhadze", Salary=6000m, Age=26,
                Appraisal = new List<int>{9,9,8,9,8 } },

                new Employees {EmployeeID=1152, FirstName="Vaja",
                LastName="Talakhadze", Salary=7000m, Age=41,
                Appraisal = new List<int>{9,9,8,9,8 } }
            };

            Employees.DisplayWithAppraisal(listOfEmployees, "All Employees");



            //Enumerable Syntax
            //IEnumerable<Employees> list = listOfEmployees.Where(e=>e.Salary>=6000 && e.Age > 40)

            //Method Syntax
            //filteredList = listOfEmployees.Where(e => e.Salary > 4000 && e.Appraisal[0] < 8).ToList();

            //Query Syntax
            //filteredList = (from emp in listOfEmployees
            //                where emp.Salary >= 4000 && emp.Appraisal[0] < 8
            //                select emp).ToList();

            //Sorting Syntax
            //filteredList = (from emp in listOfEmployees
            //                orderby emp.Salary descending, emp.Age descending
            //                select emp).ToList();

            

            Employees.DisplayWithAppraisal(SortEmployees(listOfEmployees), "Sorted List");
            Employees.DisplayWithAppraisal(FilterList(listOfEmployees), "Filtered List");

        }


        //Queries With Methods
        public static List<Employees> SortEmployees(List<Employees> employees)
        {
            var list = from emp in employees
                       orderby emp.Age descending
                       select emp;
            return list.ToList();
        }

        //Filter With Methods
        public static List<Employees> FilterList(List<Employees> employees)
        {
            var list = from emp in employees
                       where emp.Salary >= 6000
                       select emp;
            return list.ToList();
        }
    }
}
