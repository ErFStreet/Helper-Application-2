namespace App.Instructure;

public static class StringHelper : object
{
    public static string WithEnter(this string value)
    {
        var result =
          $"{value}\n";

        return result ;
    }

    public static int ToInt(this string value)
    {
        var result = 
            int.Parse(value);

        return result;
    }
}
