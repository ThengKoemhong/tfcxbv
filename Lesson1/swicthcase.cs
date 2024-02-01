namespace Lesson1;
using System;
using System.Collections;
using System.Diagnostics;

public class swicthcase
{
     public static void Main(string [] args){
    String item;
        ArrayList data = new ArrayList(); 
        do{
            Console.WriteLine("1, Add");
            Console.WriteLine("2, Display");
            Console.WriteLine("3, Search");
            Console.WriteLine("4, Update");
            Console.WriteLine("5, Delte");
            Console.WriteLine("6, Exite");
            Console.Write("Enter Option :");
            int num = int.Parse(Console.ReadLine());
            switch(num) {
  case 1:
    Console.WriteLine("Enter Name :");
     item = Console.ReadLine();
    data.Add(item);
    break;
  case 2:
   Console.WriteLine("ID\tName");
for(int i = 0 ; i < data.Count;i++){
Console.WriteLine(i+"\t"+ data[i]);
}
    break;
    case 3:
     Console.WriteLine("Name Of Search:");
     item = Console.ReadLine();
     bool search = true;
    
   for(int i = 0 ; i < data.Count;i++){
    if(item.Equals( data[i])){
      Console.WriteLine( i+"\t"+ data[i]);
      search =! true;
      Console.WriteLine(search);
    }
   }
if(search == true){
  Console.WriteLine("Data Not Fount");
}
    break;
    case 4:
     Console.WriteLine("Name Of Search for Update:");
     item = Console.ReadLine();
     bool update = true;
    
   for(int i = 0 ; i < data.Count;i++){
    if(item.Equals( data[i])){
      Console.WriteLine( i+"\t"+ data[i]);
      Console.WriteLine("Name Of Search for Update:");
     String Nitem = Console.ReadLine();
      data[i] = Nitem;
      update =! true;
      Console.WriteLine("Update Succesfuly...");
      
    }
   }
   if(update == true){
  Console.WriteLine("Data Not Fount");
}
    break;
    case 5:
     Console.WriteLine("Name Of Search for delete: ");
     item = Console.ReadLine();
     bool delte = true;
    
   for(int i = 0 ; i < data.Count;i++){
    if(item.Equals( data[i])){
  data.RemoveAt(i);
      delte =! true;
      Console.WriteLine("Delete Succesfuly....");
         Console.WriteLine("ID\tName");
for(int j = 0 ; j < data.Count;j++){
Console.WriteLine(i+"\t"+ data[j]);
}
    }
   }
   if(delte == true){
  Console.WriteLine("Data Not Fount");
}
break;
case 6:
 System.Environment.Exit(-1);
    break;
  default:
   break;
}
        }while(true);
     }
}
