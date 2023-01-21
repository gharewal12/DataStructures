using DataStructures;

Console.WriteLine("Hello, Welcome to Data Structures!");

/* Arrays */
#region
var numbers = new ArrayDs<int>(3);
numbers.Insert(10);
numbers.Insert(20);
numbers.Insert(30);
numbers.Insert(40);
Console.WriteLine("Index of 30 = " + numbers.IndexOf(30));
numbers.RemoveAt(3);
numbers.Print();
#endregion