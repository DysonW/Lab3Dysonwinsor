Console.Clear();
Console.WriteLine("This is a game of guessing numbers. there may be more then 1 correct number, so don't stop guessing!");
Console.WriteLine("You can Be done at any time by typing exit.");
//While Loop
bool Number1 = true;
while(Number1 == true){
Console.WriteLine("Pick a number between 10 and 99");

string Guess1 = Console.ReadLine();

if(Guess1 == "exit" || Guess1 == "Exit"){
Console.WriteLine("Thank you for Playing!!");
System.Environment.Exit(0);
}
else{
int number = int.Parse (Guess1);
if(number > 99 || number < 10){
    Console.WriteLine("I'm sorry, I can't read that.");
}

else if(number % 23 == 0){
Console.BackgroundColor = ConsoleColor.Green;
Console.Clear();
Console.WriteLine("You have guessed it!!");
Number1 = false;
break;
}

else if(number % 23 != 0){
Console.BackgroundColor = ConsoleColor.Red;
Console.Clear();
Console.WriteLine("Wrong guess, but close! Keep trying!!");
}
}
}



//Do While Loop
Console.Clear();
Console.WriteLine("Congrats, On to Round 2!");
Console.WriteLine("You can Be done at any time by typing exit.");
bool Number2 = true;
do {
Console.WriteLine("Pick a Number between 10 and 99!");
string Guess2 = Console.ReadLine();

if(Guess2 == "exit" || Guess2 == "Exit"){

Console.WriteLine("Thank you for Playing!!");
Number2 = false;
System.Environment.Exit(0);
}
else{
int number = int.Parse (Guess2);
if(number > 99 || number < 10){
    Console.WriteLine("I'm sorry, I can't read that.");
}

else if(number % 34 == 0){
Console.BackgroundColor = ConsoleColor.Green;
Console.Clear();
Console.WriteLine("You have guessed it!!");
Number2 = false;
}

else if(number % 34 != 0){
Console.BackgroundColor = ConsoleColor.Red;
Console.Clear();
Console.WriteLine("Wrong guess, but close! Keep trying!!");
}
}
}
while(Number2 == true);


//For Loop\
Console.WriteLine("Congrats!!! Now on to Round 3!!");
for(bool Number3 = true;Number3; ){
Console.WriteLine("Choose a number between 10 and 99");

string Guess2 = Console.ReadLine();

if(Guess2 == "exit" || Guess2 == "Exit"){

Console.WriteLine("Thank you for Playing!!");
Number3 = false;
System.Environment.Exit(0);
}
else{
int number = int.Parse (Guess2);
if(number > 99 || number < 10){
    Console.WriteLine("I'm sorry, I can't read that.");
}

else if(number % 33 == 0){
Console.BackgroundColor = ConsoleColor.Green;
Console.Clear();
Console.WriteLine("You have guessed it!!");
Number3 = false;
}

else if(number % 33 != 0){
Console.BackgroundColor = ConsoleColor.Red;
Console.Clear();
Console.WriteLine("Wrong guess, but close! Keep trying!!");
}
}
}
Console.WriteLine("Congrats!!! You have won!!");



Console.WriteLine("On another note, for the lab, we must create a menu with a switch statement.");
bool Switch1 = true;
Console.WriteLine("What would you like to do?");
Console.WriteLine("1. Add\n2. Subtract\n3. Multiply\n4. Divide\n");



do{
Console.WriteLine("1. Add\n2. Subtract\n3. Multiply\n4. Divide\n");
string answer = Console.ReadLine();

switch(answer){

case "exit":
Console.WriteLine("Thank you for playing");
    Switch1 = false;
    System.Environment.Exit(0);
break;

case "1":
Addition();
break;

case "2":
Subtraction();
break;

case "3":
Multiply();
break;

case "4":
Divide();
break;

default:
Console.WriteLine("I can't read that!");
break;
}
}

while(Switch1);


void Multiply(){
Console.WriteLine("What is the first number that you would like to use?");
int first = int.Parse (Console.ReadLine());
Console.WriteLine("What is the second number that you would like to use?");
int second = int.Parse (Console.ReadLine());
Console.WriteLine("Okie dokie, let me do some math real quick.");
Console.WriteLine("This is the Aswer we got for you");
float answer = first * second;
Console.WriteLine($"{first} * {second} = {answer}");
Console.ReadLine();
}
 
void Divide(){
Console.WriteLine("What is the first number that you would like to use?");
int first = int.Parse (Console.ReadLine());
Console.WriteLine("What is the second number that you would like to use?");
int second = int.Parse (Console.ReadLine());
Console.WriteLine("Okie dokie, let me do some math real quick.");
Console.WriteLine("This is the Aswer we got for you");
float answer = first / second;
Console.WriteLine($"{first} / {second} = {answer}");
Console.ReadLine();
 }

void Addition(){
Console.WriteLine("What is the first number that you would like to use?");
int first = int.Parse (Console.ReadLine());
Console.WriteLine("What is the second number that you would like to use?");
int second = int.Parse (Console.ReadLine());
Console.WriteLine("Okie dokie, let me do some math real quick.");
Console.WriteLine("This is the Aswer we got for you");
float answer = first + second;
Console.WriteLine($"{first} + {second} = {answer}");
Console.ReadLine();
}

void Subtraction(){
Console.WriteLine("What is the first number that you would like to use?");
int first = int.Parse (Console.ReadLine());
Console.WriteLine("What is the second number that you would like to use?");
int second = int.Parse (Console.ReadLine());
Console.WriteLine("Okie dokie, let me do some math real quick.");
Console.WriteLine("This is the Aswer we got for you");
float answer = first - second;
Console.WriteLine($"{first} - {second} = {answer}");
Console.ReadLine();
}



