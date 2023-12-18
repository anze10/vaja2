using System;

class naloga_pet{
	public static void Main(string[] args){
		Console.Write("Vpišite prvo število ur: ");
		int ura_ena = Convert.ToInt32(Console.ReadLine());
		Console.Write("Vpišite prvo število minut: ");
		int minute_ena = Convert.ToInt32(Console.ReadLine());
		Console.Write("Vpišite drugo število ur: ");
		int ura_dva = Convert.ToInt32(Console.ReadLine());
		Console.Write("Vpišite drugo število minut: ");
		int minute_dva = Convert.ToInt32(Console.ReadLine());
		potekel_cas(ura_ena,minute_ena,ura_dva,minute_dva);
	}
	public static void potekel_cas(int ura_ena ,int minute_ena,int ura_dva ,int minute_dva){
		int dan = 0;
		int pretekli_cas = 0;
		cas_ena = (ura_ena * 60) + minute_ena;
		cas_dva = (ura_dva * 60) + minute_dva;
		if (cas_dva == cas_ena){
			dan ++;
		}
		else if(cas_dva > cas_ena){
			pretekli_cas = cas_dva - cas_ena;
		}
		else if (cas_dva < cas_ena) {
			pretekli_cas = ((24 * 60) - cas_ena) + cas_dva
		}
		int ure = pretekli_cas / 60;
		int minute = potekel_cas % 60 ;
		
		Console.Writline("med {}:{} in {}:{} je minilo {} dni {} ur {} minut " ,ura_ena, minute_ena,ura_dva,minute_dva,dan,ure,minute);
	}
}