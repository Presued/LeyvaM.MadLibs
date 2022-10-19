//Manuel Leyva
//10-19-22
//MadLibs
//The user will be asked a series of questions and the user will have to input his answers to the questions
//Peer review:

string userInput = "";
do{

Console.WriteLine("Good Morning what is your name");
string myName = Console.ReadLine();


Console.WriteLine("Hows your morning going so far?");
string myMorning  = Console.ReadLine();


Console.WriteLine("So I hear next week is your birthday");
string myBirthday = Console.ReadLine();


Console.WriteLine("So what are you going to do for your birthday");
string myVacation = Console.ReadLine();

Console.WriteLine("How was the trip");
string myTrip = Console.ReadLine();

Console.WriteLine("What did you do over there");
String myActivity = Console.ReadLine();

Console.WriteLine("Did you try that amazing resturant I told you about");
string myFood = Console.ReadLine();

Console.WriteLine("Was it really hot out there");
string weather = Console.ReadLine();

Console.WriteLine("So When Did you guys get back");
string Over = Console.ReadLine();

Console.WriteLine("Well Im glad that you guys had fun, take care");
string Done = Console.ReadLine();

Console.WriteLine("GoodMorning, My Name is "+ $"{myName}" + " It's going "+ $"{myMorning}");
Console.WriteLine("It is "+ $"{myBirthday}" + " So your going to " + $"{myVacation}");
Console.WriteLine("It was " + $"{myTrip}" +" so you went " + $"{myActivity}");
Console.WriteLine("our descion on that was " + $"{myFood}" + " Well I think " + $"{weather}");
Console.WriteLine("we got back" + $"{Over}" + " Thank you, " + $"{Done}");

do
{
    Console.WriteLine("Do you want to continue: Yes or No?");
    userInput = Console.ReadLine().ToUpper();
    if(userInput != "YES" && userInput != "NO")
    {
        Console.WriteLine("Invalid Choice, pLease say Yes or No");
    }
}while (userInput !="YES" && userInput != "NO");
}while(userInput == "YES");