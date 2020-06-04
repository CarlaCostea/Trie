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
        public void IfWeHaveSuggestionsForGivenStringWeShouldTypeThem()
        {
            Trie myTrie = new Trie();
            myTrie.Add("hell");
            myTrie.Add("hello");
            myTrie.Add("bye");

            var expected = new string[] { "hell", "hello" };
            var result = myTrie.GetWords("hel");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void IfWeDoNotHaveSuggestionsForGivenStringWeShouldReturnAnEmptyString()
        {
            Trie myTrie = new Trie();
            myTrie.Add("hell");
            myTrie.Add("hello");
            myTrie.Add("bye");

            var expected = new string[] {};
            var result = myTrie.GetWords("noSuggestion");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void IfTheGivenStringIsEmptyWeShouldReturnAllTheWordsFromTrie()
        {
            Trie myTrie = new Trie();
            myTrie.Add("hell");
            myTrie.Add("hello");
            myTrie.Add("bye");

            var expected = new string[] { "hell", "hello", "bye" };
            var result = myTrie.GetWords("");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void IfTheGivenStringMatchesAWordFromTreeWeShouldReturnIt()
        {
            Trie myTrie = new Trie();
            myTrie.Add("hell");
            myTrie.Add("hello");
            myTrie.Add("bye");

            var expected = new string[] { "hell", "hello" };
            var result = myTrie.GetWords("hell");

            Assert.Equal(expected, result);
        }
    }
}
