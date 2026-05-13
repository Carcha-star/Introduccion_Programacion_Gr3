Console.Clear();
int[] temps = new int[7];
int suma = 0;
int maximo = int.MinValue;
int minimo = int.MaxValue;

Console.WriteLine("=== TEMPERATURAS SEMANALES ===\n");

for (int i = 0; i < temps.Length; i++)
{
    bool entradaValida = false;

    while (!entradaValida)
    {
        try
        {
            Console.Write($"Temperatura del día #{i + 1} (en grados celsius): ");
            temps[i] = int.Parse(Console.ReadLine());
            entradaValida = true;
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Solo números enteros!");
            Console.ResetColor();
        }
    }
}

foreach (int temperatura in temps)
{
    suma += temperatura;
    if (temperatura > maximo) maximo = temperatura;
    if (temperatura < minimo) minimo = temperatura;
}

double promedio = (double)suma / temps.Length;

Console.WriteLine($"Promedio: {promedio:F1}°C");
Console.WriteLine($"Máxima:   {maximo}°C");
Console.WriteLine($"Mínima:   {minimo}°C");
