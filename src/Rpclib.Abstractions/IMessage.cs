using System;
using System.Collections.Generic;
using System.Text;

namespace RpcLib.Abstractions
{
    public interface IMessage
    {
        string MessageID { get; }
        string CorrelationID { get; }
        DateTime Created { get; }
        string ContentType { get; }
        string ContentEncoding { get; }
        string Source { get; }
        string ReplyTo { get; }
        string Type { get; }
        byte[] Payload { get; }
        Appendable<string> History { get; }
    }
}
