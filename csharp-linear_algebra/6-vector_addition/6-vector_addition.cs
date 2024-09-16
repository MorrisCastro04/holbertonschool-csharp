using System;

/// <summary>
/// Contains methods to perform vector operations.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Adds two vectors and returns the resulting vector.
    /// </summary>
    /// <param name="vector1">The first vector.</param>
    /// <param name="vector2">The second vector.</param>
    /// <returns>The resulting vector. If the vectors are not 2D or 3D, returns a vector containing -1.</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 2 && vector1.Length != 3)
        {
            return new double[] {-1};
        }
        if (vector2.Length != 2 && vector2.Length != 3)
        {
            return new double[] {-1};
        }

        for (int i = 0; i < vector1.Length; i++)
            vector1[i] += vector2[i];

        return vector1;
    }
}