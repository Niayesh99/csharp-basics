// See https://aka.ms/new-console-template for more information

Console.WriteLine("what's your name?");
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