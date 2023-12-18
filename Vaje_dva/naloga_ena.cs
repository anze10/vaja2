using System;
class naloga_ena{
	public static void Main(string[] args){
		Console.WriteLine("Vnesite prvo število");
		int st_ena = Convert.ToInt16(Console.ReadLine());
		Console.WriteLine("Vnesite drugo število");
		int st_dva = Convert.ToInt16(Console.ReadLine());
		int rezulta = sestej(st_ena,st_dva);
		Console.WriteLine("Če seštejemo števili {0} in {1} dobimo {2}",st_ena,st_dva,rezulta);
	}
	public static int sestej(int st_ena, int st_dva){
		return st_ena + st_dva;
	}
}