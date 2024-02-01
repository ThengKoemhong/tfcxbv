namespace Lesson1;
using System;
public class MinMax
{
    public static void Main(){
        int a = 15;
        int b = 30;
        int c = 7;
        int d = 10;
        int x = Math.Max(a,b);
        int y = Math.Max(c,d);
        Console.WriteLine("A = {0} B = {1} C = {2} D = {3} X = {4} Y = {5}",a,b,c,d,x,y);
        Console.WriteLine("Max A & B =  {0} Max C D = {1} Max  Z  = {2}",x,y,Math.Max(y,x));
        Console.WriteLine("Min A & B =  {0} Min C D = {1} Min  Z  = {2}",Math.Min(a,b),Math.Min(c,b),Math.Min(y,x));
    }
}
