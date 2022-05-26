// VALUE TYPES 
// Value types are stored in the stack.

// BOOLS and CHARS

bool isDeclared; // Declaring a variable - not assinging it a value.
isDeclared = true; // Assigning a value to an existing variable.

bool isDeclaredandInitialized = true;

char character = 'a'; // Single Quotes for chars in c#.
char symbol = '?';
char number = '7';
char space = ' ';
char specialCharacter = '\n'; // This is the New LINE char.

// WHOLE NUMBERS USE THE DATA TYPE THAT TAKES UP THE LEAST AMOUNT OF MEMORY 

byte age = 89; // BYTES can't be negative - max out at 255
sbyte negativeAge = -20; // -127 to 127 (signed byte)

short shortExample = 3245;

int someNumber =12; //No quotes or suffixes for WHOLE NUMBERS
int max = 2147483647; 
uint unsignedInt = 28; //unsigned int

long bigWholeNumber = 9223372036854775807;


// FLOATING POINT NUMBERS - not whole numbers - they have decimal places. floats, doubles, decimals.
// FLOATING POINT NUMBERS USE SUFFIXES.

float floatExample = 1.04567896f; //F
double doubleExample = 8.87264395842d; //D
decimal decimalExample = 2.45678946543m; //M

float x = 1.123456789123456789123456789123456789123456789f;
double y = 1.123456789123456789123456789123456789123456789d;
decimal z = 1.123456789123456789123456789123456789123456789m;

// Console.WriteLine(x);
// Console.WriteLine(y);
// Console.WriteLine(z);

// enum PastryType { cake, cupcake, eclair, croissant };

// DATE VALUE TYPES 

// DateTime today = DateTime.Today;
// DateTimeOffSet today = DateTimeOffset.Today;





// REFERENCE TYPES - Types are stored on the HEAP.

string firstName = "Bob";
string lastName = "Darryl";

string concatFullName = firstName + " " + lastName;
string compositeFullName = string.Format("Hi my name is {0} {1}", firstName, lastName);
string interpolFullName = $"{firstName} {lastName}";

Console.WriteLine(concatFullName);
Console.WriteLine(compositeFullName);
Console.WriteLine(interpolFullName);

//ARRAYS

 string[] stringArray = { "hello", "world", "!"};

Console.WriteLine(stringArray[0]);

// LIST 
List<string> listOfStrings = new List<string>();
listOfStrings.Add("dog");
listOfStrings.Remove("dog");

List<int> listOFINts = new List<int>();

// QUEUES AND DICTIONARIES 
Queue<string> firstInFirstOut = new Queue<string>();

Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
// int would be the key and string is the value.

keyAndValue.Add(7, "Agent");

Console.WriteLine(keyAndValue[7]);