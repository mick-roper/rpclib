using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RpcLib.Abstractions
{
    public interface IReceiver
    {
        Task ReceiveAsync(Action onMessageReceived);
    }
}
