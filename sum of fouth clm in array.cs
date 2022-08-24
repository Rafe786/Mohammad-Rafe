class Demo
{
    static void Main()
    {
        int[,] arr;
        System.Console.WriteLine("enter the base array size");
        int b = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("enter the sub array size");
        int c = int.Parse(System.Console.ReadLine());
        arr = new int[b, c];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                System.Console.Write("enter the data");
                arr[i, j] = int.Parse(System.Console.ReadLine());
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine("-------------------");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                System.Console.Write(arr[i, j] + "\t");
            }
            System.Console.WriteLine();
        }

        System.Console.WriteLine("--------------");
        int high = arr[0, 0];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (i == 1)
                {

                    if (high < arr[i, j])
                    {
                        high = arr[i, j];
                       
                    }

                }
               
                     

            }
        }System.Console.WriteLine(high);
       
      
        System.Console.WriteLine();
    }
}