using system;
namespace employe_demo{
    public class SalaryEmployee : Employee
    {
        private float salary = 0;

        private float GetSalary()
        {
            return salary;
        }
        public void SetSalary(float salary)
        {
            _salary = salary;
        }

        public override float GetPay()
        {
            return _salary / 12; // Assuming salary is annual, so divide by 12 for monthly pay
        }
    }
}