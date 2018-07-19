using System.Threading.Tasks;

namespace RpcLib.Abstractions
{
    public interface IEmitter
    {
        /// <summary>
        /// Emits a message
        /// </summary>
        /// <param name="message">The message to emit</param>
        /// <returns></returns>
        Task EmitAsync(IMessage message);
    }
}
