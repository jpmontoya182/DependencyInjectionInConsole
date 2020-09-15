using System;
using Autofac;
using Abstracciones;



namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var ContenedorIoC = ConfiguracionIoC.GenerarContenedor();

            Console.WriteLine("ingrese el primer valor (multiplicando) !!");
            var inputMultiplicando = Console.ReadLine();
            int multiplicando;
            while (!int.TryParse(inputMultiplicando, out multiplicando))
            {
                Console.WriteLine("ingrese un valor valido !!");
                inputMultiplicando = Console.ReadLine();

            }


            Console.WriteLine("ingrese el segundo valor (multiplicador) !!");
            var inputMultiplicador = Console.ReadLine();
            int multiplicador;
            while (!int.TryParse(inputMultiplicador, out multiplicador))
            {
                Console.WriteLine("ingrese un valor valido !!");
                inputMultiplicador = Console.ReadLine();
            }

            //int producto = new Multiplicador_2().MultiplicarNumeros(multiplicando, multiplicador);
            int producto = ContenedorIoC.Resolve<IMultiplicador>().MultiplicarNumeros(multiplicando, multiplicador);

            Console.WriteLine($"resultado: {producto}");

        }
    }
}
