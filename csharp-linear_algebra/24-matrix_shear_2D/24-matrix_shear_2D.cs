class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int cols = matrix.GetLength(0);
        int rows = matrix.GetLength(1);
        double[,] result = new double[2, 2];
        double sum;


        if (cols != 2 || rows != 2)
            return new double[,] { { -1 } };

        if (direction != 'y' && direction != 'x')
            return new double[,] { { -1 } };

        if (factor < 0)
            return new double[,] { { -1 } };

        double[,] shear = new double[,] { { 1, direction == 'x' ? factor : 0 }, { direction == 'y' ? factor : 0, 1 } };

        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows; row++)
            {
                sum = 0;
                for (int i = 0; i < cols; i++)
                {
                    Console.WriteLine($"{sum} = {matrix[col, i]} * {shear[i, row]}");
                    sum += matrix[col, i] * shear[i, row];
                    Console.WriteLine(sum);
                }
                Console.WriteLine();
                result[col, row] = sum;
            }
        }
        return shear;
    }
}
