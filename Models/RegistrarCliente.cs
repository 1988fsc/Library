//Programa solicita Nome, email depois telefone, coloca em uma lista e quando digitado N exibe toda a lista e sai


/*using System;
using System.Collections.Generic;
using System.Xml.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<string> clientes = new List<string>();

        while (true)
        {
            Console.WriteLine("Insira o nome do cliente");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira o email do cliente");
            string email = Console.ReadLine();
            Console.WriteLine("Insira o telefone do cliente");
            string telefone = Console.ReadLine();

            // Registra o cliente (simulação)
            string clienteInfo = $"{nome}, {email}, {telefone}";
            clientes.Add(clienteInfo);
            Console.WriteLine(clienteInfo);
            Console.ReadLine();
            Console.WriteLine("Digite (N) para sair, ou outra telca para continuar:");
            string continuar = Console.ReadLine();



            // TODO: Adicione uma condição para verificar se o usuário deseja continuar registrando mais clientes e, se desejar, continuar o loop para coletar mais informações.

            if (continuar == "N")
            {
                foreach (string cliente in clientes)
                {
                    Console.WriteLine($"{cliente} ");
                }
                break;
            }
            else
            {
                continue;
            }
        }

    }
}*/