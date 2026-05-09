<<<<<<< HEAD
﻿//Crea un arreglo de notas de 15 estudiantes, luego calcula el promedio de las notas, y los 3 primeros lugares, no se puede ingresar notas menores a 0 ni mayores a 100.

int [] notas = new int[15];
int suma = 0;
double promedio = 0;
double contError = 0;

for(int i = 0; i < notas.Length; i++)
{
    if(contError >= 3)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Devolvete a primaria, y quedate alli");
        Console.ResetColor();
    }
    try
    {
        Console.WriteLine($"Ingrese la nota del estudiante {i + 1}: ");
        int nota = int.Parse(Console.ReadLine());

        if( nota < 0 || nota > 100)
        {
            throw new ArgumentOutOfRangeException("La nota debe ser entre o y 100 ");
        }

        notas[i] = nota;
        suma += nota;
    }
    catch(FormatException)
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--; // Decrementar para volver a pedir la nota del mismo estudiante
        contError++;
    }
    catch(ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
        i--; // Decrementar para volver a pedir la nota del mismo estudiante
        contError++;
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Ocurrió un error: {ex.Message}");
        i--; // Decrementar para volver a pedir la nota del mismo estudiante
        contError++;
    }
}
foreach (int nota in notas)
{
    
}
Console.WriteLine($"La suma de las notas es: {suma}");
Console.WriteLine("La cantidad de notas ingresadas es: " + notas.Length);

promedio = suma / notas.Length;

Console.WriteLine($"El promedio es de {promedio}");

Array.Sort(notas);
Array.Reverse(notas);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Cuadro de honor");

for(int i = 0; i < 3; i++)
{
    Console.WriteLine(notas{i});
}
=======
﻿//*Leer un numero entero y mostrar todos sus antecesores elevados al cubo*/

using Math = System.Math;

int numero;

while (true)
{
    Console.Write("Ingrese un numero entero: ");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no valida. Por favor, ingrese un numero entero: ");
        Console.ResetColor();
    }
}

Console.WriteLine("Los antecesores elevados al cubo son: ");
int contador = 0;
while (contador < numero)
{
    double cubo = Math.Pow(contador, 3);
    Console.WriteLine($"{contador} elevado al cubo = {cubo} ");
    contador++;
}
>>>>>>> e0580ebbe88bc46ce28420d3d459d47d942382e1
