using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;

namespace ЛАБА5ВЫЧМАТ
{
    public class RectangleIntegral
    {
        static decimal GetRectangleScale(double x1, double x2, Program.MyFunction f) 
            => (decimal)f((x2 + x1) / 2.0) * (decimal)(x2 - x1);

        static decimal Integrate(double down, double up, int count, Program.MyFunction f)
        {
            var step = (up - down) / count;
            var sum = 0.0m;

            for (var i = 0; i < count; i++)
                sum += GetRectangleScale(down + step * i, down + step * (i + 1), f);
            return sum;
        }

        static decimal Abs(decimal val)
        {
            return val > 0 ? val : -val;
        }

        public static (double H, decimal result) CalculateWithAcuracy(double down, double up, double accuracy, Program.MyFunction f)
        {
            int count = 1;

            var lastResult = Integrate(down, up, count, f); //предыдущий
            var result = Integrate(down, up, count + 1, f); //текущий

            while (Abs(lastResult - result) > (decimal)accuracy)
            {
                count++;
                lastResult = result;
                result = Integrate(down, up, count + 1, f);
            }

            double H = (up - down) / count;

            return (H, result);
        }
    }

    public class SimpsonIntegral
    {

        static decimal Integrate(double down, double up, int count, Program.MyFunction f)
        {
            count *= 2;
            var step = (up - down) / (count);
            var sum =  (decimal)f(down) + (decimal)f(up);

            for(var i=1; i < count-1; i++)
            {
                sum += (i % 2 == 0) ? 2 * (decimal)f(down + step * i) : 4 * (decimal)f(down + step * i);
            }
            return (decimal)(step / 3.0) * sum;
        }

        static decimal Abs(decimal val)
        {
            return val > 0 ? val : -val;
        }


        public static (double H, decimal result) CalculateWithAcuracy(double down, double up, double accuracy, Program.MyFunction f)
        {
            var count = 1;

            var lastResult = Integrate(down, up, count, f); //предыдущий
            var result = Integrate(down, up, count + 1, f); //текущий

            while (Abs(lastResult - result) > (decimal)accuracy)
            {
                count++;
                lastResult = result;
                result = Integrate(down, up, count + 1, f);
            }

            double H = (up - down) / count;

            return (H, result);
        }
    }
}
