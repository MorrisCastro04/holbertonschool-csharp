using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method that rotates a square 2D matrix by a given angle in radians
    /// </summary>
    /// <param name="matrix">2D matrix</param>
    /// <param name="angle">Angle in radians</param>
    /// <returns>Resulting matrix</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double sin = Math.Sin(angle);
        double cos = Math.Cos(angle);
        double[,] result = new double[rows, cols];

        if (rows != 2 || cols != 2)
            return new double[,] { { -1 } };

        double[,] SinCosMatrix = { { Math.Round(cos, 1), Math.Round(sin, 1) }, { Math.Round(-sin, 1), Math.Round(cos, 1) } };

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                for (int i = 0; i < cols; i++)
                {
                    result[row, col] += matrix[row, i] * SinCosMatrix[i, col];
                }
            }
        }
        return result;
    }
}
