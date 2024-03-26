using Ćwiczenia3.Interfejsy;
using Ćwiczenia3.Klasy;
using Ćwiczenia3.Wyjątki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kgaz(int masaLadunku, int wysokosc, int wagaWlasna, int głębokość, int maxLadownosc,int cisnienie) : Kontener(masaLadunku, wysokosc, wagaWlasna, głębokość, maxLadownosc),IHazardNotifier
{

    public int Cisnienie { get; set; } = cisnienie;

    private int _masaCalosci = 0;

    public void NotifyHazard()
    {
        Console.WriteLine($"Niebiezpieczne zdarzenie w kontenerze nr: {Id}");
    }

    public override void OproznienieLadunku()
    {
        _masaCalosci = (MasaLadunku / MaxLadownosc) * 5;
    }

    public override void ZaladowanieKontenera()
    {
        if(MasaLadunku+WagaWlasna> MaxLadownosc)
        {
            throw new OverfillException();
        }
    }
    public override string ToString()
    {
        return $"KON-G-{Id}";
    }
}