using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.BayazitovEA.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V13
    {
        public double MultiplyOfDigits(double x)
        {
            int y = (int)x;
            double digit1 = y / 100;
            double digit2 = (y / 10) % 10;
            double digit3 = y % 10;

            double product = digit1 * digit2 * digit3;
            return Math.Round(product, 3);
            
        }
    }
}
