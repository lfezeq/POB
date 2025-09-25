using System;

class Produkt
{
    public string Nazwa { get; set; }
    public double Cena { get; set; }
    public void PokazProdukt()
    {
        Console.WriteLine(Nazwa , Cena);
    }
}

class Ksiazka : Produkt
{
    public string Autor { get; set; }

    public void PokazAutora()
    {
        Console.WriteLine(Autor);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Ksiazka ksiazka = new Ksiazka();
        ksiazka.Autor = "Adam Mickiewicz";
        ksiazka.Nazwa = "Pan Tadeusz";
        ksiazka.Cena = 55.00;
        ksiazka.PokazProdukt();
        ksiazka.PokazAutora();
        if (ksiazka.Cena > 50)
        {
            Console.WriteLine("Ksiazka jest droga");
        }
        else
        {
            Console.WriteLine("Ksiazka jest tania");
        }

    }
}
