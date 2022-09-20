using System;
public class STRUCT {
    struct Employee {
        public string FirstName;
        public string LastName;
        public int Age;
        public string CompletedTraining;
    }
    public static void Main(string[] args){

        Console.Title = "Struct";
        Employee employee1;
        employee1.FirstName = "Juan";
        employee1.LastName = "DelaCruz";
        employee1.Age = 25;
        employee1.CompletedTraining = "Yes";

        Console.WriteLine("Name:" + employee1.FirstName);
        Console.WriteLine("LastName:" + employee1.LastName);
        Console.WriteLine("Age" + employee1.Age);
        Console.WriteLine("CompletedTraining" + employee1.CompletedTraining);
        Console.ReadLine( );
    }
}


