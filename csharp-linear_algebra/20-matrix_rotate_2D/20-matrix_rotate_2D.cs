using System;

public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Validate 2x2 matrix
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        // Compute cos and sin of the angle
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        double[,] result = new double[2, 2];

        for (int i = 0; i < 2; i++)
        {
            double x = matrix[i, 0];
            double y = matrix[i, 1];

            double xPrime = x * cos - y * sin;
            double yPrime = x * sin + y * cos;

            // Round to 2 decimal places using AwayFromZero
            result[i, 0] = Math.Round(xPrime, 2, MidpointRounding.AwayFromZero);
            result[i, 1] = Math.Round(yPrime, 2, MidpointRounding.AwayFromZero);
        }

        return result;
    }
}
