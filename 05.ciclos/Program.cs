using System;

namespace _05.ciclos
{
    class Program
    {
        static int Main(string[] args)
        {   
            int c= 0, suma = 0;

            if(args.Length == 0){
                Console.Clear();
                menu();
                return 1;
            }

            int opcion = Int32.Parse( args[0]);

            switch(opcion){

                case 1:{
                    c = 1;

                    while(c<=100){
                        Console.Write(c +" ");
                        suma+=c;
                        c++;
                    }
                    Console.WriteLine($"\n La suma es {suma}");
                }
                break;
                case 2:{
                     c = 100;

                    while(c>=1){
                        Console.Write(c +" ");
                        suma+=c;
                        c--;
                    }
                    Console.WriteLine($"\n La suma es {suma}");
                }
                break;
                case 3 : {
                    for( c = 50; c <= 200; c++){
                        Console.Write(c +" ");
                        suma+=c;
                    }
                    Console.WriteLine($"\n La suma es {suma}");
                }
                break;
                case 4 : {
                    for( c = 2; c <= 100; c+=2){
                        Console.Write(c +" ");
                        suma+=c;
                    }
                    Console.WriteLine($"\n La suma es {suma}");
                }
                break;
                case 5 : {
                    for( c = 99; c >= 1; c-=2){
                        Console.Write(c +" ");
                        suma+=c;
                    }
                    Console.WriteLine($"\n La suma es {suma}");
                }
                break;
                case 6 : {
                    c = 40;

                    while(c<=272){
                        Console.Write(c +" ");
                        suma+=c;
                        c+=4;
                    }
                    Console.WriteLine($"\n La suma es {suma}");
                }
                break;
            }
            
            return 0;
        }

        static void menu(){

            Console.WriteLine("Menu:");
            Console.WriteLine("[1] Numeros del 1 al 100 con ciclo while");
            Console.WriteLine("[2] Numeros del 100 al 1 con ciclo do...while");
            Console.WriteLine("[3] Numeros del 50 al 200 con ciclo for");
            Console.WriteLine("[4] Numeros del 2 al 100  solo los pares con ciclo for");
            Console.WriteLine("[5] Numeros del 99 al 1 solo los impares con ciclo for");
            Console.WriteLine("[6] Numeros del 40 al 272 en decrementos de 4 con ciclo while");
        }
    }
}
