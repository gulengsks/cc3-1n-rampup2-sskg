using System;

namespace Rampup2
{
internal class Program
{
private static double weight_in_pounds;

static void Main(string[] args)
{
Console.WriteLine("Enter weight in pounds");
Console.WriteLine("========================================================");
double weight_in_pounds = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Weight in kilograms = " + (weight_in_pounds * 0.453592));
Console.WriteLine("===============End of weight converter!!==================");

//Declares a private static variable weight_in_pounds of type double to store the user's input in pounds.//
//The Main method is where the execution begins.//
//Displays a message asking the user to enter their weight in pounds.//
//Reads the user's input from the console, converts it to a double, and stores it in the local variable weight_in_pounds. //
//Converts the user's input from pounds to kilograms by multiplying it with the conversion factor (1 pound = 0.453592 kilograms) and then prints the result.//
//Displays a message indicating the end of the weight converter.//


Console.WriteLine("Enter distance in miles");
Console.WriteLine("==========================================================");
double distance_in_miles = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Distance in Miles (mi) = " + distance_in_miles);
Console.WriteLine("Distance in Kilometers (km) = " + (distance_in_miles * 1.60934));
Console.WriteLine("=========End of the distance and miles converter!!==========");

//Displays a message asking the user to enter a distance in miles.//
//Reads the user's input from the console, converts it to a double, and stores it in the variable distance_in_miles.//
//Prints the entered distance in miles.//
//Converts the entered distance from miles to kilometers by multiplying it with the conversion factor (1 mile = 1.60934 kilometers) and then prints the result.//
//Displays a message indicating the end of the distance converter.//

Console.WriteLine("Enter temperature in Fahrenheit");
Console.WriteLine("============================================================");
double temperature_in_fahrenheit = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Celsius (°C) = " + (temperature_in_fahrenheit - 32) * 5 / 9);
Console.WriteLine("=============End of the temperature converter!!============");

//Displays a message asking the user to enter a temperature in Fahrenheit.//
//Reads the user's input from the console, converts it to a double, and stores it in the variable temperature_in_fahrenheit.//.
//Converts the entered temperature from Fahrenheit to Celsius using the formula (Fahrenheit - 32) * 5 / 9 and then prints the result.//
//Displays a message indicating the end of the temperature converter.

int numberOfStudents = 10;
int sum = 0;

Console.WriteLine("Enter ages of 10 students:");

for (int i = 0; i < numberOfStudents; i++)
{
Console.Write($"Student {i + 1}: ");
int age = Convert.ToInt32(Console.ReadLine());
sum += age;
Console.WriteLine($"Student {i + 1} age: {age} years");
}

double averageAge = (double)sum / numberOfStudents;
Console.WriteLine($"Average age of students: {averageAge}");
Console.WriteLine("==================End of the student ages!!===================");

//Initializes two variables: numberOfStudents represents the total number of students, and sum is used to accumulate the ages of the students.//
//Displays a message prompting the user to enter the ages of 10 students.//
//Enters a loop that iterates 10 times (for each student). In each iteration://
//converts the age.//
//adds the sum.//
//print the entered age for the current student.//

Console.WriteLine("==========================Story======================================");
//Characters//
string char1 = "Sean";
string char2 = "Girmille";
string char3 = "Esteven";
string char4 = "Elton";
string char5 = "Brent";
//Weapons//
string weaponSean = "Royal Claymore";
string weaponGirmille = "Ethereal Longbow";
string weaponElton = "Cresent Blades";
string weaponEsteven = "Arcane Scepter";
string weaponBrent = "Verdant Halberd";
//Abilities//
string abSean = "Aegis Strike";
string abGirmille = "Celestial Volley";
string abElton = "Shadow Dance";
string abEsteven = "Nova Blast";
string abBrent = "Earthern embrace";

Console.WriteLine($"In the majestic realm of Veloria, a kingdom embroiled in the echoes of ancient battles, five valiant knights rose to defend their land. {char1} 'The Stalwart leader' (equipped with {weaponSean}), a mighty sword from the metal of the astral forge. sean's {abSean} allowed him to create a protective barrier, sheilding his comrades in the battlefield.\n");
Console.WriteLine($"{char2}, 'The swift and precise elf knight' wielded {weaponGirmille} weapon imbued with the power of the Silvermoon. Girmille's unmatched marksmanship and the {abGirmille} allowed her to rain arrows in the air with uncanny accuracy.{char3}, 'The nimble rouge knight fought with {weaponElton} known for its dazzling agility. His {abElton} rendered him elusive, allowing him to weave through enemy ranks unseen, delivering swift strikes from the shadows.{char4} 'The sorcerer knight', carried the {weaponEsteven} a staff crackling with the energies of the Arcane Rift. His magical prowess and the {abEsteven} unleashed devastating bursts of arcane power, scattering adversaries on the battlefield.{char5}, 'The wise druid' bore the {weaponBrent} polearm adorned the nature's blessings. with the {abBrent}, Brent could summon entangling vines and roots to immobilize foes, turning the tide of the battle in favor of Valoria. Together, these five knights stood as the vanguard of the kingdom, their weapons and abilities weaving a tapestry of defense against any threat that dared to challenge the sovereignty of Valoria.'\n");
Console.WriteLine("====================End of The story!!====================");

//Sets up strings for character names, weapons, and abilities for each of the five knights.//
//Starts the narration of the story, introducing the kingdom and the valiant knights.//
//Describes each knight, their title, equipped weapon, and special ability. The \n is a newline character to format the text.
//Continues discribing the other knights in a similar fashion//
//Marks the end of the story with a concluding message.//

if (int.TryParse(Console.ReadLine(), out int input) && input > 0)
            {
                for (int i = 1; i <= input; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid Input. ");
            }

//Get's the user input and converts it to integer using Parse.And also checks if the input is greater than zero.//
//if false it will print invalid input.//
//if true it will execute the outer loop.//
//int i means inizialized to 1.//
//if i is lesser than equal to input it would incriment to one until input.//
//for the inner loop integer j inizialized to 1 if j is lesser than or equal to i. it would incriment to 1 until i.//
//in the inner loop it would print until the value of i. and after that it will make a new line.//
 if (int.TryParse(Console.ReadLine(), out input) && input >= 1)
            {
                int sum1 = 0;

                
                for (int i = 1; i <= input; i++)
                {
                    sum1 += i;
                }
  Console.WriteLine($"The sum of integers from 1 to {input} is: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }

//gets the user input and converts to integer using tryParse and the out parameter is used for the reason that it can evaluate to false or true.//
//the integer variable is inizialized to 0. so if the loop is true it will execute the for loop. and if the input is greater than 1 it would incriment until it reaches the value of intput.//
//and for every iteration it will add until the value of i and assign it to variable sum.//
//if false invalid input.//
            
            Console.WriteLine("Enter a number:");
            if (int.TryParse(Console.ReadLine(), out input) && input > 0)
            {
                for (int i = input; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }

////gets the user and converts it into integer. and checks  if its greater than zero.//
//if false it will print invalid input.//
//if true it will execute the for loop.//
//so if the input is 5 in the outer loop. and i is inizialized to 5.//
//i is greater than or equal to 1 it will decriment to 1.//
//for the inner j is inizialized to 1.//
//if j is lesser than or equal to i, it incriments to 1.//
//it prints the inner loop j and makes a new line.//
//so it will iterate until it reaches the integer 5.//
            



}
}
}
