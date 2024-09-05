public class TestLogics
{

    public static bool FibonacciSequence(int number)
    {
        int previousFibonnaci = 0;
        int actualFibonnaci = 1;

        if (number == previousFibonnaci || number == actualFibonnaci)
        {
            return true;
        }

        while (previousFibonnaci < number)
        {
            int nextFibonnaci = previousFibonnaci + actualFibonnaci;
            previousFibonnaci = actualFibonnaci;
            actualFibonnaci = nextFibonnaci;

            if (actualFibonnaci == number)
            {
                return true;
            }
        }
        return false;
    }

    public static int CountNumberOfAInString(string frase)
    {
        int count = 0;

        foreach (char charactere in frase)
        {
            if (charactere == 'a' || charactere == 'A')
            {
                count++;
            }
        }

        return count;
    }

    public static void ResolveFor()
    {
        int soma = 0;
        int K = 1;
        for (int i = 12; K < i; i--)
        {

        }

    }

}