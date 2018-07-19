using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RpcLib.Abstractions
{
    public interface IMessageHandler<TMessage> where TMessage : IMessage
    {
        /// <summary>
        /// Handles a message asynchronously
        /// </summary>
        /// <param name="message">The message</param>
        /// <returns></returns>
        Task<IMessage> HandleMessageAsync(TMessage message);
    }
}
