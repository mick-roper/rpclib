using RpcLib.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RpcLib
{
    public sealed class Engine
    {
        readonly IReceiver receiver;
        readonly IEmitter emitter;
        readonly IEnumerable<IMessageHandler> messageHandlers;

        public Engine(
            IReceiver receiver,
            IEmitter emitter,
            IEnumerable<IMessageHandler> messageHandlers)
        {
            this.receiver = receiver ?? throw new ArgumentNullException(nameof(receiver));
            this.emitter = emitter ?? throw new ArgumentNullException(nameof(emitter));
            this.messageHandlers = messageHandlers ?? throw new ArgumentNullException(nameof(messageHandlers));
        }
    }
}
