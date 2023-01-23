﻿using DataStructures;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, Welcome to Data Structures!");

Console.WriteLine("--------------Arrays--------------");

/* Arrays */
#region
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
#region
var ll = new LinkedListDs();
ll.AddLast(10);
ll.AddFirst(20);
ll.AddFirst(30);
ll.AddLast(40);
ll.AddLast(50);
ll.RemoveFirst();
ll.RemoveLast();
Console.WriteLine("Index of 10 is " + ll.IndexOf(10));
Console.WriteLine("Contains 30 " + ll.Contains(30));
ll.Print();
#endregion