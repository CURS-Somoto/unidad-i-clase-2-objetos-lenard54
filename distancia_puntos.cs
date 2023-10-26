
// See https://aka.ms/new-console-template for more information
using System;

public class Punto
{
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }

    // Constructor para el plano bidimensional
    public Punto(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Constructor para el plano tridimensional
    public Punto(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    // Método para medir la distancia en el plano bidimensional
    public double MedirDistancia(Punto destino)
    {
        double distancia = (double)Math.Sqrt(Math.Pow((double)(destino.x - this.x), 2) + Math.Pow((double)(destino.y - this.y), 2));
        return distancia;
    }

    // Método para medir la distancia en el espacio tridimensional
    public double MedirDistancia3D(Punto destino)
    {
       double distancia = (double)Math.Sqrt(Math.Pow((double)(destino.x - this.x), 2) + Math.Pow((double)(destino.y - this.y), 2) + Math.Pow((double)(destino.z - this.z), 2));
        return distancia;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Puntos en el plano bidimensional
        Punto puntoOrigen2D = new Punto(3, 4);
        Punto puntoDestino2D = new Punto(6, 8);

        double distancia2D = puntoOrigen2D.MedirDistancia(puntoDestino2D);
        Console.WriteLine($"La distancia entre los puntos en 2D es: {distancia2D}");

        // Puntos en el espacio tridimensional
        Punto puntoOrigen3D = new Punto(1, 2, 3);
        Punto puntoDestino3D = new Punto(4, 5, 6);

        double distancia3D = puntoOrigen3D.MedirDistancia3D(puntoDestino3D);
        Console.WriteLine($"La distancia entre los puntos en 3D es: {distancia3D}");
        Console.ReadKey();
    }
}
