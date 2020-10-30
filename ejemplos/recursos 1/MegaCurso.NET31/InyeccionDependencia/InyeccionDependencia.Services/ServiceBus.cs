using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InyeccionDependencia.Domain;


namespace InyeccionDependencia.Services
{
    public class ServiceBus : IServiceBus
    {
        private readonly IServiceInjector _Injector;
        public ServiceBus(IServiceInjector injector)
        {
            _Injector = injector;
        }


        /// <summary>
        /// Get list of assignable services from injector
        /// </summary>
        private List<T> GetAssignableServices<T>() where T : class
        {
            Type lookType = typeof(T);
            List<T> lst = new List<T>();
            foreach (Type type in _Injector.GetTypes())
            {
                if (lookType.IsAssignableFrom(type))
                {
                    lst.Add(_Injector.Get(type) as T);
                }
            }

            return lst;
        }



        /// <summary>
        /// Start process message
        /// </summary>
        public void StartProcess<T>(T command) where T : IMessage
        {
            List<IStartsWithMessage<T>> services = GetAssignableServices<IStartsWithMessage<T>>();
            if (services.Count == 0)
            {
                throw new InvalidOperationException(string.Format(
                    "No services found to handle startmessage {0} ", typeof(T).FullName));
            }

            foreach (IStartsWithMessage<T> svc in services)
            {
                svc.Start(command);
            }
        }


        /// <summary>
        /// Send command
        /// </summary>
        public void SendCommand<T>(T command) where T : IMessage
        {
            List<ICanHandleMessage<T>> services = GetAssignableServices<ICanHandleMessage<T>>();
            if (services.Count == 0)
            {
                throw new InvalidOperationException(string.Format(
                    "No services found to handle message {0} ", typeof(T).FullName));
            }

            foreach (ICanHandleMessage<T> svc in services)
            {
                svc.Handle(command);
            }
        }


        /// <summary>
        /// Raise an event
        /// </summary>
        public void RaiseEvent<T>(T theEvent) where T : IEvent
        {
            List<ICanHandleEvent<T>> services = GetAssignableServices<ICanHandleEvent<T>>();
            foreach (ICanHandleEvent<T> svc in services)
            {
                svc.Handle(theEvent);
            }
        }

    }
}
