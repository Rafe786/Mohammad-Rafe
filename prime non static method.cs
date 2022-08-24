class Demo
{
   static void pattern(int []arr)
    {

        int ctr = 2;
        int i = 0;
        
        bool flag = true;
        while (ctr <= arr.Length)
        {
            if (arr[i] % ctr == 0)
            {
                flag =false;
                break;
            }
            ctr++;
            
            
        }
      

        if (flag == true)
            System.Console.WriteLine("prime");
        else
          
        System.Console.WriteLine("not prime");
       
    }
    static void Main()
    {
        int[] arr;
        System.Console.Write("enter the size of array");
       int num = int.Parse(System.Console.ReadLine());
       arr = new int[num];
            int i = 0;
        while (i<arr.Length)
        {
            System.Console.WriteLine(" enter the value");
            arr[i] = int.Parse(System.Console.ReadLine());
            i++;

        }


        pattern(arr);

    }
}

