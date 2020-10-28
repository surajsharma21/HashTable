﻿using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] para = paragraph.Split(" ");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(para.Length);
            int key = 0;
            foreach (string word in para)
            {
                hash.Add(key, word);
                key++;
            }
            Operation operation = new Operation();
            operation.Frequency(hash);
        }
    }
}
