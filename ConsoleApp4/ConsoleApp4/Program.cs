using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static  void Main(string[] args)
        {
                Console.WriteLine("start cook breakfast");
                Cutmushroom();
                FrybreadSlices();
                Fryeggs();
                Frymushroom();
                Console.WriteLine("накладываем еду в тарелку");
                
            
                Console.ReadKey();
        }
        static void Cut()
        {
            Console.WriteLine("Режем грибы");
            Thread.Sleep(3000);
            Console.WriteLine("Грибы порезаны");
        }
        static async void Cutmushroom()
        {
           await Task.Run(() => Cut());
            
            
        }
        static public void Frymushroom()
        {
            Console.WriteLine("грибы жарятся");
            Thread.Sleep(3000);
            Console.WriteLine("грибы готовы");
            

        }
        static void FrybreadSlices()
        {
            Console.WriteLine("хлеб жарится");
            Thread.Sleep(3000);
            Console.WriteLine("хлеб готов");
        }
        static public void Fryeggs()
        {
            Console.WriteLine("яйца жарятся");
            Thread.Sleep(3000);
            Console.WriteLine("яйца готовы");
        }
    }
}
