// For
/*int numero = 5;

for(int contador = 1; contador <=10; contador++)
{
Console.WriteLine($"{numero}x{contador} = {numero * contador}");
}*/

//Foreach
/*List<int> fibNumbers = [0, 1, 1, 2, 3, 5, 8, 13];
foreach (int element in fibNumbers)
{
    Console.Write($"{element} ");
}
// Output:
// 0 1 1 2 3 5 8 13*/

// While
/*int numero =5;
int contador = 1;

while(contador <=10)
{
    Console.WriteLine($"{contador} Execução: {numero} x {contador} = {numero * contador}");
    contador++;
}*/

// Do while
/*int soma = 0, numero = 0;
do
{
    Console.WriteLine("Digite números para somar e 0 para sair");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

}while(numero != 0);
Console.WriteLine($"Total da somma é :{soma}");*/

// While Menu
/*string opcao;
        bool exibirMenu = true;
        while(exibirMenu)
        {
        Console.WriteLine("Digite a opção:");
        Console.WriteLine("1 -> Cadastro");
        Console.WriteLine("2 -> Pesquisa");
        Console.WriteLine("3 -> Apagar registro");
        Console.WriteLine("4 -> Encerrar");

        opcao = Console.ReadLine();

        switch (opcao)
        {
        case "1":
        Console.Clear();
        Console.WriteLine("Cadastro");
        break;
        case "2":
        Console.Clear();
        Console.WriteLine("Pesquisa");
        break;
        case "3":
        Console.Clear();
        Console.WriteLine("Apagar registro");
        break;
        case "4":
        Console.Clear();
        Console.WriteLine("Encerrar");
        exibirMenu = false;
        break;

        default:
        Console.WriteLine("Opção inválida");
        break;
        }

        }

        Console.WriteLine("Finalizando Aplicação");*/
