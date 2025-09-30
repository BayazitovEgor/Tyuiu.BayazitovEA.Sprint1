using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BayazitovEA.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double x)
        {
           return (x / 100) * ((x / 10) % 10) * (x % 10);
        }
    }
}
