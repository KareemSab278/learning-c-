// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// using System;

// //Console.WriteLine("Hello, World!");
// //===============================================
// //Random dice = new(); // using the Random method to create the dice object from the random class 
// //int roll = dice.Next(1, 7); // roll is the random number between 1 and 6.

// //int roll1 = dice.Next();
// //int roll2 = dice.Next(101);
// //int roll3 = dice.Next(50, 101);

// //Console.WriteLine(roll);
// //Console.WriteLine($"First roll: {roll1}");
// //Console.WriteLine($"Second roll: {roll2}");
// //Console.WriteLine($"Third roll: {roll3}");

// //int roll4 = dice.Next(100);
// //String roll4string = roll4.ToString();
// //Console.WriteLine($"Fourth roll: {roll4string}");

// //===============================================

// //int firstValue = 500;
// //int secondValue = 600;
// //int largerValue = Math.Max(firstValue, secondValue);

// //Console.WriteLine(largerValue);

// //int total = roll1 + roll2 + roll3 + roll4;

// //===============================================

// //if (total > 14)
// //{
// //    Console.WriteLine("You win!");
// //}

// //if (total < 15)
// //{
// //    Console.WriteLine("Sorry, you lose.");
// //}

// //===============================================

// //string message = "The quick brown fox jumps over the lazy dog.";
// //bool result = message.Contains("dog");
// //Console.WriteLine(result);

// //if (message.Contains("fox")){
// //    Console.WriteLine("What does the fox say?");
// //    Console.Write("Awoo?");
// //}
// //else
// //{
// //    Console.WriteLine("The fox is not here.");
// //}

// //===============================================

// //string[] fraudulentOrderIDs = new string[3];

// //fraudulentOrderIDs[0] = "A123";
// //fraudulentOrderIDs[1] = "B456";
// //fraudulentOrderIDs[2] = "C789";

// //string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

// //foreach (string item in fraudulentOrderIDs)
// //{
// //    Console.WriteLine(item);
// //}

// //===============================================

// //int[] inventory = { 200, 450, 700, 175, 250 };
// //int totalInventory = 0;

// //foreach (int number in inventory)
// //{
// //    totalInventory += number;
// //}
// //Console.WriteLine($"Total inventory: {totalInventory}");

// //===============================================

// //string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// //foreach (string orderID in orderIDs)
// //{
// //    if (orderID.StartsWith("B"))
// //    {
// //        Console.WriteLine(orderID);
// //    }
// //}

// //===============================================

// int[] sophia = [90, 86, 87, 98, 100];
// int[] andrew = [92, 89, 81, 96, 90];
// int[] emma = [90, 85, 87, 98, 68];
// int[] logan = [90, 95, 87, 88, 96];

// decimal emmaTotal = 0; decimal sophiaTotal = 0; decimal andrewTotal = 0; decimal loganTotal = 0;

// int gradesCount = emma.Length;

// foreach (int i in Enumerable.Range(0, gradesCount))
// {
//     sophiaTotal += sophia[i];
//     andrewTotal += andrew[i];
//     emmaTotal += emma[i];
//     loganTotal += logan[i];
// }

// decimal[] grades = [sophiaTotal / gradesCount, andrewTotal / gradesCount, emmaTotal / gradesCount, loganTotal / gradesCount];
// string[] mark = new string[5]; //declare the array with 5 elements

// List <string> marks = new List<string>(); // first ever list. they seem better than arrays ngl...

// foreach (int i in Enumerable.Range(0, grades.Length))
// {
//     if (grades[i] > 95) marks.Add("A+");
//     else if (grades[i] > 90) marks.Add("A");
//     else if (grades[i] > 85) marks.Add("B+");
//     else if (grades[i] > 80) marks.Add("B");
//     else if (grades[i] > 75) marks.Add("C+");
//     else if (grades[i] > 70) marks.Add("C");
//     else if (grades[i] > 65) marks.Add("D+");
//     else if (grades[i] > 60) marks.Add("D");
//     else if (grades[i] < 60) marks.Add("F");
//     else marks.Add("?");
// }

// //Console.WriteLine($"Sophia's average: {sophiaTotal / gradesCount}, {marks[0]}");
// //Console.WriteLine($"Andrew's average: {andrewTotal / gradesCount}, {marks[1]}");
// //Console.WriteLine($"Emma's average: {emmaTotal / gradesCount}, {marks[2]}");
// //Console.WriteLine($"Logan's average: {loganTotal / gradesCount}, {marks[3]}");

// //===============================================

// Random coin = new();
// int flip = coin.Next(1,3);
// Console.WriteLine((flip > 1) ? "Heads" : "Tails");  //ternary operator

// //===============================================

// // bool flag = true;
// // int value;

// // if (flag)
// // {
// //     value = 10;
// //     //Console.WriteLine($"Inside the code block: {value}");
// // }

// // Console.WriteLine($"Outside the code block: {value}");

// //===============================================

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// foreach (int number in numbers)
// {
//     total += number;
// }

// if(numbers.Contains(42)) Console.WriteLine("Set contains 42");
// Console.WriteLine($"Total: {total}");

// //===============================================

// int employeeLevel = 200;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//         title = "Junior Associate";
//         break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// //===============================================

// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch(product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch(product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// switch(product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// // Console.WriteLine($"Product: {size} {color} {type}");

// //===============================================

// // for (int i = 0; i < 10; i++)
// // {
// //     Console.WriteLine(i);
// // }

// // string[] names = { "Alex", "Eddie", "David", "Michael" };
// // for (int i = names.Length - 1; i >= 0; i--)
// // {
// //     Console.WriteLine(names[i]);
// // }

// //===============================================

// // for(int i = 0; i<40; i++)
// // {
// //     if(i % 5 == 0 && i % 3 == 0) Console.WriteLine(" - fizzbuzz");

// //     else if(i%5 == 0) Console.WriteLine(" - buzz");

// //     else if(i%3 == 0) Console.WriteLine(" - fizz");
// // }

// //===============================================

// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7); // keep logging until you hit 7

// //===============================================

// // the ourAnimals array will store the following: 
// string animalSpecies = "";
// string animalID = "";
// string animalAge = "";
// string animalPhysicalDescription = "";
// string animalPersonalityDescription = "";
// string animalNickname = "";

// // variables that support data entry
// int maxPets = 8;
// string? readResult;
// string menuSelection = "";

// string[,] ourAnimals = new string[maxPets, 6]; //2d array

// //===============================================

// int[] data; // Declares a reference to an int array. The reference (not the array) is stored on the stack.
// data = new int[3]; // Allocates the array (actual data) on the heap. The reference on the stack now points to it.

// //===============================================

// string first = "5";
// string second = "7";
// int sum = Convert.ToInt32(first) + int.Parse(second); // .Parse method to convert data types and Convert.ToInt32 to do the same
// Console.WriteLine(sum);

// //===============================================

// // string value = "can't be a number";
// // int result;

// // bool success = int.TryParse(value, out result); // doesnt throw an error if value cant be converted to a number

// // if (success)
// // {
// //     Console.WriteLine("Measurement: " + result);
// // }
// // else
// // {
// //     Console.WriteLine("Unable to report the measurement.");
// // }

// // if (result > 0)
// // {
// //     Console.WriteLine("Measurement (w/ offset): " + (50 + result));
// // }

// //===============================================

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// decimal total = 0; string message = ""; decimal result;

// foreach(string value in values)
// {
//     bool success = decimal.TryParse(value, out result);

//     if(success) total+=result;
//     else message += value;
// };

// Console.WriteLine($"total: {total}");
// Console.WriteLine($"message: {message}");

//===============================================           Arrays

// string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Array.Sort(pallets);
// Array.Reverse(pallets);
// Console.WriteLine(String.Join(", ", pallets));

//===============================================

// Array.Clear(pallets, 0, 1);
// Console.WriteLine(String.Join(" ", pallets));

//===============================================

// Console.WriteLine(pallets.Length);
// Array.Resize(ref pallets, 6);   // changes the length of the array
// Console.WriteLine(pallets.Length);

//===============================================

// string sentence = "The quick brown fox jumps over the lazy dog"; // this was so f**king hard coming from js... apparently you CANT split by each individual charachter but have to put it into an array of char value types bruhhhhhhh;
// string[] words = sentence.Split(' ');

// for (int i = 0; i < words.Length; i++) {
//     char[] chars = words[i].ToCharArray();
//     Array.Reverse(chars);
//     words[i] = new string(chars);
// }

// Console.WriteLine(string.Join(" ", words));

//===============================================

// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second); // yeah..... this can get confusing for some lol...

//===============================================

// Console.WriteLine(first.IndexOf("o"));  // find the index of an elem in the str;

// string text = "Hello World";
// string part = text.Substring(6); // writes right after elem 6
// string shorterpart = text.Substring(6,3); // writes right after elem 6 + 2 more
// Console.WriteLine(part);
// Console.WriteLine(shorterpart);

//===============================================

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

//===============================================

string test = "  --i='m full of -bad stuff--.";
test = test.Replace("=", "").Trim().Trim('-').Replace("-", "");
// Console.WriteLine(test);

//===============================================       Methods

// void Greet(string name, int age)
// {
//     Console.WriteLine($"Hi {name}, you are {age} years old."); // methods are pascal case
// }

// Greet("Bob", 30);

//===============================================

// Math.Abs gives you the absolute value of a number

// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// Console.WriteLine($"Total: ${total}");

// double GetDiscountedPrice(int itemIndex)
// {
//     return items[itemIndex] * (1 - discounts[itemIndex]); // so you cant use void Method if you are using return, only if you are printing the output.
// }

// bool TotalMeetsMinimum()
// {
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     return input.ToString().Substring(0, 5);
// }

//===============================================

double usd = 23.73;
double vnd = UsdToVnd(usd);

// Console.WriteLine($"${usd} USD = ${vnd} VND");

double UsdToVnd(double usd) 
{
    double rate = 23500;
    return (double) (rate * usd);
}

//===============================================

public class CropRatio
{
    private int totalWeight = 0;
    private Dictionary<string, int> crops = new Dictionary<string, int>();

    public void Add(string name, int cropWeight)
    {
        if(!crops.ContainsKey(name)) crops[name]=0;
        crops[name] += cropWeight;
        totalWeight += cropWeight;
    }


    public double Proportion(string name)
    {
        if(!crops.ContainsKey(name)) return 0;
        return (double)crops[name] / totalWeight;
    }

    public static void Main(string[] args)
    {
        CropRatio cropRatio = new CropRatio();

        cropRatio.Add("Wheat", 4);
        cropRatio.Add("Wheat", 5);
        cropRatio.Add("Rice", 1);

        Console.WriteLine("Ratio of wheat: {0}", cropRatio.Proportion("Wheat"));
    }
}

//===============================================

// try
// {
//     int result = 10 / 0; // will throw an exception
// }
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine("Error: Division by zero.");
// }
// finally
// {
//     Console.WriteLine("This runs no matter what.");
// }

//===============================================

// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     try
//     {
//         WriteMessage();
//     }
//     catch
//     {
//         Console.WriteLine("Exception caught in Process1");
//     }

// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;

//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }

//===============================================
partial class Program{
    static string MakeChange(int cost, int[] cashTill, int twenties, int tens = 0, int fives = 0, int ones = 0)
{
     string transactionMessage = "";

        cashTill[3] += twenties;
        cashTill[2] += tens;
        cashTill[1] += fives;
        cashTill[0] += ones;

        int amountPaid = twenties * 20 + tens * 10 + fives * 5 + ones;
        int changeNeeded = amountPaid - cost;

    if (changeNeeded < 0)
        transactionMessage = "Not enough money provided.";

    Console.WriteLine("Cashier Returns:");

    while ((changeNeeded > 19) && (cashTill[3] > 0))
    {
        cashTill[3]--;
        changeNeeded -= 20;
        Console.WriteLine("\t A twenty");
    }

    while ((changeNeeded > 9) && (cashTill[2] > 0))
    {
        cashTill[2]--;
        changeNeeded -= 10;
        Console.WriteLine("\t A ten");
    }

    while ((changeNeeded > 4) && (cashTill[1] > 0))
    {
        cashTill[1]--;
        changeNeeded -= 5;
        Console.WriteLine("\t A five");
    }

    while ((changeNeeded > 0) && (cashTill[0] > 0))
    {
        cashTill[0]--;
        changeNeeded--;
        Console.WriteLine("\t A one");
    }

    if (changeNeeded > 0)
        transactionMessage = "Can't make change. Do you have anything smaller?";

    if (transactionMessage == "")
        transactionMessage = "transaction succeeded";

    return transactionMessage;
}
} // cringe ahh code

//===============================================

// https://www.freecodecamp.org/certification/KareemSab278/foundational-c-sharp-with-microsoft
