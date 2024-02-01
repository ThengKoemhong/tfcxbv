namespace _Net;
using System;
public class exam
{
  public static void Main(string [] args){
    double a = 85;
    double b = 67;
    double c = 58;
    double d = 62;
    
    double total = (a*20/100) +   (b*15/100)+  (c*25/100)+  (d*40/100);
    Console.WriteLine(total);
   int ra = new  exam().rail_dola(100);
   Console.WriteLine(ra);
   double money = new exam().ExRailtoDolla(10,4200);
   Console.WriteLine(money);
  int n = int.Parse(Console.ReadLine());
  }
  int rail_dola(int mondey){
    return mondey * 4200;
  }
   double ExRailtoDolla ( double money , double rate){
    return money * rate;
  }
}
