Console.Clear();


int[] puntajes = new int[6];
Console.WriteLine("=== PUNTAJES DE VIDEOJUEGO ===");

for (int i = 0; i < 6; i++)
{
    Console.Write($"Puntaje {i + 1}: ");
    puntajes[i] = int.Parse(Console.ReadLine());
}

// Mostrar puntajes
Console.Write("Puntajes: ");
for (int i = 0; i < 6; i++)
{
    Console.Write(puntajes[i]);
    if (i < 5) Console.Write(", ");
}

// Máximo
int max = puntajes[0];
for (int i = 1; i < 6; i++)
{
    if (puntajes[i] > max) max = puntajes[i];
}
Console.WriteLine($"\nMáximo: {max}");

// Ordenados (menor a mayor)
Console.Write("Ordenados: ");
for (int i = 0; i < 6; i++)
{
    int min = i;
    for (int j = i + 1; j < 6; j++)
    {
        if (puntajes[j] < puntajes[min]) min = j;
    }
    int temp = puntajes[i];
    puntajes[i] = puntajes[min];
    puntajes[min] = temp;
    Console.Write(puntajes[i]);
    if (i < 5) Console.Write(", ");
}

// Mayores a 500
int mayores500 = 0;
for (int i = 0; i < 6; i++)
{
    if (puntajes[i] > 500) mayores500++;
}
Console.WriteLine($"\nMayores a 500: {mayores500}");


Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();


