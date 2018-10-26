using System;

namespace PuzzlerC1
{
    internal static class Program
    {
        #The intention of this method is to round a double to the nearest integer. 
        #If the double is exactly half way between two integers then it rounds to the larger of the two possibilities:
        #[1. For negative numbers, -1.5 should round to -1.0, since -1.0 is larger than -2.0; 
        #I do not mean larger in the sense of absolute magnitude. That would be characterized as “midpoint rounding away from zero”.]

        static double MyRound(double d)
        {
          return Math.Floor(d + 0.5);
        }
       
        static void Main(string[] args)
        {
          var machineEpsilon = 1.0;
          while (1.0 + machineEpsilon > 1)
          {
            machineEpsilon /= 2;
          }
          MyRound(0.5 – machineEpsilon / 2);
        }
    }
}
