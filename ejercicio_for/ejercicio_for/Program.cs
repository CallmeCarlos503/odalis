using System;

class Program
{
    static void Main(string[] args)
    {

        int acumulador=0; //Acumulador de 12 meses
                          
        for(int i = 1; i <=15; i++) {
            acumulador += 12;
            Console.WriteLine("año " + i +": "+acumulador);
        }

        Console.ReadKey();
    }
}
