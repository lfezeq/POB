using System;

class UrzadzenieElektroniczne
{
    public string Producent;
    public string Model;

    public UrzadzenieElektroniczne(string producent, string model)
    {
        Producent = producent;
        Model = model;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine("Producent: " + Producent);
        Console.WriteLine("Model: " + Model);
    }
}

class Laptop : UrzadzenieElektroniczne
{
    public double RozmiarEkranu;

    public Laptop(string producent, string model, double rozmiarEkranu)
        : base(producent, model)
    {
        RozmiarEkranu = rozmiarEkranu;
    }

    public new void WyswietlInformacje()
    {
        base.WyswietlInformacje();
        Console.WriteLine("Rozmiar ekranu: " + RozmiarEkranu + " cali");
    }
}
class Program
{
    static void Main()
    {
        Laptop laptop = new Laptop("Dell", "XPS 13", 13);
        laptop.WyswietlInformacje();
    }
}
