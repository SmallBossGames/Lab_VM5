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
        static double GetRectangleScale(double x1, double x2, Program.MyFunction f) 
            => f((x2 + x1) / 2.0) * (x2 - x1);

        static double Integrate(double down, double up, int count, Program.MyFunction f)
        {
            var step = (up - down) / count;
            var sum = 0.0;

            for (var i = 0; i < count; i++)
                sum += GetRectangleScale(down + step * i, down + step * (i + 1), f);
            return sum;
        }

        static double Abs(double val)
        {
            return val > 0 ? val : -val;
        }

        public static (double H, double result) CalculateWithAcuracy(double down, double up, double accuracy, Program.MyFunction f)
        {
            int count = 1;

            double lastResult = Integrate(down, up, count, f); //предыдущий
            double result = Integrate(down, up, count + 1, f); //текущий

            while (Abs(lastResult - result) > accuracy)
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

        static double Integrate(double down, double up, int count, Program.MyFunction f)
        {
            count *= 2;
            var step = (up - down) / (count);
            var sum =  f(down) + f(up);

            for(var i=1; i < count-1; i++)
            {
                sum += (i % 2 == 0) ? 2 * f(down + step * i) : 4 * f(down + step * i);
            }
            return (step / 3.0) * sum;
        }

        static double Abs(double val)
        {
            return val > 0 ? val : -val;
        }


        public static (double H, double result) CalculateWithAcuracy(double down, double up, double accuracy, Program.MyFunction f)
        {
            var count = 1;

            double lastResult = Integrate(down, up, count, f); //предыдущий
            double result = Integrate(down, up, count + 1, f); //текущий

            while (Abs(lastResult - result) > accuracy)
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
