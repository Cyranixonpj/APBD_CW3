using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ćwiczenia3.Klasy;




public abstract class Kontener(int masaLadunku, int wysokosc,int wagaWlasna , string typ) 
{
    
    private static int _numer = 0;

    public int Id { get; } = _numer++;
    public string Typ { get; private set; } = typ;
    public int Masa { get; private set; } = masaLadunku;
    public int Wysokosc { get; private set; } = wysokosc;
    public int WagaWlasna { get; private set; } = wagaWlasna;


    




}
