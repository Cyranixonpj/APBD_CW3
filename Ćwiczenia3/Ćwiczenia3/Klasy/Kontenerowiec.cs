using Ćwiczenia3.Klasy;

public class Kontenerowiec()
{
    private int _maxPredkosc = 100;

    private int maxLiczbaKontenerow = 10;

    private int maxLacznaWaga = 1000;

    private int obecnaWaga = 0;

    private List<Kontener> konteneryNaStatku = new List<Kontener>();

    

    

    public void Zaladunek(Kontener kontener)
    {
        
        if(kontener.MasaLadunku+kontener.WagaWlasna+obecnaWaga < maxLacznaWaga && konteneryNaStatku.Count()<maxLiczbaKontenerow)
        {
            konteneryNaStatku.Add(kontener);
            obecnaWaga = obecnaWaga+  kontener.MasaLadunku + kontener.WagaWlasna;
        }
    }

    public void UsunKontener(Kontener kontenerDoUsuniecia)
    {
        if (konteneryNaStatku.Contains(kontenerDoUsuniecia))
        {
            konteneryNaStatku.Remove(kontenerDoUsuniecia);
            obecnaWaga = obecnaWaga - (kontenerDoUsuniecia.MasaLadunku + kontenerDoUsuniecia.WagaWlasna);
            Console.WriteLine($"Usunieto kontener: {kontenerDoUsuniecia}");

        }
        else
        {
            Console.WriteLine("nie ma takiego kontenera na statku");
        }
    }
    public void ZastapKontener(int idKontDozastapienia, Kontener nowyKontener)
    {
        if (konteneryNaStatku.Contains(konteneryNaStatku[idKontDozastapienia]))
        {
            konteneryNaStatku.Remove(konteneryNaStatku[idKontDozastapienia]);
            konteneryNaStatku.Add(nowyKontener);
        }
    }
    
    public void getInfo()
    {
        Console.WriteLine($"Waga kontenerowca: {obecnaWaga},\nLiczba kontenerów:{konteneryNaStatku.Count()}\nTypy Kontenerów wraz z ID: ");
        
        for (int i = 0; i < konteneryNaStatku.Count; i++)
        {
            Console.WriteLine( konteneryNaStatku[i].ToString());
        }
    }
                                                   



    







}
