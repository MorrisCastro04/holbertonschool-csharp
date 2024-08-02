class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0)
        {
            Console.WriteLine("");
        }
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = i;
            if (array.Length - 1 == i)
            {
                Console.Write("{0}\n", array[i]);
            }
            else {
                Console.Write("{0} ", array[i]);
            }
        }
        return array;
    }
}