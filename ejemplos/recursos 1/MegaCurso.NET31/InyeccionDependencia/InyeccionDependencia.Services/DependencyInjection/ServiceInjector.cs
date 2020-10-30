using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;


using InyeccionDependencia.Domain;

namespace InyeccionDependencia.Services
{

    public class ServiceInjector : IServiceInjector
    {
        private IKernel _kernel;
        private List<Type> _types;

        public ServiceInjector()
        {
            _kernel = new StandardKernel();
            _types = new List<Type>();

            //_kernel.Bind<fMain>().To<fMain>();
            _kernel.Bind<IServiceBus>().To<ServiceBus>();

            _kernel.Bind<ITeacherCommandService>().To<TeacherCommandService>();
            _types.Add(typeof(ITeacherCommandService));

        }

        public object Get(Type type)
        {
            return _kernel.Get(type);
        }

        public T Get<T>()
        {
            return _kernel.Get<T>();
        }

        public List<Type> GetTypes()
        {
            return _types;
        }
    }
}
