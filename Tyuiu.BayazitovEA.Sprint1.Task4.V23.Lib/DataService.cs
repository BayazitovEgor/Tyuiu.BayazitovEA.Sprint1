using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BayazitovEA.Sprint1.Task4.V23.Lib
{
    public class DataService : ISprint1Task4V23
    {
        public double Calculate(double x, double y)
        {
            double v = Math.Sqrt(Math.Abs(x+y));  
            double f = Math.Abs(3 - x);         
            double r = v / f;


            return Math.Round(r, 3);
        }
    }
}
