using Abstracciones;
using System;

namespace Multiplicador2
{
    public class Multiplicador_2 : IMultiplicador
    {
        public int MultiplicarNumeros(int multiplicando, int multiplicador)
        {
            Console.WriteLine($"Producto de 2 numeros con el componente {nameof(Multiplicador_2)}");

            if (multiplicando == 0 || multiplicador == 0)
                return 0;

            int suma = 0;
            int auxiliarMultiplicando = 0;
            int auxiliarMultiplicador = 0;

            if (multiplicando < 0)
                auxiliarMultiplicando = -multiplicando;
            else
                auxiliarMultiplicando = multiplicando;

            if (multiplicador < 0)
                auxiliarMultiplicador = -multiplicador;
            else
                auxiliarMultiplicador = multiplicador;

            for (var repeticion = auxiliarMultiplicador; repeticion > 0; repeticion--)
                suma += auxiliarMultiplicando;

            if ((multiplicando < 0 && multiplicador > 0) || (multiplicando > 0 && multiplicador > 0))
                return suma;


            return -suma;

        }
    }
}
