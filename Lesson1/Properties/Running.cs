namespace Lesson1;
using System;
public class Running
{
public static int Min( int a, int b){
if(a>b)
 return a;
 if(b>a)
return b;   
return 0;
}
    public static void Main(string [] args){
        Console.WriteLine("Enter A :");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter B");
         int b = int.Parse(Console.ReadLine());
int min = Min(a,b);
if(min == 0){
    Console.WriteLine("Min A = B");
}else{
    Console.WriteLine("Min A B = "+min);
}
    }
}
