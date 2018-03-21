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
        static decimal GetRectangleScale(decimal x1, decimal x2, Program.MyFunction f) 
            => f((x2 + x1) / 2.0m) * (x2 - x1);

        static decimal Integrate(decimal down, decimal up, int count, Program.MyFunction f)
        {
            count *= 2;
            var step = (up - down) / (count);
            var sum = f(down) + f(up);

            for (var i = 1; i <= count - 1; i++)
            {
                var value = f(down + step * i);
                sum += 2 * value;
            }
            return (step / 2.0m) * sum;
        }

        static decimal Abs(decimal val)
        {
            return val > 0 ? val : -val;
        }

        public static (decimal H, decimal result) CalculateWithAcuracy(decimal down, decimal up, decimal accuracy, Program.MyFunction f)
        {
            int count = 1;

            var lastResult = Integrate(down, up, count, f); //предыдущий
            var result = Integrate(down, up, count + 1, f); //текущий

            while (Abs(lastResult - result) > accuracy)
            {
                count++;
                lastResult = result;
                result = Integrate(down, up, count + 1, f);
            }

            var H = (up - down) / count;

            return (H, result);
        }
    }

    public class SimpsonIntegral
    {

        static decimal Integrate(decimal down, decimal up, int count, Program.MyFunction f)
        {
            count *= 2;
            var step = (up - down) / (count);
            var sum =  f(down) + f(up);

            for(var i=1; i <= count-1; i++)
            {
                var value = f(down + step * i);
                sum += (i % 2 == 0) ? 2 * value : 4 * value;
            }
            return (step / 3.0m) * sum;
        }

        static decimal Abs(decimal val)
        {
            return val > 0 ? val : -val;
        }


        public static (decimal H, decimal result) CalculateWithAcuracy(decimal down, decimal up, decimal accuracy, Program.MyFunction f)
        {
            var count = 1;

            var lastResult = Integrate(down, up, count, f); //предыдущий
            var result = Integrate(down, up, count + 1, f); //текущий

            while (Abs(lastResult - result) > accuracy)
            {
                count++;
                lastResult = result;
                result = Integrate(down, up, count + 1, f);
            }

            var H = (up - down) / count;

            return (H, result);
        }
    }
}
