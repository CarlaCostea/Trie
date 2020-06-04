using System;
using System.Collections.Generic;
using System.Text;

namespace TrieAutocomplete
{
    public class Node
    {
        private string word;

        public Node(string word)
        {
            EndOfWord = false;
            GetNode = new Dictionary<char, Node>();
            this.word = word;
        }

        public bool EndOfWord { get; set; }

        public Dictionary<char, Node> GetNode { get; }

        public string Word
        {
            get { return word; }
        }
    }
}
