using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
            // LCT04_SyntaxDictionary();
        }

        public void LCT01_SyntaxList()
        {
            List<string> list = new List<string>();
            list.Add("Node 1");
            list.Add("Node 2");
            list.Insert(0, "Node 0");

            foreach (string item in list)
            {
                Debug.Log(item);
            }

            Debug.Log(list[0]);
            Debug.Log(list[list.Count - 1]);

            list.RemoveAt(0);
            list.Remove("Node 2");

            foreach (string item in list)
            {
                Debug.Log(item);
            }
        }
        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> linkedlist = new LinkedList<string>();
            linkedlist.AddLast("Node 1");
            linkedlist.AddLast("Node 2");
            linkedlist.AddFirst("Node 0");

            foreach (string item in linkedlist)
            {
                Debug.Log(item);
            }

            LinkedListNode<string> node1 = linkedlist.Find("Node 1");
            LinkedListNode<string> firstNode = linkedlist.First;
            LinkedListNode<string> lastNode = linkedlist.Last;
            Debug.Log("First node: " + firstNode.Value);
            Debug.Log("Last node: " + lastNode.Value);
            Debug.Log("First node previous: " + firstNode.Previous);
            Debug.Log("Last node next: " + lastNode.Next);

            linkedlist.AddBefore(node1, "Before Node 1");
            linkedlist.AddAfter(node1, "After Node 1");

            foreach (string item in linkedlist)
            {
                Debug.Log(item);
            }

            linkedlist.RemoveFirst();
            linkedlist.Remove("Node 2");

            foreach (string item in linkedlist)
            {
                Debug.Log(item);
            }
        }

        public void LCT03_SyntaxHashTable()
        {
            Hashtable fruits = new Hashtable();
            fruits.Add(1, "Apple");
            fruits.Add(2, "Banana");
            fruits.Add("bad-fruit", "Rotten Tomato");

            Debug.Log("fruit1: " + (string)fruits[1]);
            Debug.Log("fruit2: " + (string)fruits[2]);
            Debug.Log("badFruit: " + (string)fruits["bad-fruit"]);

            foreach (DictionaryEntry entry in fruits)
            {
                Debug.Log(entry.Key + ": " + entry.Value);
            }

            if (fruits.ContainsKey(2))
            {
                Debug.Log("found 2");
            }

            fruits.Remove(1);

            foreach (DictionaryEntry entry in fruits)
            {
                Debug.Log(entry.Key + ": " + entry.Value);
            }
        }
        public void LCT04_SyntaxDictionary()
        {
            Dictionary<int, string> fruits = new Dictionary<int, string>();
            fruits.Add(1, "Apple");
            fruits.Add(2, "Banana");
            fruits[3] = "Cherry";

            Debug.Log("Dictionary has " + fruits.Count + " keys");
            Debug.Log("has key 1 : " + fruits.ContainsKey(1));

            if (fruits.ContainsKey(1))
            {
                Debug.Log("value of key 1 : " + fruits[1]);
            }

            Debug.Log("All keys in dictionary:");
            foreach (int key in fruits.Keys)
            {
                Debug.Log(key);
            }

            fruits.Remove(3);
            Debug.Log("Dictionary has " + fruits.Count + " keys");
            fruits.Clear();
        }
    }
}


