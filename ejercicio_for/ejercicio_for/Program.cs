using System;

public class Program
{
    static void Main(string[] args)
    {

        int acumulador=0; //Acumulador de 12 meses
                          
        for(int i = 1; i <=15; i++) {
            acumulador += 12; //acumulador sumara el 12 alrededor de 15 pasos del for, += se utiliza de manera abreviada

            Console.WriteLine("año " + i +": "+acumulador);  //escribe el resultado final
        }

        Console.ReadKey();  //Bloquea la salida del cmd
    }
}
