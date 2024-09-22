using System;

/// <summary>
/// Class for matrix math
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Method that calculates the inverse of a 2D matrix
    /// </summary>
    /// <param name="matrix">The matrix to find the inverse of</param>
    /// <returns>The inverse of the matrix, or a matrix containing -1 if the matrix is not a 2D matrix</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        double a = matrix[0, 0];
        double b = matrix[0, 1];
        double c = matrix[1, 0];
        double d = matrix[1, 1];

        double det = (a * d) - (b * c);

        if (det == 0)
        {
            return new double[,] { { -1 } };
        }

        double[,] inverse = new double[2, 2];

        inverse[0, 0] = d / det;
        inverse[0, 1] = -b / det;
        inverse[1, 0] = -c / det;
        inverse[1, 1] = a / det;

        return inverse;
    }
}