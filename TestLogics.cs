public class TestLogics
{

    public bool FibonacciSequence(int number)
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

    public void CountNumberOfAInString(string? frase)
    {
        int count = 0;
        if (!string.IsNullOrEmpty(frase))
        {
            foreach (char charactere in frase)
            {
                if (charactere == 'a' || charactere == 'A')
                {
                    count++;
                }
            }
        }

        Console.WriteLine($"O numero de 'As' é: {count}");
    }

    public void ResolveFor()
    {
        int index = 12;
        int soma = 0;
        int K = 1;
        while (K < index)
        {
            K++;
            soma = soma + K;
        }

        Console.WriteLine($"O valor de SOMA do exercicio numero 3 é: {soma}");
    }

}