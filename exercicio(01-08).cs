using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Título do programa.
        Console.WriteLine("------- Sorteio -------");

        // Cria uma instância para o gerador de números.
        Random numRandom = new Random();

        // Cria um numero aleatorio entre 0 e 10.
        int numeroSorteio = numRandom.Next(1, 10);

        // Variavel para guardar numero do usuario.
        int numeroUsuario = 0;

        // While cria um loop de 3 rodadas
        int i = 0;
        while (i < 3)
        {
            // Espera um número do usuário.
            Console.Write("Digite um numero de 1 a 10: ");
            try
            {
                numeroUsuario = int.Parse(Console.ReadLine());

                // Condição para numeros invalidos.
                if (numeroUsuario > 10)
                {
                    Console.WriteLine("Numero invalido");
                    break;
                }

                // Condição de acerto.
                else if (numeroUsuario == numeroSorteio)
                {
                    Console.WriteLine("Voce acertou!");
                    break;
                }

                else if (i < 2)
                {
                    Console.WriteLine("Voce errou! Tente novamente");
                }
                i++;
            }
            catch (FormatException)
            {
                Console.WriteLine("Apenas numeros!");
            }
        }
        
        // Condição de erro.
        if (numeroUsuario != numeroSorteio && numeroUsuario <= 10)
        {
            Console.WriteLine($"Voce errou! O numero sorteado foi {numeroSorteio}.");
        }
    }
}
