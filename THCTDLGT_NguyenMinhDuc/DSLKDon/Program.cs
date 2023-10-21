// See https://aka.ms/new-console-template for more information
namespace DSLKDon{
    class Program{
        static MyList list = new MyList();
        static void Main()
        {
            Console.WriteLine("-----Test Input----- ");
            TestInput();
            //Console.WriteLine("-----Test Search----- ");
            //TestSearch();
            //Console.WriteLine("-----Test Max Min----- ");
            //TestGetMaxMin();
            //Console.WriteLine("-----Test Even Odd----- ");
            //TestGetEvenOdd();
            //Console.WriteLine("-----Test Join----- ");
            //TestJoin();
            Console.WriteLine("-----Test Remove----- ");
            TestRemove(0);
        }

        static void TestInput()
        {           
            list.Input();
            list.ShowList();
        }
        static void TestRemove(int i)
        {
            list.RemoveAt(i);
            list.ShowList();
        }
        static void TestSearch()
        {
            string search = list.SearchX(4);
            Console.WriteLine(search);
        }
        static void TestGetMaxMin()
        {
            Console.WriteLine("Max: {0}\nMin: {1}", list.GetMax(), list.GetMin());
        }
        static void TestGetEvenOdd()
        {
            MyList evenList = list.GetEvenList();
            Console.WriteLine("Even List: ");
            evenList.ShowList();

            MyList oddList = list.GetOddList();
            Console.WriteLine("Odd List: ");
            oddList.ShowList();
        }
        static void TestJoin()
        {
            MyList list1 = new MyList();
            list1.AddFirst(new IntNode(1));
            list1.AddFirst(new IntNode(2));
            list1.AddFirst(new IntNode(3));
            Console.WriteLine("List1: ");
            list1.ShowList();
            MyList list2 = new MyList();
            list2.AddFirst(new IntNode(4));
            list2.AddFirst(new IntNode(5));
            list2.AddFirst(new IntNode(6));
            Console.WriteLine("List2: ");
            list2.ShowList();
            MyList list3 = new MyList();
            list3 = list1;
            list3.JoinList(list2);
            Console.WriteLine("List3: ");
            list3.ShowList();
        }
    }
}
