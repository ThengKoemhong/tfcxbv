namespace Lesson1;
using System;
public class Loop
{
    public static void Main(){
        for (int i = 0; i<10 ; i++){
            for (int j = 0 ; j<i ; j++){
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}
