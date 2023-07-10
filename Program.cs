//Day 1

//declaring variables
int money;
//initialize variable
money = 5;
//combine steps 
bool hungry = true;

//constant
const double taxRate = 0.06; //double allows for decimal points
                             //taxRate = 6;
                             //not allowed to change constants

//mini code problem

Console.WriteLine("Please enter a radius");
//string entry = Console.ReadLine();
//    //console readlines always return a string 
//double value = double.Parse(entry);
double value = double.Parse(Console.ReadLine());
double area = Math.PI * Math.Pow(value, 2);
Console.WriteLine(area);

//Arithmetic in Programming

//increment
//age++;
//age = age + 1;
//age--;
//age = age - 1;

//using modulus to determine odd or even
Console.WriteLine("Please enter a number");
int input = int.Parse(Console.ReadLine()); //int.Parse to convert user input into int
int oddCheck = input % 2;
if (oddCheck == 0)
{
    Console.WriteLine("even");
}
else if (oddCheck == 1)
{
    Console.WriteLine("odd");
}


//assignment
value = 0;
int assign = 5;
Console.WriteLine(assign);
assign += 2;
Console.WriteLine(assign);
assign -= 5;
Console.WriteLine(assign);

//null
string catName = null;
Console.WriteLine(catName);
catName = "Felony";
Console.WriteLine(catName);

//use null to set a default value
string y = null;
if (y == null)
{
    y = "keysmash";
}

//non-nullable variables:
//int z = null;
//the more complex an object is, the more likely it can be null.

/* Today's exercises 
 * EXERCISE 1

Description
Prompt the user to enter a string. After the user enters a string, output the same string back to the console.

Example
>>Enter some text: <<Hello, World! ECHOOOOOO!
>>Hello, World! ECHOOOOOO!

*/

Console.WriteLine("Please enter a string.");
string stringEntry = Console.ReadLine();
Console.WriteLine(stringEntry);

/*
EXERCISE 2

Description
Prompt the user to enter a number. After the user enters a number, add 1 to the number and output it back to the console.

Example
>>Enter a number: <<52
>>53
*/

Console.WriteLine("Please enter a number.");
double number = int.Parse(Console.ReadLine());
number++;
Console.WriteLine(number);

/*
EXERCISE 3

Description
Prompt the user to enter a number. After the user enters a number, add .5 to the number and output it back to the console.

Example
>>Enter a number: <<17.3
>>17.8
*/

Console.WriteLine("Please enter a number.");
double secondNumber = double.Parse(Console.ReadLine());
secondNumber += 0.5;
Console.WriteLine(secondNumber);

/*
EXERCISE 4

Description
Prompt the user to enter two numbers. After the user enters the numbers, add them together and output the sum back to the console.

Example
>>Enter a number: <<12.2
>>Enter another number: <<17.3
>>The sum is 29.5
*/

Console.WriteLine("Please enter a number.");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter another number.");
int numberB = int.Parse(Console.ReadLine());
int sum = numberA + numberB;
Console.WriteLine($"The sum is {sum}.");

/*
EXERCISE 5

Description
Prompt the user to enter two numbers. After the user enters the numbers, multiply them and output the product back to the console.

Example
>>Enter a number: <<10.2
>>Enter another number: <<13.4
>>The product is 136.68
 */

Console.WriteLine("Please enter a number.");
int numberC = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter another number.");
int numberD = int.Parse(Console.ReadLine());
int product = numberC * numberD;
Console.WriteLine($"The product is {product}.");

//inserted Console.ReadLine() as VS for Mac command to stop program
Console.ReadLine();