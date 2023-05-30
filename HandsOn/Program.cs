using HandsOn;
using System.Reflection.Metadata.Ecma335;

Console.Write("Hey!\t");
Console.WriteLine("Let\'s start HandsOn");

//object declaration

Variable varib = new Variable();

//Data type and variable declaration

Console.WriteLine("Emp ID (int):"+varib.a+"\nRole (String):"+varib.role+"\nPerfomance rate (Double):"+varib.perform_rate+"\nNumber (Long):"+varib.Phno);

//Control statement

if(varib.status== true)
{
    Console.WriteLine("Current Status: Active");
}
else 
{
    Console.WriteLine("Current Status: Offline");
}


//String Functions
Console.Write("\n\nString Function\nEnter a string:");
string b=Console.ReadLine();
Console.WriteLine("Choose your needed operation\n1 -Find Length\n2 -Covert to upercase\n3 -Convert to Lowercase" +
    "\n4 -Replace Word on your string\n5 - Add another word or pharse\n0 - exit");
int choice=int.Parse(Console.ReadLine());
switch(choice)
{
    case 1:
        Console.WriteLine("Length of the String:"+b.Length);
        break;
    case 2:
        Console.WriteLine("To Uppercase:"+b.ToUpper());
        break;
    case 3:
        Console.WriteLine("To Lower()"+b.ToLower());
        break;
    case 4:
        Console.Write("Which word to replace(in uppercase):");
        string desti=Console.ReadLine();
        Console.Write("Replacing Word(in uppercase):");
        string replace=Console.ReadLine();
        Console.WriteLine(b.ToUpper().Replace(desti,replace));
        break;
    case 5:
        Console.Write("Enter the word you like to merge:");
        string merge=Console.ReadLine();
        Console.WriteLine(b+" "+merge);
        break;
    
}

