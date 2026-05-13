Console.Clear();

string[] categorias = new string[5];
int[] ventas = new int[5];

Console.WriteLine("=== VENTAS DE 5 CATEGORÍAS ===");

for (int i = 0; i < 5; i++)
{
    Console.Write($"Categoría {i + 1}: ");
    categorias[i] = Console.ReadLine();
}

for (int i = 0; i < 5; i++)
{
    Console.Write($"{categorias[i]}: ");
    ventas[i] = int.Parse(Console.ReadLine());
}

int total = 0;
for (int i = 0; i < 5; i++)
{
    total += ventas[i];
}
double promedio = (double)total / 5;

int max = ventas[0];
int indiceMax = 0;
for (int i = 1; i < 5; i++)
{
    if (ventas[i] > max)
    {
        max = ventas[i];
        indiceMax = i;
    }
}

Console.WriteLine("\n--- RESUMEN ---");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{categorias[i]}: {ventas[i]}");
}

Console.WriteLine($"\nTotal: {total}");
Console.WriteLine($"Más vendida: {categorias[indiceMax]} ({max})");
Console.WriteLine($"Promedio: {promedio:F1}");

Console.ReadKey();
