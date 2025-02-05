// See https://aka.ms/new-console-template for more information

/*Console.WriteLine("what's your name?");
var name =Console.ReadLine();
Console.WriteLine($"your input is : {name} " );

Console.WriteLine("When were you born?");
var birthYear =Console.ReadLine();
if (birthYear != null)
{
    try
    {
        var ageInt = int.Parse(birthYear);
        var age =2025-ageInt;
        Console.WriteLine($"You are : {age} years old" );
    }
    catch (Exception e)
    {
        Console.WriteLine("Your input is invalid");
    }

}
else
{
    Console.WriteLine("Your input is null");
}
*/

/*string name="Shadow";
string breed="Golden Retriever";
int age = 5;
double weight = 65.22;
bool spayed = true;

Console.WriteLine(name);
Console.WriteLine(breed);
Console.WriteLine(age);
Console.WriteLine(weight);
Console.WriteLine(spayed);
*/

/*int pizzaShops=4332;

int totalEmployees=86928;

decimal revenue = 390819.28m;

Console.WriteLine(pizzaShops);
Console.WriteLine(totalEmployees);
Console.WriteLine(revenue );
*/
/*int userAge=25;

double jupiterYears=11.86;

double jupiterAge=userAge/jupiterYears;

double journeyToJupiter=6.142466;

double newEarthAge=userAge + journeyToJupiter;

double newJupiterAge=newEarthAge/jupiterYears;

Console.WriteLine(jupiterAge);
Console.WriteLine(newEarthAge);
Console.WriteLine(newJupiterAge);
*/
/*int steps = 0;

steps += 2;

steps -= 1;

Console.WriteLine(steps);
*/

/*int students=18;

int groupSize = 3;

Console.WriteLine(students%groupSize);
*/

/*int numberOne = 12932;
int numberTwo = -2828472;

double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

Console.WriteLine(Math.Min(numberTwoSqrt, numberOneSqrt));
*/

/*string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";

string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

Console.WriteLine(firstSentence);
Console.WriteLine("\n");
Console.WriteLine(firstSpeech);
*/

/*string beginning = "Once upon a time";
string middle = "the kid climbed a tree";
string end = "Everyone lived happily ever after";
string story = beginning + ", " + middle + ". " + end + ".";
Console.WriteLine(story);
string story1 = $"{beginning} it was a beautiful day. {middle} and the birds flew through the sky. {end}";

Console.WriteLine(story1);*/

/*string password = "a92301j2add";
int passwordLength = password.Length;
int passwordCheck= password.IndexOf("!");
Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");
*/

//BubbleSort
/*static int[] Sort(int[] numbers)
{
    for (int i = 0; i < numbers.Length-1; i++)
    {
        for (int j = 0; j < numbers.Length-1 - i; j++)
        {
            if (numbers[j] > numbers[j + 1]) {
                var temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }

        }
    }
    return numbers;
}

var sortedArray= Sort([2, 4, 1, 5, 0, 6, 2]);
Console.WriteLine($"Sorted Array is {string.Join(" ", sortedArray)}");
*/

using System;

class Program
{
    static int BinarySearch(int[] sortedArray, int target)
    {
        int low = 0;                          
        int high = sortedArray.Length - 1;      
        
        while (low <= high)
        {
            int mid = (low + high) / 2;
            
            if (sortedArray[mid] == target)
            {
                return mid; 
            }
            
            else if (sortedArray[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return -1; 
    }

    static void Main()
    {
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        
        Console.Write("Enter a number to search: ");
        int target = Convert.ToInt32(Console.ReadLine());
        
        int index = BinarySearch(numbers, target);
        
        if (index != -1)
        {
            Console.WriteLine("Number found at index: " + index);
        }
        else
        {
            Console.WriteLine("Number not found in the array.");
        }
    }
}

