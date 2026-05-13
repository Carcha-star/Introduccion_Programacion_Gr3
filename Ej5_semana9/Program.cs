Console.Clear();

double[] calificaciones = new double[8];

Console.WriteLine("=== CALIFICACIONES DE 8 ESTUDIANTES (0-100) ===");

for (int i = 0; i < 8; i++)
{
    Console.Write($"Estudiante {i + 1}: ");
    calificaciones[i] = double.Parse(Console.ReadLine());
}

double total = 0;
for (int i = 0; i < 8; i++)
{
    total += calificaciones[i];
}
double promedio = total / 8;

int reprobados = 0;
for (int i = 0; i < 8; i++)
{
    if (calificaciones[i] < 60)
        reprobados++;
}

Console.WriteLine("\n--- NOTAS APROBADAS (≥ 60) ---");
for (int i = 0; i < 8; i++)
{
    if (calificaciones[i] >= 60)
        Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]:F0}");
}
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"\nReprobados: {reprobados}");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Promedio general: {promedio:F1}");

Console.ReadKey();