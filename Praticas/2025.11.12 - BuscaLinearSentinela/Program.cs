int [] numeros = { 10, 20, 180, 30, 60, 50, 110, 100, 70 };
int keyInt = 180;
SentinelSearch(numeros, numeros.Length, keyInt);

string[] nomes = { "Ana", "Bruno", "Carlos", "Diana", };
string keyString = "Carlos";
SentinelSearch(nomes, nomes.Length, keyString);

static void SentinelSearch<T>(T[] arr, int n, T key)
{
    // Guardar o Ultimo Elemento
    T last = arr[n - 1];

    // Coloca o elemnto a ser buscado na ultima posição
    arr[n - 1] = key;
    int i = 0;

    // Busca até encontrar o Valor
    while (!EqualityComparer<T>.Default.Equals(arr[i], key))
    i++;

    // Restaura o ultimo Elemento Original
    arr[n - 1] = last;

    //verifica se encontrou dentro da faixa valida
    if (i < n - 1 || EqualityComparer<T>.Default.Equals(arr[n - 1], key))
        Console.WriteLine($"{key} está presente no indice {1}");
    
    else
        Console.WriteLine("Elemento não encontrado");
}