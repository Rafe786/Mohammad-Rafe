class Demo
{
    static int[] sort(int[] arr)
    {
        int ctr = 0;

        int temp = 0;
        while (ctr < arr.Length)
        {
            int ptr = ctr + 1;
            while (ptr < arr.Length)
            {
                if (arr[ctr] > arr[ptr])
                {
                    temp = arr[ctr];
                    arr[ctr] = arr[ptr];
                    arr[ptr] = temp;
                }
                ptr++;
            }
            ctr = ctr + 1;
        }
        return arr;
    }
    static void Main()
    {
        System.Console.WriteLine(" enter the size of arry");
        int b = int.Parse(System.Console.ReadLine());
        int[] arr = new int[b];
        int i = 0;
        while (i < b)
        {
            System.Console.WriteLine(" enter the value");
            arr [i] = int.Parse(System.Console.ReadLine());
            i++;
        }
        int []array = sort(arr);
        foreach (int s in array)
        {
            System.Console.Write (s);


        }
        

    }

}