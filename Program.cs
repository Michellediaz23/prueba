// See https://aka.ms/new-console-template for more information
using System;
using static ConsoleApp5.Automovil;

class Program
{
    static void Main(string[] args)
    {
        Automovil toyota = new Automovil("Toyota", "ABC123", "Corolla", "Rojo", 50, 10);
        Automovil honda = new Automovil("Honda", "DEF456", "Civic", "Azul", 40, 12);

        Console.WriteLine("Toyota:");
        Console.WriteLine($"  Puede conducir 100 km: {toyota.PuedeConducir(100)}");
        toyota.Conducir(50);
        Console.WriteLine($"  Nivel de combustible: {toyota.NivelCombustible} galones");
        toyota.ReabastecerCombustible(20);
        Console.WriteLine($"  Nivel de combustible: {toyota.NivelCombustible} galones");

        Console.WriteLine("Honda:");
        Console.WriteLine($"  Puede conducir 150 km: {honda.PuedeConducir(150)}");
        honda.Conducir(100);
        Console.WriteLine($"  Nivel de combustible: {honda.NivelCombustible} galones");
        honda.ReabastecerCombustible(30);
        Console.WriteLine($"  Nivel de combustible: {honda.NivelCombustible} galones");
    }
}