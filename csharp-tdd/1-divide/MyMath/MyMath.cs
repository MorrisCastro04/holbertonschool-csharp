using System;

namespace MyMath
{
    ///<summary>
    ///class Matrix
    /// </summary>
    public class Matrix
    {
        ///<summary>
        ///Divide method
        ///</summary>
        ///<param name="matrix">matrix</param>
        ///<param name="num">num</param>
        ///<returns>return a matrix</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            try
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = matrix[i, j] / num;
                    }
                }
                return matrix;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }
    }
}