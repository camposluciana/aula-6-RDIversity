// See https://aka.ms/new-console-template for more information
Console.WriteLine("----Verificando os lados de Polígonos ----");
        Console.WriteLine("Digite o número de lados de um polígono regular: ");

        int numeroDeLados = int.Parse(Console.ReadLine());

        if (numeroDeLados == 3)
        {
            Console.WriteLine("O polígono é um triângulo!");
        }
        else if (numeroDeLados == 4)
        {
            Console.WriteLine("O polígono é um quadrado!");
        }
        else if (numeroDeLados == 5)
        {
            Console.WriteLine("O polígono é um pentágono!");
        }
        else
        {
            Console.WriteLine("Número de lados inválido.");
        }
    

