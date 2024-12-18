// See https://aka.ms/new-console-template for more information

string s1 = "abcd";

Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1);

string s2 = "ABCD";

Console.WriteLine(s2.ToLower());
Console.WriteLine(s2);

string s3 = "name phone_number address,potato,sweet_potato,tomato";
string[] conditions = s3.Split(new char[] { ' ', ',' });

foreach (string condition in conditions)
{
    Console.WriteLine(condition);
}

string s4 = "\t abc dslkfej\t\t";
Console.WriteLine("::" + s4 + "::");
Console.WriteLine("::" + s4.Trim() + "::");
Console.WriteLine("::" + s4.TrimStart() + "::");
Console.WriteLine("::" + s4.TrimEnd() + "::");

string[] Menu = { "Pasta", "Pizza", "Steak" };
string AllMenu = string.Join(", ", Menu);
Console.WriteLine(AllMenu);