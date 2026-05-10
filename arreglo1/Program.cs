<<<<<<< HEAD
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
=======
﻿/* Almacenar 10 edades en un arreglo. luego calcular el promedio de edades, el maximo y el minimo. */
//Crear arreglo de edades
int[] edades = new int[10];

//Pedir edades
for (int i = 0; i < edades.Length; i++)
{
    try
    {
         Console.WriteLine($"Digita la edad " + (i + 1) + ":");
         edades[i] = int.Parse(Console.ReadLine());
    }
    catch
    {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error: Por favor ingresa un número válido.");
    i--; //reintentar la misma posicion
    Console.ResetColor();
    }
}

//Calcular promedio, maximo y minimo
int suma = 0, maximo = edades[0], minimo = edades[0];

foreach (int edad in edades)
{
    suma += edad;
    if(edad > maximo)
    maximo = edad;
    if(edad < minimo)
    minimo = edad;
}

double promedio = (double)suma / edades.Length;

//Mostrar resultados
Console.WriteLine($"El promedio de edades es: {promedio}");
Console.WriteLine($"La edad máxima es: {maximo}");
Console.WriteLine($"La edad mínima es: {minimo}");
>>>>>>> af2796e (feat: add proyecto arreglo1)
