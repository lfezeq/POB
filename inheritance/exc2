using System;
class Pojazd
{
    public string Marka;
    public int Predkosc;

    public void PokazDane()
    {
        Console.WriteLine(Marka);
        Console.WriteLine(Predkosc);
    }
}
class Samochod : Pojazd
{
    public int[] HistoriaPredkosci;
}

class Program
{
    static void Main(string[] args)
    {
        Samochod samochod = new Samochod();
        samochod.Marka = "Toyota";
        samochod.Predkosc = 90;
        samochod.HistoriaPredkosci = new int[] { 50, 60, 90, 120, 80 };
        Console.WriteLine("Historia prędkości");
        for (int i = 0; i < samochod.HistoriaPredkosci.Length; i++)
        {
            Console.WriteLine(samochod.HistoriaPredkosci[i]);
        }
        int max = int.MinValue;
        foreach (int predkosc in samochod.HistoriaPredkosci)
        {
            if (predkosc > max)
            {
                max = predkosc;
            }
        }
        Console.WriteLine("Największa predkosc: "+ max);
    }
}
