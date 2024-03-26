using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ćwiczenia3.Klasy;

Kontenerowiec kontenerowiec = new Kontenerowiec();
Kontenerowiec kontenerowiec1 = new Kontenerowiec();

Kplyny kon6 = new Kplyny(40, 20, 30, 20, 100, true);
Kplyny kon7 = new Kplyny(40, 20, 30, 20, 100, true);
Kplyny kon8 = new Kplyny(40, 20, 30, 20, 100, true);
kon6.ZaladowanieKontenera();
kon7.ZaladowanieKontenera();
kon8.ZaladowanieKontenera();

//Dodawanie listy kontenerów do kontenerowca
List<Kontener> listaKon = [kon6, kon7, kon8];

kontenerowiec1.Zaladunek(listaKon);
kontenerowiec1.GetInfo();


Kchłodniczy kon1 = new Kchłodniczy(30, 50, 10, 20, 50, "Banany",14);
Kgaz kon2 = new Kgaz(100, 20, 40, 10, 80, 5);
Kplyny kon3 = new Kplyny(40, 20, 30, 20, 100, true);
Kplyny kon4 = new Kplyny(100, 20, 30, 10, 70, true);
Kplyny kon5 = new Kplyny(40, 20, 30, 20, 100, true);
kon3.ZaladowanieKontenera();
kon1.ZaladowanieKontenera();
kon4.ZaladowanieKontenera();

//kon2.ZaladowanieKontenera(); //Sprowokowanie wyjątku OverfillException

//Dodawanie kontenerów do kontenerowca 
kontenerowiec.Zaladunek(kon1);
kontenerowiec.Zaladunek(kon3);
//Zastąpienie kontenera innym 
kontenerowiec.ZastapKontener(0, kon5);
//Wyswietlenie informacji o kontenerowcu 
kontenerowiec.GetInfo();
//Usuwanie kontenera
//kontenerowiec1.UsunKontener(0);
//Zamiana kontenerow na statkach

kontenerowiec.PrzeniesKontener(kontenerowiec1, 5);


