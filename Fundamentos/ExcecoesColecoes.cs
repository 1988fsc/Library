// Exceções e Coleções

// Bloco Try Catch
/*try
{

    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção {ex.Message}");
}
finally
{
    Console.WriteLine("Bloco Finally");
}*/

//Queue Adicionando e removendo na ordem de entrada fifo (first in first out
/*Queue<int>fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(25);
fila.Enqueue(242);
fila.Enqueue(2240);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento {fila.Dequeue()}");

foreach(int item in fila)
{
    Console.WriteLine(item);
}*/

//Stack (pilha) lifo (last in fisrt out)
/*Stack<int>pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(25);
pilha.Push(242);
pilha.Push(2240);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento {pilha.Pop()}");

foreach(int item in pilha)
{
    Console.WriteLine(item);
}*/

//Dictionary - inclusão, remoção validação
/*Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "Sao Paulo");
estados.Add("BH", "Bahia");
estados.Add("RS", "Rio Grande do Sul");
estados.Add("SC", "Santa Catarina");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Conteúdo: {item.Value}");
}
 Console.WriteLine("___________");


estados.Add("PR","Parana");
estados.Remove("BH");
estados["SP"] = "Sao Paulo mod";

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Conteúdo: {item.Value}");
}

Console.WriteLine("___________");

string chave= "exemplo";
Console.WriteLine($"Validando chave: {chave}");
if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não encontrado, é seguro incluir a chave: {chave}");
}

 Console.WriteLine(estados["RS"]);*/
