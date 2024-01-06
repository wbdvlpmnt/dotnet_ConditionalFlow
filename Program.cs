namespace controlFlow;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(ConditionalFlow.FindMax(1, 2));
        System.Console.WriteLine(2 > 1 ? 2 : 1);
    }
}

public class ConditionalFlow()
{

    public static int FindMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }


}