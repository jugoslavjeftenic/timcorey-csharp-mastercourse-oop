namespace T25_03_01_MethodOverriding
{
    public class CommisionEmployeeModel : EmployeModel
    {
        public decimal CommisionAmount { get; set; }

        public override decimal GetPaycheckAmount(int hoursWorked)
        {
            decimal initialPay = base.GetPaycheckAmount(hoursWorked);

            return initialPay + CommisionAmount;
        }
    }
}