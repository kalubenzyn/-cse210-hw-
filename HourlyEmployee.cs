using system;
namespace employe_demo{
    public class HourlyEmployee : Employee
    
    public float _payRate = 0;
    private innt _hoursWorked = 0;
    public float GetPayRate()
    {
        return _payRate;
    }

    public void SetPayRate(float payRate)
    {
        _payRate = payRate;
    }
    public int GetHoursWorked()
    {
        return _hoursWorked;
    }
    public void SetHoursWorked(int hoursWorked)
    {
        _hoursWorked = hoursWorked;
    }
        public override float GetPay(){
            return _payRate * _hoursWorked; // Assuming hourly pay is calculated as pay rate multiplied by hours worked
        }

}