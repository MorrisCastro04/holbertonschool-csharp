﻿using System;

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
        double sum;
        double[,] result = new double[rows, cols];

        if (rows != 2 || cols != 2)
            return new double[,] { { -1 } };

        double[,] SinCosMatrix = { { cos, -sin }, { sin, cos } };

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                sum = 0;
                for (int i = 0; i < cols; i++)
                {
                    sum = Math.Round(sum + (matrix[row,i] * SinCosMatrix[i, col]), 2);
                }
                result[row, col] = Math.Round(sum, 2);
            }
        }
        return result;
    }
}
