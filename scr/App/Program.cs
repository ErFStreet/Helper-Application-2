namespace App;

public class Program
{
    public readonly static int num1 = 1;

    public readonly static int num2 = 2;

    public readonly static string numString = "3";

    public readonly static string message = "Hello World";

    static void Main()
    {
        // WithEnter => ()

        Console.WriteLine(value: message.WithEnter());

        Console.WriteLine(value: message);

        Console.WriteLine(value: "**********");

        // ToInt => ()

        var numberToInt = numString.ToInt();

        Console.WriteLine(value: numberToInt);

        Console.WriteLine(value: "**********");

        // IsOddNumber => ()

        var isOdd = num1.IsOddNumber();

        Console.WriteLine(value:isOdd);

        Console.WriteLine(value: "**********");

        // IsEvenNumber

        var isEven = num2.IsEvenNumber();   

        Console.WriteLine(value:isEven);
    }
}