using System.Collections.Generic;
using System.ComponentModel;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");;

// Arrays in C#endregion

Console.WriteLine("----------------");
Console.WriteLine("Three Basic Arrays");
Console.WriteLine("----------------");

Console.WriteLine("----------------");
Console.WriteLine("Three Basic - One");
Console.WriteLine("----------------");

int[] SecondArray; 
SecondArray = new int[] {1,2,3,4,5,6,7,8,9,10};

for(int i = 0; i < SecondArray.Length; i++)
{
  Console.WriteLine(SecondArray[i]);
}

Console.WriteLine("----------------");
Console.WriteLine("Three Basic - Two");
Console.WriteLine("----------------");

// Declare Data Type List, then the data type in the list
// List<GameObjects>
List<string> myStrings = new List<string>();

myStrings.Add("Tim");
myStrings.Add("Martin");
myStrings.Add("Nikki");
myStrings.Remove("Sarah");

for(int i = 0; i < myStrings.Count; i++)
{
  Console.WriteLine(myStrings[i]);
}


Console.WriteLine("----------------");
Console.WriteLine("Three Basic - Three");
Console.WriteLine("----------------");

bool[] boolArray = new bool[10];

for(int i = 0; i < boolArray.Length; i++)
{
  if(i % 2 == 0)
  {
    boolArray[i] = true;
  }
  else
  {
    boolArray[i] = false;
  }
  Console.WriteLine(boolArray[i]);
}

Console.WriteLine("----------------");
Console.WriteLine("Lists");
Console.WriteLine("----------------");


List<string> iceCream = new List<string>();
iceCream.Add("Chocolate");
iceCream.Add("Vanilla");
iceCream.Add("Strawberry");
iceCream.Add("Mango");
iceCream.Add("Coffee");
System.Console.WriteLine(iceCream.Count);
System.Console.WriteLine(iceCream[2]);
iceCream.RemoveAt(2);
System.Console.WriteLine(iceCream.Count);



Console.WriteLine("----------------");
Console.WriteLine("Dictionaries");
Console.WriteLine("----------------");

Dictionary<string, string> myDictionary = new Dictionary<string, string>();
myDictionary.Add("Name", "Your Name");
myDictionary.Add("Location", "Your Location");

System.Console.WriteLine(myDictionary["Name"]);
System.Console.WriteLine(myDictionary["Location"]);

foreach(KeyValuePair<string,string> entry in myDictionary)
{
  System.Console.WriteLine($"{entry.Key} - {entry.Value}");
}


