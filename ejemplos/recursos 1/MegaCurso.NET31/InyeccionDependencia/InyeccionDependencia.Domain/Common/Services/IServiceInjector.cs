﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia.Domain
{
    public interface IServiceInjector
    {
        object Get(Type type);
        T Get<T>();

        List<Type> GetTypes();
    }
}
