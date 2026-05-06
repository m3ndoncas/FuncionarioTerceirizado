
using FuncionarioTerceirizado.Entities;

namespace FuncionarioTerceirizado
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();

            Console.Write("Quantos funcionários serão? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i}");
                Console.Write("Terceirizado? (s/n)?");
                string input = Console.ReadLine();
                char option = char.ToLower(input[0]);

                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (option == 's')
                {
                    Console.Write("Despesa adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    Employee outsourced = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);

                    employees.Add(outsourced);
                }
                else
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees.Add(employee);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name + " - $" + employee.Payment().ToString("F2"));
            }





        }
    }
}