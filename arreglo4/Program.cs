Console.Clear();
Console.WriteLine("=== PRODUCTO ESCALAR DE VECTORES ===");

Console.Write("¿Cuántos elementos tendrán los vectores? ");
int tamanio = int.Parse(Console.ReadLine());

int[] vector1 = new int[tamanio];
int[] vector2 = new int[tamanio];


Console.WriteLine("\n--- VECTOR 1 ---");
for (int i = 0; i < tamanio; i++)
{
    Console.Write($"Elemento {i + 1}: ");
    vector1[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\n--- VECTOR 2 ---");
for (int i = 0; i < tamanio; i++)
{
    Console.Write($"Elemento {i + 1}: ");
    vector2[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nVectores ingresados:");
Console.Write("Vector 1: ");
foreach (int num in vector1) Console.Write(num + " ");

Console.Write("\nVector 2: ");
foreach (int num in vector2) Console.Write(num + " ");
Console.WriteLine();

int productoEscalar = 0;
Console.WriteLine("\n--- CÁLCULO PASO A PASO ---");

for (int i = 0; i < tamanio; i++)
{
    int multiplicacion = vector1[i] * vector2[i];

    Console.WriteLine($"Posición {i + 1}: {vector1[i]} × {vector2[i]} = {multiplicacion}");

    productoEscalar += multiplicacion;
}

Console.WriteLine($"\n{'=',50}");
Console.WriteLine($"PRODUCTO ESCALAR = {productoEscalar}");
Console.WriteLine($"<{string.Join(", ", vector1)}> • <{string.Join(", ", vector2)}> = {productoEscalar}");

