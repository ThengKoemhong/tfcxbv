namespace Lesson1;
using System;
using System.Collections;

public class Constructor
{
    public static void Main(){
        List<Student> students = new List<Student>();
        students[0]= new Student(id:1,name:"Hong",gender:"mal");
    }
}
