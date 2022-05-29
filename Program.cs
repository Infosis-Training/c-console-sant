// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//Intigir
byte a = 23;  //max-255
short b = 3534;
int c = 25235523;
long d = 135050150654;


//Decimal
float e = 10.54f;  // support less decimal about --7-8 number. need to add f at end.
double f = 25448.56; // support higher number after decimal (more than 15)
decimal g = 45467809.5046360044m; // support higher number after decimal than double, suffix m

//String
bool h = true; // or false
char i = 'S'; //single character
string j = "Sant Bohara"; //Any text line

//Nullable Type
int? k = 1; //Nullabe type, if value may be null in case


//Make Method, call from another calss 
Person person1 = new();
person1.Speak();

Person person2 = new();
person2.name = "Sant";
person2.Walk();

Person person3 = new();
person3.name = "Ram";
person3.Eat();

while(k<5){
    Console.WriteLine(k);
    k++;