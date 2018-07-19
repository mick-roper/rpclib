using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace RpcLib.Abstractions.Tests
{
    public class AppendableTests
    {
        [Fact]
        public void ctor_sets_initial_state()
        {
            var initialItems = new[] { "a", "b", "c" };

            var appendable = new Appendable<string>(initialItems);

            Assert.Equal(initialItems.Length, appendable.Count());

            foreach (var item in initialItems)
            {
                Assert.Contains(item, appendable);
            }
        }

        [Fact]
        public void ctor_sets_empty_State_if_arg_is_null()
        {
            var initialItems = null as IEnumerable<string>;

            var appendable = new Appendable<string>(initialItems);

            Assert.Empty(appendable);
        }

        [Fact]
        public void Add_adds_an_item_to_the_collection()
        {
            const string ITEM = "Hello world!";

            var appendable = new Appendable<string>();

            appendable.Add(ITEM);

            Assert.Contains(ITEM, appendable);
        }
    }
}
