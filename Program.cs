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



Console.ReadLine();