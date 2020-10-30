using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosGenerics
{
    public class JobManager
    {



        public T GetJob<T>() where T :new()
        {

            return new T();
        }


    }
}
