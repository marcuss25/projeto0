using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem Vindo!");
        Console.ReadKey();
        Console.WriteLine("Esse é um código onde você consegue trocar a cor do texto.");
        Console.ReadKey();
        Console.WriteLine("Digite 'azul' para o texto ficar azul.");
        Console.WriteLine("Ou digite 'sair' se quiser sair.");
        string corTexto = Console.ReadLine();
        if (corTexto.ToLower() == "sair")
        {
            Console.WriteLine("Programa Encerrado");
            return;
        }
        else if (corTexto == "azul")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Viu? O texto ficou azul.");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("O que você digitou não existe ou não está disponivél.");
            return;
        }

        Console.ReadKey();

        int opcao = -1;
        while (opcao != 0)
        {
            Console.WriteLine("Agora tente com outras cores.");
            Console.WriteLine("Menu: 1-Azul | 2-Verde | 3-Vermelho | 4-Amarelo | 5-Roxo | 0-Sair");
            Console.Write("");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("O texto ficou azul.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                   Console.ForegroundColor = ConsoleColor.Green;
                   Console.WriteLine("O texto ficou verde.");
                   Console.ReadKey();
                   Console.Clear();
                   break;
                case 3:
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("O texto ficou vermelho.");
                   Console.ReadKey();
                   Console.Clear();
                   break;
                case 4:
                   Console.ForegroundColor = ConsoleColor.Yellow;
                   Console.WriteLine("O texto ficou amarelo.");
                   Console.ReadKey();
                   Console.Clear();
                   break;
                case 5:
                   Console.ForegroundColor = ConsoleColor.Magenta;
                   Console.WriteLine("O texto ficou roxo.");
                   Console.ReadKey();
                   Console.Clear();
                   break;
                case 0:
                   Console.ResetColor();
                   Console.WriteLine("Programa Encerrado");
                   return;
                default:
                   Console.WriteLine("Erro.");
                   return;
            }
        }
    }
}