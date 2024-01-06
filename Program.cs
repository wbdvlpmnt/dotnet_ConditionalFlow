namespace controlFlow;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(ConditionalFlow.FindMax(1, 2));
        System.Console.WriteLine(2 > 1 ? 2 : 1);
        ConditionalFlow.Recommendation("sunny");
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

    public static void Recommendation(string weather)
    {
        switch (weather)
        {
            case "rainy":
                System.Console.WriteLine("Stay indoors it's raining");
                break;
            case "sunny":
                System.Console.WriteLine("Go outside");
                break;
            default:
                System.Console.WriteLine("Weather is complicated");
                break;
        }
    }


}