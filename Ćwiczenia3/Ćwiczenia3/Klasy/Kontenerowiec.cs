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
    public void Zaladunek(List<Kontener> kontenery)
    {
        
            for (int j = 0; j < kontenery.Count(); j++)
            {
                if (kontenery[j].MasaLadunku + kontenery[j].WagaWlasna + obecnaWaga < maxLacznaWaga && konteneryNaStatku.Count() + kontenery.Count() < maxLiczbaKontenerow)
                {
                    konteneryNaStatku.Add(kontenery[j]);
                    obecnaWaga = obecnaWaga + kontenery[j].MasaLadunku + kontenery[j].WagaWlasna;
                }
            }
        

    }

    public void UsunKontener(int id)
    {
        
        for(int i = 0; i < konteneryNaStatku.Count(); i++)
        {
            if (konteneryNaStatku[i].Id == id){
                konteneryNaStatku.Remove(konteneryNaStatku[i]);
                obecnaWaga = obecnaWaga - (konteneryNaStatku[i].MasaLadunku + konteneryNaStatku[i].WagaWlasna);
                Console.WriteLine($"Usunieto kontener: {konteneryNaStatku[i]}");
            }
        }
        
   
    }
    public void ZastapKontener(int idKontDozastapienia, Kontener nowyKontener)
    {
        if (konteneryNaStatku.Contains(konteneryNaStatku[idKontDozastapienia]))
        {
            konteneryNaStatku.Remove(konteneryNaStatku[idKontDozastapienia]);
            konteneryNaStatku.Add(nowyKontener);
            Console.WriteLine($"Zastąpiono kontener nr {idKontDozastapienia} kontenerem: {nowyKontener}");
        }
    }
    
    public void GetInfo()
    {
        Console.WriteLine($"Waga kontenerowca: {obecnaWaga},\nLiczba kontenerów:{konteneryNaStatku.Count()}\nTypy Kontenerów wraz z ID: ");
        
        for (int i = 0; i < konteneryNaStatku.Count; i++)
        {
            Console.WriteLine( konteneryNaStatku[i].ToString());
        }
    }
    public void PrzeniesKontener(Kontenerowiec kon , int id)
    {
        Kontener kon1 = null;
        foreach(var i in konteneryNaStatku)
        {
            if(i.Id == id)
            {
                kon1 = i;
                break;
            }
        }
        if(kon1 == null)
        {
            Console.WriteLine("Nie ma kontenera z takim ID");
        }
        UsunKontener(id);
        kon.Zaladunek(kon1);
        Console.WriteLine($"Przeniesiono kontener o ID {id}");
    }
  
    
                                                   



    







}
