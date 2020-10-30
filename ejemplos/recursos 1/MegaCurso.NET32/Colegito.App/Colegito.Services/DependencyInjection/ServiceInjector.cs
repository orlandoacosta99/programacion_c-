using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;


using Colegito.Domain;

namespace Colegito.Services
{

    public class ServiceInjector : IServiceInjector
    {
        private IKernel _kernel;
        private List<Type> _types;


        /// <summary>
        /// Constructor, initialize IOC
        /// </summary>
        public ServiceInjector()
        {
            _kernel = new StandardKernel();
            _types = new List<Type>();


            //bind infrastructure services
            _kernel.Bind<IServiceInjector>().ToConstant(this);
            _kernel.Bind<IDbContext>().To<GlobalDbContext>();
            _kernel.Bind<IServiceBus>().To<ServiceBus>();


            //bind command services
            _kernel.Bind<ITeacherCommandService>().To<TeacherCommandService>();
            _types.Add(typeof(ITeacherCommandService));

        }

        /// <summary>
        /// Resolve dependency by type
        /// </summary>
        public object Get(Type type)
        {
            return _kernel.Get(type);
        }


        /// <summary>
        /// Resolve dependency by generic
        /// </summary>
        public T Get<T>()
        {
            return _kernel.Get<T>();
        }


        /// <summary>
        /// Get list of registered types
        /// </summary>
        public List<Type> GetTypes()
        {
            return _types;
        }


        /// <summary>
        /// Use this method to instruct IOC about a new binding-association
        /// </summary>
        public void Bind<Intfc,Implm>() where Implm:Intfc
        {
            _kernel.Bind<Intfc>().To<Implm>();
        }

    }
}
