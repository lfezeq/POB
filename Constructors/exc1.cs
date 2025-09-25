using System;

class Produkt
{
    public string Nazwa;
    public double Cena;

    public Produkt(string nazwa, double cena)
    {
        Nazwa = nazwa;
        Cena = cena;
    }
}

class Napoj : Produkt
{
    public double Objetosc;

    public Napoj(string nazwa, double cena, double objetosc) : base(nazwa, cena)
    {
        Objetosc = objetosc;
    }
}

class Program
{
    static void Main()
    {
        Napoj napoj = new Napoj("Cola", 4.99, 0.5);
        Console.Write("nazwa : " + napoj.Nazwa + " cena : " + napoj.Cena + " objetosc :" + napoj.Objetosc);
    }
}
