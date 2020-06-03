using System;
using System.Collections.Generic;
using System.Text;

namespace TrieAutocomplete
{
    public class Trie
    {
        private Node root;

        public Trie()
        {
            root = root.GetNode();
        }

        public void Add(string word)
        {
            if (word == null)
            {
                return;
            }

            int alphabetIndex;
            Node parrent = root;
            for (int letterIndex = 0; letterIndex < word.Length; letterIndex++)
            {
                alphabetIndex = 'a' - word[letterIndex];
                if (alphabetIndex < 0)
                {
                    break;
                }

                parrent.Children[alphabetIndex] ??= parrent.GetNode();

                parrent = parrent.Children[alphabetIndex];
            }

            parrent.EndOfWord = true;
        }
    }
}
