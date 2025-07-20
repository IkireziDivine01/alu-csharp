using System;

public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check for 2x2 matrix
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        // Create rotation matrix
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        double[,] rotationMatrix = new double[,]
        {
            { cos, -sin },
            { sin,  cos }
        };

        // Multiply input matrix by rotation matrix
        double[,] result = new double[2, 2];

        for (int row = 0; row < 2; row++)
        {
            for (int col = 0; col < 2; col++)
            {
                result[row, col] =
                    matrix[row, 0] * rotationMatrix[0, col] +
                    matrix[row, 1] * rotationMatrix[1, col];
            }
        }

        return result;
    }
}
