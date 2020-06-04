using System;
using System.Collections.Generic;
using System.Text;
using TrieAutocomplete;
using Xunit;

namespace TrieAutocompleteTests
{
    public class TrieTests
    {
        [Fact]
        public void TestExample()
        {
            Trie myTrie = new Trie();
            myTrie.Add("hell");
            myTrie.Add("hello");
            myTrie.Add("bye");

            var expected = new string[] { "hell", "hello" };
            var result = myTrie.GetWords("hel");

            Assert.Equal(expected, result);
        }
    }
}
