using System.Numerics;

int[] vector1 = new int[5];
int[] vector2 = new int[5];
int[] vectorsuma = new int[5];
Console.WriteLine("Por favor ingrese los valores del primer vector: ");
for (int i = 0; i < vector1.Length; i++)
{
    try
    {
        Console.WriteLine($"Valor {i + 1}: ");
        vector1[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida, Por favor ingrese un numero entero.");
        i--; //Decrementar el indice para volver a solicitar el valor
        Console.ResetColor();
    }
}


Console.WriteLine("Por favor ingrese los valores del segundo vector: ");
for(int i = 0; i < vector2.Length; i ++)
{
    try
    {
        Console.WriteLine($"Valor {i + 1}: ");
        vector2[i]= int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida, Por favor ingrese un numero entero.");
        i--;
        Console.ResetColor();
    }
}

//Sumar los vectores
for (int i = 0; i < vectorsuma.Length; i++)
{
    vectorsuma[i] = vector1[i] + vector2[i];
}

//Mostrar arreglo resultante
Console.WriteLine($"Suma de los vectores: ");
for (int i = 0; i < vectorsuma.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Posición {i + 1}: {vectorsuma[i]}");
    Console.ResetColor();
}
