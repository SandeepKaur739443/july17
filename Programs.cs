using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new LinkedList();
            a.CreateLikedList();
        }
    }
}

class Node
{
   public  Node nextlink;
   public  Node previousLink;
    public String nodeName;
}
class LinkedList
{
    Node Head, Orange, Tangerine, Tail;
    public void CreateLikedList()
    {
        Head = new Node();
        Orange = new Node();
        Tangerine = new Node();
        Tail = Tangerine;
        Head.nextlink = Orange;
        Console.WriteLine("hello");

    }
}