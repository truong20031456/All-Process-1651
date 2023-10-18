namespace Employee_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasePlusCommissionEmployee employee = new BasePlusCommissionEmployee(
      "Bob", "Lewis", "333-33-3333", 5000, 0.04, 300);

            // Lấy thông tin của nhân viên base-salaried commission employee bằng các phương thức get
            Console.WriteLine("Employee information obtained by get methods:\n");
            Console.WriteLine($"First name is {employee.getfirstName}");
            Console.WriteLine($"Last name is {employee.getlastName}");
            Console.WriteLine($"Social security number is {employee.getSocietyNumber}");
            Console.WriteLine($"Gross sales is {employee.getGrosssales:F2}");
            Console.WriteLine($"Commission rate is {employee.getComissionRate:F2}");
            Console.WriteLine($"Base salary is {employee.getBaseSalary:F2}");

            employee.setBaseSalary(1000);

            // In thông tin của nhân viên sau khi cập nhật bằng phương thức ToString
            Console.WriteLine($"\nUpdated employee information obtained by ToString:\n\n{employee}");

        }
    }
}