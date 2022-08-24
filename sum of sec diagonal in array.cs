class Demo
{
    static void Main()
    {
        System.Console.Write("enter the base");
        int a = int.Parse(System.Console.ReadLine());

        System.Console.Write("enter the sub");
        int b = int.Parse(System.Console.ReadLine());
        int[,] arr = new int[a, b];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                System.Console.Write("enter the data");
                arr[i, j] = int.Parse(System.Console.ReadLine());

            }
            System.Console.WriteLine();

        }
        System.Console.WriteLine("------------");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                System.Console.Write(arr[i, j] + "  ");
            }
            System.Console.WriteLine();
        }
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if(i+j==b-1)
                {
                    sum = sum + arr[i, j];
                }
            }
        }
        System.Console.WriteLine(sum);
    }
}

