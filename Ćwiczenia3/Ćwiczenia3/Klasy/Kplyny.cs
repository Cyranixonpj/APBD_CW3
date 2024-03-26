using Ćwiczenia3.Interfejsy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenia3.Klasy;


public class Kplyny(int masaLadunku, int wysokosc, int wagaWlasna,  int głębokość, int maxLadownosc,bool isHazard) : Kontener(masaLadunku, wysokosc, wagaWlasna, głębokość, maxLadownosc), IHazardNotifier
{


    public bool IsHazard { get; set; } = isHazard;

    private int _masaCal = 0; 


    public void NotifyHazard()
    {
        Console.WriteLine("Próba wykonania niebezpiecznej operacji!"); ;
    }

    public override void OproznienieLadunku()
    {
        _masaCal = WagaWlasna;
        Console.WriteLine("Oprozniono kontener");
    }

    public override void ZaladowanieKontenera()
    {
        if (isHazard && MasaLadunku<= MaxLadownosc/2)
        {
            _masaCal = WagaWlasna + MasaLadunku;
            Console.WriteLine("Pomyslnie zaladowano kontener do 50%");
        }
        else if(MasaLadunku < (MasaLadunku/MaxLadownosc)*90)
        {
            _masaCal = WagaWlasna + MasaLadunku;
            Console.WriteLine("Pomyslnie zaladowano kontener do 90%");
        }
        else
        {
            NotifyHazard();
        }
    }

    public override string ToString()
    {
        return $"KON-L-{Id}";
    }

}
