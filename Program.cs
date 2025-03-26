using DTA.LinkedList;

LinkedList linkedList = new LinkedList();

linkedList.insertFirst(3);
linkedList.insertFirst(5);
linkedList.insertFirst(7);
linkedList.insertFirst(9);
linkedList.insertFirst(10);

linkedList.DisplayList();

Console.WriteLine("after deleting two nodes");

linkedList.DeleteFirst();
linkedList.DeleteFirst();


linkedList.DisplayList();

Console.WriteLine("after inserting at the last");

linkedList.InsertLast(111);

linkedList.DisplayList();