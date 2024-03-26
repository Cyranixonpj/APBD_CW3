using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenia3.Klasy;

public class Kchłodniczy(int masaLadunku, int wysokosc, int wagaWlasna, int głębokość, int maxLadownosc,string rodzajProduktu,double temperatura) : Kontener(masaLadunku, wysokosc, wagaWlasna, głębokość, maxLadownosc)
{

    private readonly Dictionary<string,double> dostepneProdukty = new Dictionary<string, double>()
    {
        {"Banany", 13.3},
        {"Czekolada", 18.0},
        {"Ryby",2 },
        {"Mięso",-15 },
        {"Lody",-18 },
        {"Ser",7.2 },
        {"Masło",20.5 },
        {"Jajka",19 }
    };
    public string RodzajProduktu { get; set; } = rodzajProduktu;

    public double Temperatura { get; set; } = temperatura;

    private int _całaMasa;



    public override void OproznienieLadunku()
    {
        _całaMasa = WagaWlasna;
        Console.WriteLine("Oprozniono kontener");
    }

    public override void ZaladowanieKontenera()
    {
        if (dostepneProdukty.ContainsKey(RodzajProduktu) && Temperatura >= dostepneProdukty[RodzajProduktu]&& MasaLadunku<=MaxLadownosc)
        {
            Console.WriteLine($"Pomyslnie zaladowano kontener produktem: {RodzajProduktu}");
        }
    }
    public override string ToString()
    {
        return $"KON-C-{Id}";
    }
}
