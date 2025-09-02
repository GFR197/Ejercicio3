using System; 

class Program // Definición de la clase principal
{
    static void Main(string[] args)
    {
        int[] Arreglo = { 100, 200, 300, 400, 500 };
        Console.Write($"Los numeros del arreglo son: ");

        for (int i = 0; i < 5; i++)
        {
            Console.Write(Arreglo[i]);

        }

    }
}
