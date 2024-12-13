using System.Collections;
using System.Collections.Generic;

namespace ZadLists
{
    internal class Program
    {
        static int[] nums = { 10, -15, 100, 0, -200 };
        static void Main(string[] args)//da se vuvede chislo na 3to mqsto, s arraylist, linkedList i Stack
        {
            AListPart();
            LListPart();
            StackPart();
        }
        static void AListPart()
        {
            Console.WriteLine("Insert element to array list: ");
            int insert = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", nums));
            ArrayList aList = AddAL(insert);
            foreach (object item in aList)
            {
                Console.Write(item + " ");
            }
        }
        static ArrayList AddAL(int insert)
        {
            ArrayList aList = new ArrayList();
            aList.AddRange(nums);
            aList.Insert(2, insert);
            return aList;
        }
        static void LListPart()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Insert element to linked list: ");
            int insert = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine(string.Join(" ", AddLL(insert)));
        }
        static LinkedList<int> AddLL(int insert)
        {
            LinkedList<int> lList = new LinkedList<int>(nums);
            LinkedListNode<int> node = lList.First.Next;
            lList.AddAfter(node, insert);
            return lList;
        }
        static void StackPart()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Insert element to stack: ");
            int insert = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine(string.Join(" ", AddSt(insert)));
        }
        static Stack<int> AddSt(int insert)
        {
            Stack<int> stack = new Stack<int>();
            int count = nums.Length;
            for(int i = 0; i < count; i++)
            {
                stack.Push(nums[i]);
                if(i == count - 3)
                {
                    stack.Push(insert);
                }
            }
            return stack;
        }
    }
}
