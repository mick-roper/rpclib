using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RpcLib.Abstractions
{
    public interface IMessageHandler
    {
        string TargetType { get; }

        Task<IMessage> HandleMessageAsync(IMessage message);
    }
}
