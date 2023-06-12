using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Hilos2022
{
    class Program
    {
        static void Main(string[] args)
        {

            CancellationTokenSource cancellationTokenSource= new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            Task t3 = Task.Run(()=>MiMetodo2(cancellationToken));

            Thread.Sleep(5000);

            cancellationTokenSource.Cancel();


            Task t2 = new Task(MiMetodo);

            t2.Start();





            Console.ReadKey();
        }



        public static void MiMetodo()
        {
            for (int i = 0; i < 5; i++)
            {
               Console.WriteLine("Hilo secundario: " + Thread.CurrentThread.ManagedThreadId + " - Instancia: " + Task.CurrentId);

                Thread.Sleep(2000);
            }
  
        }

        public static void MiMetodo2(CancellationToken token)
        {


            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Metodo 2: " + Thread.CurrentThread.ManagedThreadId + " - Instancia: " + Task.CurrentId);

                Thread.Sleep(1000);

                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Cancelo el token");
                    return;

                }
            }

        }

        
        public static void MetodoConArgumentos(string cadena)
        {
            Thread.Sleep(5000);
            Console.WriteLine(cadena);
        }

    }

}
