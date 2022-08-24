class Demo{
    static void cal(int num1, int num2, char op)
    {
    switch (op)
      {
      case'+':
      System.Console.WriteLine(num1 + num2);
      break;
     case'-':
     System.Console.WriteLine(num1 - num2);
      break;
      case'/':
      System.Console.WriteLine(num1 / num2);
                break;
      case'*':
     default:
     System.Console.WriteLine("invalid op");
      break; 
      }
   }
   static void main()
   {
    System.Console.WriteLine("enter the num1");
    int a = int.Parse(System.Console.ReadLine());
    System.Console.WriteLine("enter the num2");
    int b = int.Parse(system.Console.ReadLine());
    System.Console.WriteLine("enter the opp");
    char c = System.Convert.ToChar(System.Console.ReadLine());
    cal(a, b, c);
   }
}