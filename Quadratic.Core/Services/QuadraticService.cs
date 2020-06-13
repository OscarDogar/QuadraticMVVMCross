using System;

namespace Quadratic.Core.Services
{
    public class QuadraticService : IQuadraticService
    {
        public double SolveQuadraticPositive(double a, double b, double c)
        {
            double answer1;
            double sqrtpart = (b * b) - (4 * a * c);
            answer1 = ((-1) * b + Math.Sqrt(sqrtpart)) / (2 * a);
            return answer1;
        }

        public double SolveQuadraticNegative(double a, double b, double c)
        {
            double answer2;
            double sqrtpart = (b * b) - (4 * a * c);
            answer2 = ((-1) * b - Math.Sqrt(sqrtpart)) / (2 * a);
            return answer2;
        }

    }
}
