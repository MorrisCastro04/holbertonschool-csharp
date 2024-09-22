using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method that calculates the determinant of a 2D matrix
    /// </summary>
    /// <param name="matrix">Matrix to calculate the determinant</param>
    /// <returns>The determinant of the matrix</returns>
    public static double Determinant2D(double[,] matrix)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    /// <summary>
    /// Method that calculates the determinant of a matrix
    /// </summary>
    /// <param name="matrix">Matrix to calculate the determinant</param>
    /// <returns>The determinant of the matrix</returns>
    public static double Determinant(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if ((cols == 2 && rows == 2) || (cols == 3 && rows == 3))
        {
            if (cols == 2)
                return Determinant2D(matrix);

            double matrixA = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
            double matrixB = matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
            double matrixC = matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            return Math.Round(matrixA - matrixB + matrixC, 2);
        }
        return -1;
    }
}
