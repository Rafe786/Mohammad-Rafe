class Demo
{
    int[] M1(int[] arr)
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
            ctr++;
        }
        


    }
    static void Main()
    {
        int[] arr = { 10, 20, 30, 5, 4, 6, 0 };
        Demo demo = new Demo();
        demo.M1(arr);
        foreach (int c in arr)
        {
            System.Console.WriteLine(c);
        }

    }
}