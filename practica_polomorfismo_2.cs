using System;
using System.Collections.Generic;

public class Ave
{
    public string Nombre { get; set; }
    public string Color { get; set; }

    public Ave(string nombre, string color)
    {
        Nombre = nombre;
        Color = color;
    }

    public virtual void Volar()
    {
        Console.WriteLine($"{Nombre} está volando.");
    }

    public virtual void HacerSonido()
    {
        Console.WriteLine($"{Nombre} hace un sonido.");
    }
}

public class Aguila : Ave
{
    public Aguila(string nombre, string color) : base(nombre, color) { }

    public override void Volar()
    {
        Console.WriteLine($"{Nombre} vuela alto y rápido.");
    }

    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} grita fuertemente.");
    }
}

public class Pinguino : Ave
{
    public Pinguino(string nombre, string color) : base(nombre, color) { }

    public override void Volar()
    {
        Console.WriteLine($"{Nombre} no puede volar.");
    }

    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} hace un sonido suave.");
    }
}

public class Loro : Ave
{
    public Loro(string nombre, string color) : base(nombre, color) { }

    public override void Volar()
    {
        Console.WriteLine($"{Nombre} vuela de rama en rama.");
    }

    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} imita sonidos.");
    }
}

class Program
{
    static void Main()
    {
        List<Ave> aves = new List<Ave>();

        aves.Add(new Aguila("Águila", "Marrón"));
        aves.Add(new Pinguino("Pingüino", "Blanco y negro"));
        aves.Add(new Loro("Loro", "Verde"));

        foreach (Ave ave in aves)
        {
            ave.Volar();
            ave.HacerSonido();
            Console.WriteLine();
        }
    }
}