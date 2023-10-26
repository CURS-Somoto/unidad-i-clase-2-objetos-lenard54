
// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.Contracts;

public class Guerrero
{
    public int vida{ get; set; }
    public int nivelAtaque{ get; set; }
    public string nombre{ get; set; }

    public Guerrero(int vida, int nivelAtaque, string nombre)
    {
        this.vida = vida;
        this.nivelAtaque = nivelAtaque;
        this.nombre = nombre;
    }

    public int Ataque()
    {
        return this.nivelAtaque;
    }

    public void RecibeAtaque(int ataque)
    {
        this.vida -= ataque;
    }
}

public class Enfrentamiento
{
    public void Iniciar(Guerrero guerrero1, Guerrero guerrero2)
    {
        string valor;
        Console.WriteLine($"Comienza el enfrentamiento entre {guerrero1.nombre} y {guerrero2.nombre}!");
        while (guerrero1.vida > 0 && guerrero2.vida > 0)
        {
            //Para controlar el progreso del combate
            System.Console.WriteLine("Eliga quien va a atacar con 1 o 2.");
            System.Console.WriteLine($"1: {guerrero1.nombre}");
            System.Console.WriteLine($"2: {guerrero2.nombre}");
            valor = Console.ReadLine();
            int valor2 = int.Parse(valor);

            if ( valor2 == 1)
            {
                int ataqueGuerrero1 = guerrero1.Ataque();
                guerrero2.RecibeAtaque(ataqueGuerrero1);
                Console.WriteLine($"{guerrero1.nombre} ataca a {guerrero2.nombre} y le hace {ataqueGuerrero1} puntos de daño. Ahora a {guerrero2.nombre} le quedan {guerrero2.vida} puntos de vida restante.");

                 if (guerrero2.vida <= 0)
            {
                Console.WriteLine($"{guerrero1.nombre} ha ganado el enfrentamiento!");
                Console.ReadKey();
                break;
            }
            }
            else if (valor2 == 2)
            {
                int ataqueGuerrero2 = guerrero2.Ataque();
                guerrero1.RecibeAtaque(ataqueGuerrero2);
                Console.WriteLine($"{guerrero2.nombre} ataca a {guerrero1.nombre} y le hace {ataqueGuerrero2} puntos de daño. Ahora a {guerrero1.nombre} le quedan {guerrero1.vida} puntos de vida restante.");
                
                if (guerrero1.vida <= 0)
            {
                Console.WriteLine($"{guerrero2.nombre} ha ganado el enfrentamiento!");
                Console.ReadKey();
                break;
            }
            }
            else
            {
                throw new ArgumentOutOfRangeException("Solo se admiten los valores 1 y 2");
            }
            
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Guerrero guerrero1 = new Guerrero(100, 20, "Leonel");
        Guerrero guerrero2 = new Guerrero(120, 15, "Ramon");

        Enfrentamiento enfrentamiento = new Enfrentamiento();
        enfrentamiento.Iniciar(guerrero1, guerrero2);
    }
}
