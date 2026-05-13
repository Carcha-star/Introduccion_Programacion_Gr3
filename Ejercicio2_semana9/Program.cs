Console.Clear();
int contador = 0;
int[] montos = new int[7];
int sumaTotal = 0;
int maximo = int.MinValue;
int minimo = int.MaxValue;



for (int i = 0; i < montos.Length; i++)  // 0 a 6
{
    bool entradaValida = false;

    while (!entradaValida)
    {
        try
        {
            Console.Write($"Monto día #{i + 1}: ");
            montos[i] = int.Parse(Console.ReadLine());
            sumaTotal += montos[i];

            entradaValida = true;
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Solo números enteros!");
            Console.ResetColor();
        }
    }


    if (montos[i] > 150) contador++;
}


foreach (int monto in montos)
{
    if (monto > maximo) maximo = monto;
    if (monto < minimo) minimo = monto;
}

double promedio = (double)sumaTotal / montos.Length;

Console.WriteLine($"Total ventas: {sumaTotal:C}");
Console.WriteLine($"Promedio: {promedio:C}");
Console.WriteLine($"Máximo: {maximo:C}");
Console.WriteLine($"Mínimo: {minimo:C}");
Console.WriteLine($"Días > 150: {contador}");

for (int i = 0; i < montos.Length; i++)
{
    Console.WriteLine($"Día {i + 1}: {montos[i]:C}");
}