using DataStructures;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, Welcome to Data Structures!");

Console.WriteLine("--------------Arrays--------------");

/* Arrays */
#region Arrays
var numbers = new ArrayDs<int>(4);
numbers.Insert(10);
numbers.Insert(20);
numbers.Insert(30);
numbers.Insert(40);
numbers.Insert(50);
Console.WriteLine("Index of 30 = " + numbers.IndexOf(30));
numbers.RemoveAt(3);
Console.WriteLine("Max = " + numbers.Max());
var array2 = new ArrayDs<int>(3);
array2.Insert(20);
array2.Insert(30);
array2.Insert(50);
var intersection = numbers.Intersect(array2);
Console.WriteLine("Intersection");
intersection.Print();
Console.WriteLine("Array 1");
numbers.Reverse();
numbers.InsertAt(5, 70);
numbers.Print();
#endregion

Console.WriteLine("-----------Linked List------------");

/* Linked Lists*/
#region Linked Lists
var ll = new LinkedListDs();
ll.AddLast(30);
Console.WriteLine("Size = " + ll.Size());
ll.AddFirst(20);
ll.AddFirst(10);
ll.AddLast(40);
ll.AddLast(50);
ll.AddLast(60);
Console.Write("Middle element = ");
ll.PrintMiddle();
var kthValue = ll.GetKthNodeFromEnd(3);
ll.Reverse();
ll.RemoveFirst();
ll.RemoveLast();
Console.WriteLine("Index of 10 is " + ll.IndexOf(10));
Console.WriteLine("Contains 30 " + ll.Contains(30));
Console.WriteLine("Size = " + ll.Size());
var arr = ll.ToArray();
ll.Print();
#endregion

Console.WriteLine("---------------Stack--------------");

/* Stack */
#region Stack

//Reverse the string using stack
string s = "abcd";
var reverseString = StringReverser.Reverse(s);
Console.WriteLine("Reversed string is " + reverseString);

//Balanced Bracket
var bracketExpression = "{([])}[)";
Console.WriteLine("Bracket Balanced = " + Expression.IsBalancedBracket(bracketExpression));
#endregion