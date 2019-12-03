using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class Trie
    {
        private TrieNode Root;

        public Trie()
        {
            Root = new TrieNode();
        }

        // Inserts a word into the trie.
        public void Insert(string word)
        {
            TrieNode p = Root;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                int index = c - 'a';
                if (p.Arr[index] == null)
                {
                    TrieNode temp = new TrieNode();
                    p.Arr[index] = temp;
                    p = temp;
                }
                else
                {
                    p = p.Arr[index];
                }
            }
            p.IsEnd = true;
        }

        // Returns if the word is in the trie.
        public bool Search(string word)
        {
            TrieNode p = SearchNode(word);
            if (p == null)
            {
                return false;
            }
            else
            {
                if (p.IsEnd)
                    return true;
            }

            return false;
        }

        // Returns if there is any word in the trie
        // that starts with the given prefix.
        public bool StartsWith(String prefix)
        {
            TrieNode p = SearchNode(prefix);
            if (p == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private TrieNode SearchNode(string s)
        {
            TrieNode p = Root;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                int index = c - 'a';
                if (p.Arr[index] != null)
                {
                    p = p.Arr[index];
                }
                else
                {
                    return null;
                }
            }

            if (p == Root)
                return null;

            return p;

        }

        public void SuggestProduct(string srch)
        {
            List<List<string>> op = new List<List<string>>();
            if (srch.Length < 2)
            {
                //return op;
            }
            else
            {
                for(int i=2; i< srch.Length; i++)
                {
                    string prefix = srch.Substring(0, i);
                    if (StartsWith(prefix)) //if the Trie contains word starting with this prefix...
                    {

                    }
                }
            }
        }
    }
    class TrieNode
    {
        public TrieNode[] Arr;
        public bool IsEnd;

        public TrieNode()
        {
            this.Arr = new TrieNode[26];
        }
    }
}
