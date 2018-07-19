using System;
using System.Collections.Generic;
using System.Text;

namespace RpcLib.Abstractions
{
    public interface IReceiver
    {
        Action<IMessage> OnMessageReceived { get; }
    }
}
