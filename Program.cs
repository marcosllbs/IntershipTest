
class Program
{
    static void Main(string[] args)
    {
        TestLogics test = new TestLogics();
        bool isRuning = true;
        while (isRuning)
        {

            Console.WriteLine("Para resolução do exercicio 1 (Sequência de Fibonacci), digite 1!");
            Console.WriteLine("Para resolução do exercicio 2 (Contador de 'A' em uma string), digite 2!");
            Console.WriteLine("Para resolução do exercicio 3 digite 3!");
            Console.WriteLine("Para sair digite 4!");


            int.TryParse(Console.ReadLine(), out int option);

            switch (option)
            {
                case 1:
                    int selectedNumber = GetInput("Digite um numero para checar sequencia de Fibonacci!");

                    if (test.FibonacciSequence(selectedNumber))
                        Console.WriteLine("O numero pertence a sequencia!");
                    else
                        Console.WriteLine("O numero NÃO pertence a sequencia!");
                    break;
                case 2:
                    Console.WriteLine("Digite uma frase para contarmos os'As'");
                    string? frase = Console.ReadLine();
                    test.CountNumberOfAInString(frase);
                    break;
                case 3:
                    test.ResolveFor();
                    break;
                case 4:
                    isRuning = false;
                    break;
            }
        }
    }

    public static int GetInput(string message)
    {
        Console.WriteLine(message);
        int.TryParse(Console.ReadLine(), out int value);
        return value;
    }
}