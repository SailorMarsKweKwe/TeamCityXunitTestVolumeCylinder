using System;
using Xunit;

namespace TestProject2
{
    public class Method
    {
       public static double VolumCylinderFormula(double r, double h)
       {
         return Math.PI * Math.Pow(r, 2) * h;

       }
    }
}
