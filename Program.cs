using System;

//Console.WriteLine("Hello, World!");
//===============================================
//Random dice = new(); // using the Random method to create the dice object from the random class 
//int roll = dice.Next(1, 7); // roll is the random number between 1 and 6.

//int roll1 = dice.Next();
//int roll2 = dice.Next(101);
//int roll3 = dice.Next(50, 101);

//Console.WriteLine(roll);
//Console.WriteLine($"First roll: {roll1}");
//Console.WriteLine($"Second roll: {roll2}");
//Console.WriteLine($"Third roll: {roll3}");

//int roll4 = dice.Next(100);
//String roll4string = roll4.ToString();
//Console.WriteLine($"Fourth roll: {roll4string}");

//===============================================

//int firstValue = 500;
//int secondValue = 600;
//int largerValue = Math.Max(firstValue, secondValue);

//Console.WriteLine(largerValue);

//int total = roll1 + roll2 + roll3 + roll4;

//===============================================

//if (total > 14)
//{
//    Console.WriteLine("You win!");
//}

//if (total < 15)
//{
//    Console.WriteLine("Sorry, you lose.");
//}

//===============================================

//string message = "The quick brown fox jumps over the lazy dog.";
//bool result = message.Contains("dog");
//Console.WriteLine(result);

//if (message.Contains("fox")){
//    Console.WriteLine("What does the fox say?");
//    Console.Write("Awoo?");
//}
//else
//{
//    Console.WriteLine("The fox is not here.");
//}

//===============================================

//string[] fraudulentOrderIDs = new string[3];

//fraudulentOrderIDs[0] = "A123";
//fraudulentOrderIDs[1] = "B456";
//fraudulentOrderIDs[2] = "C789";

//string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

//foreach (string item in fraudulentOrderIDs)
//{
//    Console.WriteLine(item);
//}

//===============================================

//int[] inventory = { 200, 450, 700, 175, 250 };
//int totalInventory = 0;

//foreach (int number in inventory)
//{
//    totalInventory += number;
//}
//Console.WriteLine($"Total inventory: {totalInventory}");

//===============================================

//string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

//foreach (string orderID in orderIDs)
//{
//    if (orderID.StartsWith("B"))
//    {
//        Console.WriteLine(orderID);
//    }
//}

//===============================================

int[] sophia = [90, 86, 87, 98, 100];
int[] andrew = [92, 89, 81, 96, 90];
int[] emma = [90, 85, 87, 98, 68];
int[] logan = [90, 95, 87, 88, 96];

decimal emmaTotal = 0; decimal sophiaTotal = 0; decimal andrewTotal = 0; decimal loganTotal = 0;

int gradesCount = emma.Length;

foreach (int i in Enumerable.Range(0, gradesCount))
{
    sophiaTotal += sophia[i];
    andrewTotal += andrew[i];
    emmaTotal += emma[i];
    loganTotal += logan[i];
}

decimal[] grades = [sophiaTotal / gradesCount, andrewTotal / gradesCount, emmaTotal / gradesCount, loganTotal / gradesCount];
string[] mark = new string[5]; //declare the array with 5 elements

List <string> marks = new List<string>(); // first ever list. they seem better than arrays ngl...

foreach (int i in Enumerable.Range(0, grades.Length))
{
    if (grades[i] > 95) marks.Add("A+");
    else if (grades[i] > 90) marks.Add("A");
    else if (grades[i] > 85) marks.Add("B+");
    else if (grades[i] > 80) marks.Add("B");
    else if (grades[i] > 75) marks.Add("C+");
    else if (grades[i] > 70) marks.Add("C");
    else if (grades[i] > 65) marks.Add("D+");
    else if (grades[i] > 60) marks.Add("D");
    else if (grades[i] < 60) marks.Add("F");
    else marks.Add("?");
}

//Console.WriteLine($"Sophia's average: {sophiaTotal / gradesCount}, {marks[0]}");
//Console.WriteLine($"Andrew's average: {andrewTotal / gradesCount}, {marks[1]}");
//Console.WriteLine($"Emma's average: {emmaTotal / gradesCount}, {marks[2]}");
//Console.WriteLine($"Logan's average: {loganTotal / gradesCount}, {marks[3]}");

//===============================================

Random coin = new();
int flip = coin.Next(1,3);
Console.WriteLine((flip > 1) ? "Heads" : "Tails");  //ternary operator

//===============================================

bool flag = true;
int value;

if (flag)
{
    value = 10;
    //Console.WriteLine($"Inside the code block: {value}");
}

// Console.WriteLine($"Outside the code block: {value}");

//===============================================

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
foreach (int number in numbers)
{
    total += number;
}

if(numbers.Contains(42)) Console.WriteLine("Set contains 42");
Console.WriteLine($"Total: {total}");

//===============================================

