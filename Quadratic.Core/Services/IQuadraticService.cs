namespace Quadratic.Core.Services
{
    public interface IQuadraticService
    {
        double SolveQuadraticPositive(double a, double b, double c);

        double SolveQuadraticNegative(double a, double b, double c);
    }
}
