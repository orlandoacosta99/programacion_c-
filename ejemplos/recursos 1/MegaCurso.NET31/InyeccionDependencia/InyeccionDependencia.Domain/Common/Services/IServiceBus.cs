using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia.Domain
{
    public interface IServiceBus
    {
        void StartProcess<T>(T command) where T : IMessage;
        void SendCommand<T>(T command) where T : IMessage;
        void RaiseEvent<T>(T theEvent) where T : IEvent;
    }
}
