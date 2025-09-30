using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.BayazitovEA.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            if (string.IsNullOrEmpty(value))
                return true;

            for (int i = 0; i < value.Length - 1; i++)
            {
                if (value[i] > value[i + 1])
                    return false;
            }
            return true;
        }
    }
}
