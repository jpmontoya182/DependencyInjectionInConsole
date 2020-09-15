using Abstracciones;
using Autofac;
using Multiplicador1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public static class ConfiguracionIoC
    {
        public static IContainer GenerarContenedor()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Multiplicador_1>().As<IMultiplicador>();
            return builder.Build();
        }
    }
}
