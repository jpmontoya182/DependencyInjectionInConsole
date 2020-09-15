using Abstracciones;
using System;

namespace Multiplicador1
{

    public class Multiplicador_1 : IMultiplicador
    {
        public int MultiplicarNumeros(int multiplicando, int multiplicador)
        {
            Console.WriteLine($"Producto de 2 numeros con el component {nameof(Multiplicador_1)}");
            return multiplicando * multiplicador;
        }
    }

}
