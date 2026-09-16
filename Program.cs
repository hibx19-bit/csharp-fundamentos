
/*
    NIVEL 1 — if
    Ejercicio 1 — Mayor de edad
    Pide la edad de una persona.
    Si tiene 18 años o más, muestra:
    Es mayor de edad
*/

Console.Write("Introduce tu edad:"); //manda un mensaje
int? edad =  int.Parse(Console.ReadLine()!); //recoge el nombre

if (edad >= 18)
{
    Console.WriteLine("Es mayor de edad.");
}
else
{
    Console.WriteLine("No es mayor de edad.");
}
    //*Ejercicio 2 — 
    // Número positivo 
    // Pide un número entero.Comprueba si es mayor que 0.

Console.Write("Introduce un número entero:"); 
int? numero = int.Parse(Console.ReadLine()!);

if (numero > 0)
{
    Console.WriteLine("El número es positivo.");
}
else
{
    Console.WriteLine("El número no es positivo.");
}

    // Ejercicio 4 — Temperatura
    // Pide una temperatura.
    // Si es superior a 30 grados, muestra:
    // Hace calor

Console.Write("Introduce la temperatura:");
int? temperatura = int.Parse(Console.ReadLine()!);

if (temperatura > 30)
{
    Console.WriteLine("Hace calor.");
}
