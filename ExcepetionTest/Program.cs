using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepetionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ExcepetionTest test = new ExcepetionTest();
                test.FirstMetod(-1, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Завершение работы");
                Console.ReadLine();

            }
        }
    }
    class ExcepetionTest
    {
        public void FirstMetod(int a, int b)
        {
            SecondMetod(a, b);
        }
        public void SecondMetod(int a, int b)
        {
            ThridMetod(a, b);
        }
        public void ThridMetod(int a, int b)
        {
            try
            {
                if (a < 0)
                    throw new ArgumentException("Параметр должен быть меньше нуля!", "a");
                if (b < 0)
                    throw new ArgumentException("Параметр должен быть меньше нуля!", "b");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }   
}
