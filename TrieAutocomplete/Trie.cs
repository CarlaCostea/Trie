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
            root = new Node("");
        }

        public void Add(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException(nameof(word), "word is null");
            }

            AddToRoot(root, word, "");
        }

        public IEnumerable<string> GetWords(string parrentWord)
        {
            if (parrentWord == null)
            {
                throw new ArgumentNullException(nameof(parrentWord), "word is null");
            }

            Node node = root;
            foreach (var character in parrentWord)
            {
                if (!node.GetNode.ContainsKey(character))
                {
                    return new string[0];
                }

                node = node.GetNode[character];
            }

            return GetChildWords(node);
        }

        private void AddToRoot(Node node, string remainingString, string currentWord)
        {
            if (remainingString.Length <= 0)
            {
                return;
            }

            char prefix = remainingString[0];
            string substring = remainingString.Substring(1);

            if (!node.GetNode.ContainsKey(prefix))
            {
                node.GetNode.Add(prefix, new Node(currentWord + prefix));
            }

            if (substring.Length == 0)
            {
                node.GetNode[prefix].EndOfWord = true;
                return;
            }

            AddToRoot(node.GetNode[prefix], substring, currentWord + prefix);
        }

        private IEnumerable<string> GetChildWords(Node node)
        {
            if (node.EndOfWord)
            {
                yield return node.Word;
            }

            foreach (var subNodes in node.GetNode)
            {
                foreach (var result in GetChildWords(subNodes.Value))
                {
                    yield return result;
                }
            }
        }
    }
}
