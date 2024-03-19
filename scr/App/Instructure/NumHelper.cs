namespace App.Instructure;

public static class NumHelper : object
{
    public static bool IsOddNumber(this int value)
    {
        return value % 1 == 0;
    }

    public static bool IsEvenNumber(this int value)
    {
        return value % 2 == 0;
    }
}
