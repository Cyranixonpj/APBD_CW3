using Ćwiczenia3.Interfejsy;
using Ćwiczenia3.Wyjątki;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace Ćwiczenia3.Klasy;




public abstract class Kontener(int masaLadunku, int wysokosc, int wagaWlasna, int głębokość, int maxLadownosc)
{

    private static int _numer = 0;

    public int Id { get; } = _numer++;
    public int MasaLadunku { get; private set; } = masaLadunku;
    public int Wysokosc { get; private set; } = wysokosc;
    public int WagaWlasna { get; private set; } = wagaWlasna;

    public int Głębokość { get; private set; } = głębokość;

    public int MaxLadownosc { get; set; } = maxLadownosc;

    


    public abstract void  OproznienieLadunku();


    public abstract void ZaladowanieKontenera();

    public override string ToString()
    {
        return $"ID: {Id}";
    }



}
