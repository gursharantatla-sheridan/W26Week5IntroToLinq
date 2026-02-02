namespace W26Week5IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 4, 6, 2, 1, 3, 4, 5, 6, 7, 6, 9, 8 };

            // query syntax
            var greaterThan4 = from n in array
                               where n > 4
                               orderby n
                               select n;

            foreach (var i in greaterThan4)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");


            // method syntax
            var greaterThan5 = array.Where(n => n > 5).OrderByDescending(n => n);

            foreach (var i in greaterThan5)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");



            List<string> colors = new List<string>();
            colors.Add("bLuE");
            colors.Add("rUbY");
            colors.Add("GrEEnE");
            colors.Add("ReD");

            var startsWithR = from c in colors
                              let uppercaseColors = c.ToUpper()
                              where uppercaseColors.StartsWith("R")
                              orderby uppercaseColors
                              select uppercaseColors;

            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");


            colors.Add("rUsT");
            colors.Add("YeLLow");

            // deferred execution
            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n\n\n");


            List<Employee> employees = new List<Employee>()
            {
                new Employee("James", "White", 4000),
                new Employee("Anne", "Indigo", 3000),
                new Employee("John", "Brown", 5000),
                new Employee("Alice", "Indigo", 6000),
                new Employee("Bob", "Green", 8000),
                new Employee("Cathy", "White", 5500)
            };


            foreach (var emp in employees)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var between4k6k = from e in employees
                              where e.Salary >= 4000 && e.Salary <= 6000
                              select e;

            foreach (var emp in between4k6k)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var sortedEmps = from e in employees
                             orderby e.LastName, e.FirstName
                             select e;

            foreach (var emp in sortedEmps)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var lastnames = from e in employees
                            select e.LastName;

            foreach (var emp in lastnames.Distinct())
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            var empNames = from e in employees
                           select new { e.FirstName, e.LastName };

            foreach (var emp in empNames)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");
        }
    }
}
