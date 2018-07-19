using Moq;
using RpcLib.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RpcLib.Tests
{
    public class EngineTests
    {
        readonly Mock<IReceiver> mockReceiver = new Mock<IReceiver>();
        readonly Mock<IEmitter> mockEmitter = new Mock<IEmitter>();

        [Fact]
        public void ctor_throws_exception_if_receiver_is_null()
        {
            var receiver = null as IReceiver;
            var emitter = mockEmitter.Object;
            var handlers = new[] {
                Mock.Of<IMessageHandler>(),
                Mock.Of<IMessageHandler>(),
                Mock.Of<IMessageHandler>(),
            };

            var ex = Assert.Throws<ArgumentNullException>(() => new Engine(receiver, emitter, handlers));

            Assert.Equal("receiver", ex.ParamName);
        }

        [Fact]
        public void ctor_throws_exception_if_emitter_is_null()
        {
            var receiver = mockReceiver.Object;
            var emitter = null as IEmitter;
            var handlers = new[] {
                Mock.Of<IMessageHandler>(),
                Mock.Of<IMessageHandler>(),
                Mock.Of<IMessageHandler>(),
            };

            var ex = Assert.Throws<ArgumentNullException>(() => new Engine(receiver, emitter, handlers));

            Assert.Equal("emitter", ex.ParamName);
        }

        [Fact]
        public void ctor_throws_exception_if_handlers_is_null()
        {
            var receiver = mockReceiver.Object;
            var emitter = mockEmitter.Object;
            var handlers = null as IEnumerable<IMessageHandler>;

            var ex = Assert.Throws<ArgumentNullException>(() => new Engine(receiver, emitter, handlers));

            Assert.Equal("messageHandlers", ex.ParamName);
        }
    }
}
