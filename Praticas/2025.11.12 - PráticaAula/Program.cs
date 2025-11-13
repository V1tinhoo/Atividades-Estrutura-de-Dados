List<string> lista = new List<string>() { "João", "Pedro","Marcos","Valentina" };

Console.WriteLine("Digite um nome:");
string? nome = Console.ReadLine();
bool encontrado = false;

if (nome != null)
{
    for (int i = 0; i < lista.Count(); i++)
    {
        if (nome.ToUpper().CompareTo(lista[i].ToUpper()) == 0)
        {
            Console.WriteLine("Nome encontra-se na posição: " + i);
            encontrado = true;
            break;
        }
    }
}

if (!encontrado)
{
    Console.WriteLine("Não encontrado");
}
