/*
    NIVEL 1 — if
    Ejercicio 1 — Mayor de edad
    Pide la edad de una persona.
    Si tiene 18 años o más, muestra:
    Es mayor de edad
*/

Console.Write("Introduce tu edad:"); //manda un mensaje
int? edad =  int.Parse(Console.ReadLine()); //recoge el nombre

if (edad >= 18)
{
    Console.WriteLine("Es mayor de edad.");
}
else
{
    Console.WriteLine("No es mayor de edad.");
}