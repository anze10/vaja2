using System;

class Program
{
    static void Main()
    {
        int stevilo1 = 12;
        int stevilo2 = 18;
        int stevilo3 = 24;

        int rezultat = NajvecjiSteviloDeliteljev(stevilo1, stevilo2, stevilo3);

        Console.WriteLine($"Število z največ delitelji je: {rezultat}");
    }

    
    static int SteviloDeliteljev(int stevilo)
    {
        int stevec = 0;
        for (int i = 1; i <= stevilo; i++)
        {
            if (stevilo % i == 0)
            {
                stevec++;
            }
        }
        return stevec;
    }

 
    static int NajvecjiSteviloDeliteljev(int a, int b, int c)
    {
        int steviloDeliteljevA = SteviloDeliteljev(a);
        int steviloDeliteljevB = SteviloDeliteljev(b);
        int steviloDeliteljevC = SteviloDeliteljev(c);

        if (steviloDeliteljevA >= steviloDeliteljevB && steviloDeliteljevA >= steviloDeliteljevC)
        {
            return a;
        }
        else if (steviloDeliteljevB >= steviloDeliteljevA && steviloDeliteljevB >= steviloDeliteljevC)
        {
            return b;
        }
        else
        {
            return c;
        }
    }
}