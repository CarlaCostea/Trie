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
            root = new Node();
        }

        public void Add(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException(nameof(word), "word is null");
            }

            AddToRoot(root, word);
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

        private void AddToRoot(Node node, string remainingString)
        {
            if (remainingString.Length <= 0)
            {
                return;
            }

            char prefix = remainingString[0];
            string substring = remainingString.Substring(1);

            if (!node.GetNode.ContainsKey(prefix))
            {
                node.GetNode.Add(prefix, new Node());
            }

            if (substring.Length == 0)
            {
                node.GetNode[prefix].EndOfWord = true;
                return;
            }

            AddToRoot(node.GetNode[prefix], substring);
        }

        public List<string> GetWords(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException(nameof(word), "word is null");
            }

            List<string> result;
            int alphabetIndex;
            Node parrent = root;

            for (int letterIndex = 0; letterIndex < word.Length; letterIndex++)
            {
                alphabetIndex = 'a' - word[letterIndex];

                if (parrent.Children[alphabetIndex] == null)
                {
                    return null;
                }

                parrent = parrent.Children[alphabetIndex];
            }

            }
        }
    }
}
