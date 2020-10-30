using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegito.Domain
{
    public interface IServiceInjector
    {
        object Get(Type type);
        T Get<T>();
        void Bind<Intfc, Implm>() where Implm : Intfc;
        List<Type> GetTypes();
    }
}
