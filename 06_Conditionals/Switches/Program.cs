console.WriteLine("How are you feeling today on a scale 1-5?");
string feelingRating = Console.ReadLine;
switch (feelingRating)
{

case
"5": // Checks to see if feelingRating has the value of "5"
Console.WriteLine("That's great to hear! "); // Runs if the above case matches
break;// Ends the code that runs if the above case is met
case "4":
Console.WriteLine("Good stuff!");
break;
case
"3":
Console.WriteLine("Hope things improve!");
break;
case
"2":
Console.WriteLine("Oh. Sorry to hear that! ");
break;
case
"1":
Console.WriteLine("Dang. We hope your day gets better! ");
break;
default: // This is only is used if none of the other cases are matches
Console.WriteLine("Sorry, we don't understand. Please try again later.");
break;
}

Console.WriteLine("How were you feeling yesterday on a scale of 1-5?");
string ratingInput = Console.ReadLine();
it yesterdayRating = int.Parse(ratingInput);

string response = yesterdayRating switch
{
    1 => "Dang. We hope today is a better day." ,
    2 => "Oh, sorry to hear that!" ,
    3 => "Hopefully things will get better this week." ,
    4 => "Good stuff!" ,
    5 => "That's great to hear!" , 
    _ => "That's off the charts!" 
};
Console.WriteLine(response);