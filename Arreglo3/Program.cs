Console.Clear();
Console.Write("¿Cuántos elementos tendrá el vector? ");
int tamano = int.Parse(Console.ReadLine());


int[] vector = new int[tamano];


Console.WriteLine("\nIngresa los elementos del vector:");
for (int i = 0; i < tamano; i++)
{
    Console.Write($"Elemento {i + 1}: ");
    vector[i] = int.Parse(Console.ReadLine());
}


Console.WriteLine("\nVector ingresado: ");
foreach (int num in vector)
{
    Console.Write(num + " ");
}
Console.WriteLine();

int sumaCuadrados = 0;


Console.WriteLine("\nCálculo paso a paso:");
for (int i = 0; i < vector.Length; i++)
{
    
    int cuadrado = vector[i] * vector[i];

    
    Console.WriteLine($"Elemento {i + 1}: {vector[i]}² = {cuadrado}");

   
    sumaCuadrados += cuadrado;
}


double magnitud = Math.Sqrt(sumaCuadrados);


Console.WriteLine($"\n{'=',50}");
Console.WriteLine($"Suma de cuadrados: {sumaCuadrados}");
Console.WriteLine($"MAGNITUD del vector: {magnitud:F2}");
Console.WriteLine($"\n¡Listo! La magnitud es {magnitud:F2}");

