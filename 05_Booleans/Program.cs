bool isCool = false;
isCool = true;

// -- Boolean Logical Operators
// Negative Operator 
bool isTrue = !false;
bool isFalse = !true;

// AND Operator 
bool trueAndExample = true && true;
bool falseAndExample = true && false;

// OR Operator 
bool trueOrExample = true || false;
bool falseOrExample = false || false;

// XOR Operator 
bool trueExclusiveOr = true ^ false;
bool falseExclusiveOr = true ^ true;

Console.WriteLine($"Not False = {isTrue}");
Console.WriteLine($"False AND True = {falseAndExample}");
Console.WriteLine($"True OR True = {trueOrExample}");
Console.WriteLine($"True XOR True = {falseExclusiveOr}");

// -- Comparison Operators 
bool isGreaterThan = 10 > 10;
bool isGreaterThanOrEqualTo = 10 >= 10;
Console.WriteLine($"10 > 10 is {isGreaterThan}, and 10 >= 10 is {isGreaterThanOrEqualTo}");

bool isLessThan = 5 < 5;
bool isLessThanOrEqualTo = 5 <= 5;
Console.WriteLine($"5 < 5 is {isLessThan}, while 5 <= 5 is {isLessThanOrEqualTo}");

bool equal = 17 == 9;
bool inequality = 17 != 9;
Console.WriteLine($"17 == 9 and 17 != 9 are {equality} and {inequality}, respectively.");