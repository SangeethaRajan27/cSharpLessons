
   
        public delegate void MethodHandlerA();
        public delegate int MethodHandlerB(int x, int y);
        public class MathCalculator
        {
            public void DoTask()
            {
                Console.WriteLine("Calculator dotask");
            }
            public int Add(int x, int y)
            {
                Console.WriteLine(x + "," + y);
                return x + y;
            }
            public int Multiply(int x, int y)
            {
                Console.WriteLine(x + "," + y);
                return x * y;
            }
            public int Divide(int x, int y)
            {
                Console.WriteLine(x + "," + y);
                return x / y;
            }
            public String GetModel()
            {
                return "X500";
            }
        }
public class DelegateDemoA
{
    public static void Test()
    {
        MathCalculator mc = new MathCalculator();
        MethodHandlerA A = mc.DoTask;//new MethodHandlerA(mc.DoTask);
        MethodHandlerB B = mc.Add;// new MethodHandlerB(mc.Add);
        MethodHandlerB C = mc.Multiply;// new MethodHandlerB(mc.Multiply);
        MethodHandlerB D = mc.Divide;
        A();
        int addresult = B(100, 50);
        Console.WriteLine(addresult);
        int mulresult = B(20, 5);
        Console.WriteLine(mulresult);
        int divresult = B(20, 5);
        Console.WriteLine(divresult);

    }
    public static void Test2()
    {
        MathCalculator mc = new MathCalculator();
        MethodHandlerB methodHandlerB2 = mc.Add;
        methodHandlerB2 += mc.Multiply;
        methodHandlerB2(100, 50);
    }
}
    
        
/*MathCalculator mc = new Mathcalculator();
 * MethodHandlerA A = mc.doTask;
 * MethodHandlerB B = mc.Add;
 * MethodHandlerB C = mc.Multiply;*/
    

