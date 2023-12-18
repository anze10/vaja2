using System;

class naloga_dva
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vnesite število ur");
        int ura = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Vnesite število minut");
        int minute = Convert.ToInt32(Console.ReadLine());
        ura_je(ura, minute);

    }
    public static void ura_je(int ura, int minute)
    {
        if (minute == 0)
        {
            Console.WriteLine("Ura je {0}", ura);
        };

        else if (minute < 30)
        {
            Console.WriteLine("Ura je {0} minut čez {1}", minute, ura);
        };

        else if (minute == 30)
        {
            Console.WriteLine("Ura je pol {0}", ura + 1);
        };

        else if (minute > 30)
        {
            Console.WriteLine("Ura je {0} minut do {1}", 60 - minute, ura + 1);
        };
    }
}