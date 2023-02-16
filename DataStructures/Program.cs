using DataStructures;
using System.Collections;

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
var bracketExpression = ")(";
Console.WriteLine("Bracket Balanced = " + Expression.IsBalancedBracket(bracketExpression));

//From Scratch
var stk = new StackDs(5);
stk.Push(10);
stk.Push(20);
stk.Push(30);
var lastStackValue = stk.Pop();
stk.Push(40);
var peekValue = stk.Peek();
Console.WriteLine("Stack is empty " + stk.IsEmpty());

Console.WriteLine("----------Two Stack--------------");

var twoStk = new TwoStacks(5);
twoStk.Push1(10);
twoStk.Push1(20);
twoStk.Push1(30);
twoStk.Push2(40);
twoStk.Push2(50);
var pop1 = twoStk.Pop1();
var pop2 = twoStk.Pop1();
var pop3 = twoStk.Pop1();
var pop4 = twoStk.Pop2();
var pop5 = twoStk.Pop2();
Console.WriteLine();

Console.WriteLine("--------------Min Stack ------------");
var minStk = new MinStack(5);
minStk.Push(5);
minStk.Push(2);
minStk.Push(10);
minStk.Push(1);
Console.WriteLine("Min value = " + minStk.Min());
minStk.Pop();
Console.WriteLine("Min value = " + minStk.Min());

#endregion

Console.WriteLine("---------------Queue--------------");

/* Queue */
#region Queue

// Reverse Queue
var queue1 = new Queue();
queue1.Enqueue(10);
queue1.Enqueue(20);
queue1.Enqueue(30);
var reverseQueue = ReverseQueue.Reverse(queue1);
Console.WriteLine("");
#endregion

Console.WriteLine("-----------Array Queue------------");
/* Array Queue */
#region ArrayQueue
var arrQ = new ArrayQueue(5);
arrQ.Enqueue(10);
arrQ.Enqueue(20);
arrQ.Enqueue(30);
arrQ.Enqueue(40);
arrQ.Dequeue();
arrQ.Dequeue();
var first = arrQ.Peek();
arrQ.Enqueue(50);
arrQ.Enqueue(60);
arrQ.Enqueue(70);
Console.WriteLine("");
arrQ.Reverse(3);
#endregion

Console.WriteLine("-----------Stack Queue------------");
/* Stack Queue */
#region Stack Queue
var stkQueue = new StackQueue();
stkQueue.Enqueue(100);
stkQueue.Enqueue(200);
stkQueue.Enqueue(300);
stkQueue.Enqueue(400);
var top1 = stkQueue.Dequeue();
var top2 = stkQueue.Dequeue();
var top3 = stkQueue.Dequeue();
Console.WriteLine("");
#endregion

Console.WriteLine("-----------Priority Queue----------");
/* Priority Queue */
#region Priority Queue
var prQueue = new PriorityQueue(5);
prQueue.Enqueue(10);
prQueue.Enqueue(50);
prQueue.Enqueue(30);
prQueue.Enqueue(20);
prQueue.Enqueue(40);
var prPop1 = prQueue.Dequeue();
var prPop2 = prQueue.Dequeue();
var prPop3 = prQueue.Dequeue();
var prPop4 = prQueue.Dequeue();
var prPop5 = prQueue.Dequeue();
Console.WriteLine("");
#endregion

Console.WriteLine("----------LinkedList Queue----------");
#region Linked List Queue
var llQueue = new LinkedListQueue();
llQueue.Enqueue(10);
llQueue.Enqueue(20);
llQueue.Enqueue(30);
llQueue.Enqueue(40);
var lstLlEle = llQueue.Peek();
var lstLlEle1 = llQueue.Dequeue();
var lstElePeek = llQueue.Peek();
var lstLlEle2 = llQueue.Dequeue();
Console.WriteLine("Size of ll Queue is " + llQueue.Size());
Console.WriteLine("IsEmpty value of ll Queue is " + llQueue.IsEmpty());
#endregion

Console.WriteLine("----------StackWithTwoQueues---------");
#region StackWithTwoQueues
var stkWithQ = new StackWithTwoQueues();
stkWithQ.Push(10);
stkWithQ.Push(20);
stkWithQ.Push(30);
stkWithQ.Push(40);
var popstk1 = stkWithQ.Pop();
Console.WriteLine("");
#endregion

Console.WriteLine("----First Non-Repeatitve Character Question (Dictionary)-----");
#region Non Repeating Character Question
var dummyString = "a mercedes car";
var charFinder = new CharFinder();
var nonRepitiveChar = charFinder.FindFirstNonRepatingChar(dummyString);
Console.WriteLine("First non repititive char is " + nonRepitiveChar);
#endregion

Console.WriteLine("----First Repeatitve Character Question (HashSet)-----");
#region First Repeating Character Question
var dummyString1 = "green apple";
var charFinder1 = new CharFinder();
var repitiveChar = charFinder1.FirstRepeatedCharacter(dummyString1);
Console.WriteLine("First repititive char is " + repitiveChar);
#endregion

Console.WriteLine("---------------Hash Table------------");
/* Hash Table */
#region Hash Table
var hst = new HashTableDs(5);
hst.Put(1, "first");
hst.Put(1, "first updated");
hst.Put(11, "second");
hst.Remove(11);
hst.Put(16, "third");
hst.Put(2, "fourth");
hst.Put(12, "fifth");
hst.Put(17, "sixth");
hst.Remove(17);
var hst1 = hst.Get(1);
var hst2 = hst.Get(2);
var hst22 = hst.Get(12);
var hst23 = hst.Get(21);
Console.WriteLine("");


Console.WriteLine("---------------Hash Table Exercise------------");
var hstExer = new HashTableExercises();
Console.WriteLine("Most Frequent no is " + hstExer.MostFrequent(new int[7] { 1, 2, 2, 3, 4, 4, 4 }));
Console.WriteLine("Total unique pairs is " + hstExer.CountPairsWithDiff(new int[7] { 1, 7, 5, 9, 2, 12, 3 }, 2));
var twoSumResult = hstExer.TwoSum(new int[4] { 2, 7, 11, 15 }, 18);
Console.WriteLine("Two Sum indices are");
twoSumResult.ToList().ForEach(x => Console.Write(x + " "));
#endregion
