using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to HashTable Problem");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

            string hash1 = hash.Get("5");
            Console.WriteLine("5th index value is: " + hash1);
        }
    }
}
