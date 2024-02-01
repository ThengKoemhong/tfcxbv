namespace Lesson1;
using System;
public class Test1
{
    static void Main(string[] arge){
     int score = 90;
     if(score < 0){
        Console.WriteLine("​Score <​ 0");
     }else{
        if(score > 100){
            Console.WriteLine("Score > 100");
        }else if(score < 50){
            Console.WriteLine("Fail");
        }else if(score  ==  100){
              Console.WriteLine("Perfect");
        }else if(score >= 95){
            Console.WriteLine("Exellent");
        }else if(score >= 90){
            Console.WriteLine("Very Good");
        }else if(score >=80){
Console.WriteLine("Good");
        }else if(score >70 ){
            Console.WriteLine("Fair");
        }
     }
    }   
}
