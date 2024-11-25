using System;
using System.Text.RegularExpressions;

public class Vehiculo
{
    private string marca;
    private int anio;

    // Constructor de la clase base 
    public Vehiculo(string marca, int anio)
    {
        this.marca = marca;
        this.anio = anio;
        Console.WriteLine($"Constructor de Vehiculo: Marca = {marca}, Año = {anio}");
    }

    // Método virtual que puede ser sobrescrito 
    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Vehiculo: Marca = {marca}, Año = {anio}");
    }
}//fin clase 

public class Automovil : Vehiculo
{
    private int numPuertas;
    private string tipoCombustible;

    // Constructor de la clase derivada que llama al constructor base 
    public Automovil(string marca, int anio, int numPuertas, string tipoCombustible)
    : base(marca, anio)
    {
        this.numPuertas = numPuertas;
        this.tipoCombustible = tipoCombustible;
        Console.WriteLine($"Constructor de Automovil: Puertas = {numPuertas}, Combustible = {tipoCombustible}");
    }

    // Sobrescritura del método MostrarInfo
    public override void MostrarInfo()
    {
        base.MostrarInfo(); // Llamando al método de la clase base
        Console.WriteLine($"Automovil: Puertas = {numPuertas}, Combustible = {tipoCombustible}");
    }
}//fin clase

public class Deportivo : Automovil
{
        private double velocidadMaxima;
        private bool turbo;

        // Constructor de la clase más derivada que también llama a sus predecesores 
        public Deportivo(string marca, int anio, int numPuertas, string tipoCombustible, double velocidadMaxima, bool turbo)
        : base(marca, anio, numPuertas, tipoCombustible) // Llamando al constructor de Automovil
        {
            this.velocidadMaxima = velocidadMaxima;
            this.turbo = turbo;
            Console.WriteLine($"Constructor de Deportivo: Velocidad Máxima = {velocidadMaxima} km/h, Turbo = {turbo}");
        }

        // Sobrescritura del método MostrarInfo 
        public override void MostrarInfo()
        {
            base.MostrarInfo(); // Llamando al método de la clase derivada
            Console.WriteLine($"Deportivo: Velocidad Máxima = {velocidadMaxima} km/h, Turbo = {turbo}");
        }

}//fin clase 

class Program
{
    static void Main()
    {
        Console.WriteLine("Luis Angel Baltazar Gonzalez");
        // Creando un objeto de la clase Deportivo 
        Deportivo miDeportivo = new Deportivo("BMW", 2024, 2, "Gasolina", 300.0, true);

        // Mostrando la información usando el método sobrescrito 
        miDeportivo.MostrarInfo();

        //Completar creando otro objeto del tipo de la clase Deportivo y mostrar informacion  
        // usando el método sobrescrito < ------------------------------------------------ 
        Deportivo otroDeportivo = new Deportivo("Ferrari", 1994, 2, "Gasolina", 320.0, true);
        otroDeportivo.MostrarInfo();

        //Completar creando otro objeto del tipo de la clase Automóvil y mostrar informacion  
        // usando el método sobrescrito < ------------------------------------------------ 
        Automovil miAutomovil = new Automovil("Mercedes", 2022, 4, "Hibrido");
        miAutomovil.MostrarInfo();

        //Completar creando otro objeto del tipo de la clase Vehículo 
        // y mostrar informacion   < ------------------------------------------------ 
        Vehiculo miVehiculo = new Vehiculo("Toyota", 2020);
        miVehiculo.MostrarInfo();

    }
}//fin clase 