using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("HASHTABLE demo"); //() []
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To be or not to be");
            hash.frequencyOfWords("0");
            hash.Add("1", "A random paragraph can also be an excellent way for a writer to tackle writers' block." +
                " Writing block can often happen due to being stuck with a current project that the writer is trying to complete." +
                " By inserting a completely random paragraph from which to begin, it can take down some of the issues that may have been" +
                " causing the writers' block in the first place.");
            hash.frequencyOfWords("1");
            Console.ReadLine();

            string paragraph = "A random paragraph can also be an excellent way for a writer to tackle writers' block." +
                "Writing block can often happen due to being stuck with a current project that the writer is trying to complete. " +
                "By inserting a completely random paragraph from which to begin, it can take down some of the issues that may have been" +
                " causing the writers' block in the first place.";
            string[] para = paragraph.Split(',');
            MyMapNode<int, string> hash1 = new MyMapNode<int, string>(para.Length);
            int key = 0;
            foreach (string word in para)
            {
                hash1.Add(key, word);
                key++;
            }

            hash.Remove(hash1, "avoidable");
            Console.ReadLine();
        }
    }
}





