using System;

/// <summary>
/// Represents a class of matrix operations.
/// </summary>
class MatrixMath
{
    public static double Determinant2D(double[,] matrix)
    {
        return (Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2));
    }
    /// <summary>
    /// Represents a method to calculate the determinant of a matrix.
    /// </summary>
    /// <param name="matrix">The matrix to calculate the determinant of.</param>
    /// <returns>The determinant of the matrix.</returns>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(1) > 3 || matrix.GetLength(1) != matrix.GetLength(0))
        {
            return (-1);
        }
        if (matrix.GetLength(1) == 2)
        {
            return (Determinant2D(matrix));
        }
        double[,] detA = new double[,] { { matrix[1, 1], matrix[1, 2] }, { matrix[2, 1], matrix[2, 2] } };
        double[,] detB = new double[,] { { matrix[1, 0], matrix[1, 2] }, { matrix[2, 0], matrix[2, 2] } };
        double[,] detC = new double[,] { { matrix[1, 0], matrix[1, 1] }, { matrix[2, 0], matrix[2, 1] } };
        double res = ((matrix[0, 0] * Determinant2D(detA)) - (matrix[0, 1] * Determinant2D(detB))) + matrix[0, 2] * Determinant2D(detC);
        return Math.Round(res, 2);
    }
}