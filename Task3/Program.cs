
class Program
{
    static void Main(string[] args)
    {
        byte b = 10;
        short s = 200;
        int i = 1000;
        long l = 100000L;
        float f = 3.5f;
        double d = 9.876;
        decimal dec = 123.456m;
        char c = 'A';
        bool flag = true;
        
        int num = 42;
        string strNum = num.ToString();
        
        string strPi = "3.14";
        double piValue = Convert.ToDouble(strPi);
        
        Console.WriteLine("byte b = " + b);
        Console.WriteLine("short s = " + s);
        Console.WriteLine("int i = " + i);
        Console.WriteLine("long l = " + l);
        Console.WriteLine("float f = " + f);
        Console.WriteLine("double d = " + d);
        Console.WriteLine("decimal dec = " + dec);
        Console.WriteLine("char c = " + c);
        Console.WriteLine("bool flag = " + flag);
        Console.WriteLine("Converted int to string: " + strNum);
        Console.WriteLine("Converted string to double: " + piValue);
    }
}