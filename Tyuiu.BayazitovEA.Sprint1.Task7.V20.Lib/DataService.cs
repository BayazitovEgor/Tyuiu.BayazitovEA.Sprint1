using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BayazitovEA.Sprint1.Task7.V20.Lib
{
    public class DataService : ISprint1Task7V20
    {
        public double Calculate(double x, double y)
        {
            double cosValue = Math.Cos(x + y);
            double numerator = 2 + Math.Pow(cosValue, 2);

            double denominatorPart = x - (3 * x) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2));
            double denominator = 1 + Math.Abs(denominatorPart);

            double z = numerator / denominator + x * y;

            return Math.Round(z, 3);
        }
    }
}
