using System;

public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Validate 2x2 matrix
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        // Get sin and cos of the angle
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        // Create new rotated matrix
        double[,] result = new double[2, 2];

        for (int i = 0; i < 2; i++)
        {
            double x = matrix[i, 0];
            double y = matrix[i, 1];

            // Rotate the vector [x, y]
            double xPrime = x * cos - y * sin;
            double yPrime = x * sin + y * cos;

            // Assign the rotated vector back
            result[i, 0] = Math.Round(xPrime, 2);
            result[i, 1] = Math.Round(yPrime, 2);
        }

        return result;
    }
}
