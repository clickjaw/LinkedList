using System;


namespace LinkedList.Link
{

    public class myNode
    {
        public int Data {get; set;}
        public myNode? Next { get; set; }

        public void DisplayNode(){
            Console.WriteLine(Data);
        }
    }

}