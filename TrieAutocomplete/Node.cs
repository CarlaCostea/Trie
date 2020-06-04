using System;
using System.Collections.Generic;
using System.Text;

namespace TrieAutocomplete
{
    public class Node
    {
        public Node()
        {
            EndOfWord = false;
            GetNode = new Dictionary<char, Node>();
        }

        public bool EndOfWord { get; set; }

        public Dictionary<char, Node> GetNode { get; }
    }
}
