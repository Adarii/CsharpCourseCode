using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            float fMin = float.MinValue;
            float fMax = float.MaxValue;
            Console.WriteLine("Min Value = {0} , Max Vlaue = {1}", fMin, fMax);

            float flVar = 1F / 3;
            double dVar = 1D / 3;
            decimal dcVar = 1M / 3;
            Console.WriteLine("float value = {0}\ndouble value = {1}\ndecimal value = {2}\n", flVar, dVar, dcVar);



            Console.ReadKey();
        }
    }
}
