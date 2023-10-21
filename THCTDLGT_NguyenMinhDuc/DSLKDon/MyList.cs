using System;
namespace DSLKDon{
    class MyList{
        private IntNode first;
        private IntNode last;
        private IntNode First{
            get{return first;}
            set{first = value;}
        }
        private IntNode Last{
            get{return last;}
            set{last = value;}
        }
        public MyList(){
            first = null;
            last = null;
        }
        public bool IsEmpty(){
            return first ==null;
        }
        public void AddFirst(IntNode newNode){
            if(IsEmpty()){
                first = last = newNode;
            }
            else{
                newNode.Next = first;
                first = newNode;
            }
        }
        public void AddLast(IntNode newNode)
        {
            if (IsEmpty())
            {
                first = last = newNode;
            }
            else
            {
                last.Next = newNode;
                last = newNode;
            }
        }
        public string SearchX(int x)
        {
            IntNode current = first;
            while (current != null)
            {
                if (current.Data == x)
                {
                    return "Found";
                }
                current = current.Next;
            }
            return "Not Found" ;
        }
        public int GetMax()
        {
            
            IntNode current = first;
            int maxNode = first.Data;
            while (current != null)
            {
                if (current.Data > maxNode)
                {
                    maxNode = current.Data;
                }
                current = current.Next;
            }
            return maxNode;
        }
        public int GetMin()
        {
            int minNode = first.Data;
            IntNode current = first;
            while (current != null)
            {
                if (current.Data < minNode)
                {
                    minNode = current.Data;
                }
                current = current.Next;
            }
            return minNode;
        }
        public MyList GetEvenList()
        {
            MyList evenList = new MyList();
            IntNode current = first;
            while (current != null)
            {
                if (current.Data % 2 == 0)
                {
                    evenList.AddLast(new IntNode(current.Data));
                }
                current = current.Next;
            }
            return evenList;
        }
        public MyList GetOddList()
        {
            MyList oddList = new MyList();
            IntNode current = first;
            while (current != null)
            {
                if (current.Data % 2 != 0)
                {
                    oddList.AddLast(new IntNode(current.Data));
                }
                current = current.Next;
            }
            return oddList;
        }
        public void JoinList(MyList list2)
        {
            if (!IsEmpty() && !list2.IsEmpty())
            {
                last.Next = list2.First;
                last = list2.Last;
            }
        }
        //public void RemoveAt(int i)
        //{
        //    if (IsEmpty())
        //    {
        //        Console.WriteLine("The list is empty.");
        //        return;
        //    }

        //    if (i < 0)
        //    {
        //        Console.WriteLine("The index cannot be negative.");
        //        return;
        //    }

        //    if (i == 0)
        //    {
        //        first = first.Next;
        //        if (first == null)
        //        {
        //            last = null;
        //        }
        //        return;
        //    }

        //    IntNode current = first;
        //    for (int j = 0; j < i - 1; j++)
        //    {
        //        if (current.Next == null)
        //        {
        //            Console.WriteLine("The index is out of range.");
        //            return;
        //        }
        //        current = current.Next;
        //    }

        //    if (current.Next == null)
        //    {
        //        Console.WriteLine("The index is out of range.");
        //        return;
        //    }

        //    current.Next = current.Next.Next;
        //    if (current.Next == null)
        //    {
        //        last = current;
        //    }
        //}
        private IntNode NodeI(int i)
        {
            IntNode current = first;
            for (int j = 0; j < i; j++)
            {
                if (current.Next == null)
                {                   
                    return null;
                }
                current = current.Next;
            }

            return current;

        }
        public void RemoveAt(int i)
        {
            if (i == 0)
            {
                first = first.Next;
                if (first == null)
                {
                    last = null;
                }
                return;
            }
            IntNode removeNode = NodeI(i);
            IntNode prevNode = first;
            IntNode p = first;
            while(p!= null)
            {
                if(p.Next == removeNode)
                {
                    prevNode = p;
                    break;
                }
                p = p.Next;
            }
            prevNode.Next = removeNode.Next;
          
        }
        public void RemoveX()
        {
            IntNode p = first;
        }

        public void Input()
        {
            int x;
            do
            {
                Console.Write("Gia tri (0 ket thuc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x != 0)
                {
                    IntNode newNode = new IntNode(x);

                    if (IsEmpty())
                    {
                        first = last = newNode;
                    }
                    else
                    {
                        IntNode current = first;
                        while (current != null)
                        {
                            if (current.Data == x)
                            {
                                Console.WriteLine("Gia tri bi trung ");
                                break;
                            }
                            current = current.Next;
                        }
                        if (current == null)
                        {
                            AddLast(newNode);
                        }
                    }
                }
            } while (x != 0);

        }
        public void ShowList(){
            IntNode p = first;
            while(p!=null){
                Console.Write("{0} ->",p.Data);
                p = p.Next;
            }
            Console.WriteLine("null");
        }
    }
}