namespace Contributors.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }
        public double HealthSpending { get; set; }
        public int EmployeeNumbers { get; set; }

        protected Person(string name, double annualIncome, double healthSpending, int employeeNumbers)
        {
            Name = name;
            AnnualIncome = annualIncome;
            HealthSpending = healthSpending;
            EmployeeNumbers = employeeNumbers;
        }

        public abstract double Tax();
    }
}
