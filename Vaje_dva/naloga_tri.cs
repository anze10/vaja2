using System;
class naloga_tri
{
    public static void Main(string[] args)
    {
        int st_ena = Convert.ToInt32(Console.ReadLine());
        int st_dva = Convert.ToInt32(Console.ReadLine());
        int st_tri = Convert.ToInt32(Console.ReadLine());
        int st_stiri = Convert.ToInt32(Console.ReadLine());
        int naj = najvecja(st_ena, st_dva, st_tri, st_stiri);
        Console.WriteLine("Najvecje stevilo je {0}",naj);
    }
    public static int najvecja(int st_ena, int st_dva, int st_tri, int st_stiri)
    {
        int n = st_ena; 

        if (st_dva > n)
        {
            n = st_dva;
        }

        if (st_tri > n)
        {
            n = st_tri;
        }

        if (st_stiri > n)
        {
            n = st_stiri;
        }

        return n;
    }
}

	
