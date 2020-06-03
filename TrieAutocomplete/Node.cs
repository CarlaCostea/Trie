using System;
using System.Collections.Generic;
using System.Text;

namespace TrieAutocomplete
{
    public class Node
    {
        public Node[] Children = new Node[AlphabetSize];
        const int AlphabetSize = 26;
        private bool endOfWord;

        public Node()
        {
            endOfWord = false;
            for (int i = 0; i < AlphabetSize; i++)
            {
                Children[i] = null;
            }
        }

        public Node GetNode()
        {
            return new Node();
        }
    }
}
