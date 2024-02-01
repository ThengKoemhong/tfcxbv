namespace Lesson1;
using System;
using System.Collections;

public class exam1
{
public static void Main(){
    int []array = new int[5];
    int total=0;
    int score;
        for(int i = 0 ; i<array.Length ; i++){
            Console.WriteLine("INPUT SCORE "+i);
            score = int.Parse(Console.ReadLine());
            array[i] = score;
            total = total+ array[i];
        }
    int avg = total/array.Length;
        Console.WriteLine( "TOTAL :"+total);
        Console.WriteLine("AVERAGE :"+avg);
}
}
