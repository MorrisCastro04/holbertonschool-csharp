using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Shear2D method
    /// </summary>
    /// <param name="matrix">double[,]</param>
    /// <param name="direction">char</param>
    /// <param name="factor">double</param>
    /// <returns>double[,]</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 || cols != 2)
            return new double[,] { { -1 } };

        if (char.ToLower(direction) != 'x' && char.ToLower(direction) != 'y')
            return new double[,] { { -1 } };

        double[,] result = new double[rows, cols];

        if (direction == 'x')
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] + (i == 0 ? factor * matrix[j, 0] : 0);
                }
            }
        }
        else if (direction == 'y')
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] + (j == 0 ? factor * matrix[0, i] : 0);
                }
            }
        }

        return result;
    }
}
