namespace T25_03_01_MethodOverriding
{
    public class EmployeModel : PersonModel
    {
        public decimal HourlyRate { get; set; }

        public virtual decimal GetPaycheckAmount(int hoursWorked)
        {
            return HourlyRate * hoursWorked;
        }
    }
}