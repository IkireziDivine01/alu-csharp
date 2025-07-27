using System;

public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Matrix must be n x 2 for valid 2D vector rotation
        if (cols != 2 || rows < 1)
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows, 2];

        // Precompute cos and sin
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        for (int i = 0; i < rows; i++)
        {
            double x = matrix[i, 0];
            double y = matrix[i, 1];

            // Rotation: [x', y'] = [x*cos - y*sin, x*sin + y*cos]
            result[i, 0] = Math.Round(x * cos - y * sin, 2);
            result[i, 1] = Math.Round(x * sin + y * cos, 2);
        }

        return result;
    }
}
