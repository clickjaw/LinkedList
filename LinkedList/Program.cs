using System;
using System.Collections;
using System.Collections.Generic;


namespace LinkedList
{
  public class Program
  {
    static void Main(string[] args)
    {
      LinkedListClass myLinkedList = new LinkedListClass();

      myLinkedList.Insert(new Node(1));
      myLinkedList.Insert(new Node(2));
      myLinkedList.Insert(new Node(3));
      myLinkedList.Insert(new Node(4));
      myLinkedList.Insert(new Node(5));
      myLinkedList.Insert(new Node(6));

      Console.WriteLine(myLinkedList.ToString());
      Console.WriteLine(myLinkedList.Includes(6));

    }


    public class Node
    {
      public int Value { get; set; }
      public int Next { get; set; }
      //making a constructor for Node
      public Node(int value)
      {
        Value = value;
      }
    }

    public class LinkedListClass
    {
      public Node Head { get; set; }
      public List<Node> CurrentLinkedList { get; set; }
      public LinkedListClass()
      {
        CurrentLinkedList = new List<Node>();
      }

      public void Insert(Node value)
      {
        // Adds a new node with that value to the head of the list with an O(1) Time performance.
        CurrentLinkedList.Add(value);
        if (CurrentLinkedList.Count() <= 1)
          Head = CurrentLinkedList.ElementAt(0);
      }





      public bool Includes(int value)
      {
        // Indicates whether that value exists as a Node’s value somewhere within the list.
        bool tOF = false;
        foreach (var v in CurrentLinkedList)
        {
          if (v.Value == value)
          {
            tOF = true;
            break;
          }
          else
            tOF = false;
        }
        return tOF;
      }

      public string ToString()
      {
        

        string[] theString = new string[CurrentLinkedList.Count()];
        if (CurrentLinkedList.Count() == 0)
          return "NULL";
        else
        {
          for (int i = 0; i <= CurrentLinkedList.Count() - 1; i++)
          {
            if (CurrentLinkedList.Count() == i + 1)
            {
              theString[i] = "{ " + (CurrentLinkedList.ElementAt(i).Value) + " } -> NULL";
            }
            else
              theString[i] = "{ " + (CurrentLinkedList.ElementAt(i).Value) + " } -> ";
          }

          return String.Join(" ", theString);
        }

      }
    }
  }
}