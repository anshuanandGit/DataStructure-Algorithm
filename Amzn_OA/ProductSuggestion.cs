using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Amzn_OA
{
    class ProductSuggestion
    {
        public static void Start()
        {
            List<String> repository = new List<string> { "mobile", "mouse", "moneypot", "monitor", "mousepad" };
            string customerQuery = "mob";

            List<List<String>> x = Suggestions(5, repository, customerQuery);

            foreach(var y in x)
            {
                Console.WriteLine(String.Join(",",y));
            }
            Console.WriteLine("done");
        }

        public static List<List<String>> Suggestions(int numProducts, List<String> repository, String customerQuery)
        {
            Tri root = new Tri();

            //insert every product to tri
            foreach (string p in repository)
            {
                string product = p.ToLower();

                Tri walk = root;
                for (int i = 0; i < product.Length; i++)
                {
                    int c = product[i] - 'a';
                    if (walk.NextLetters[c] == null)
                    {
                        walk.NextLetters[c] = new Tri();  //add new trie at index
                    }

                    walk = walk.NextLetters[c]; //access the trie from index
                    walk.pq.Enqueue(product);

                    
                    var a = walk.pq.ToArray().ToList();
                    a.Sort((x, y) => y.CompareTo(x)); //sort the queue everytime in descending order
                    Queue<string> sortedQ = new Queue<string>(a);

                    walk.pq = sortedQ;

                    if (walk.pq.Count > 3)
                    {
                        walk.pq.Dequeue();
                    }
                   
                }
                walk.IsWordEnd = true;
            }

            //serach in tri...
            List<List<String>> productSuggestions = new List<List<String>>();
            Tri walk1 = root;
            customerQuery = customerQuery.ToLower();

            //start query from 1 index since suggestion should come after first 2 characters only....
            for (int i = 1; i < customerQuery.Length; i++)
            {
                int c = customerQuery[i] - 'a';
                if (walk1.NextLetters[c] == null)
                {
                    break;
                }
                walk1 = walk1.NextLetters[c];         

                if (i > 0 && walk1.pq.Count() != 0)  // check if query is above first character
                {
                    var suggestion = new List<String>(walk1.pq);
                    suggestion.Sort(); //arrange all output in lphabateical order..
                    productSuggestions.Add(suggestion);
                }
            }
            return productSuggestions;

        }
       
    }

    class Tri
    {
        public Tri[] NextLetters;
        public Queue<string> pq;
        public bool IsWordEnd;

        public Tri()
        {
            NextLetters = new Tri[26];
            pq = new Queue<string>();
            IsWordEnd = false;
        }
    }

}