using System.ComponentModel;

int a = 25;
a = a + 4;
a += 4;

Console.WriteLine(a);

int b = 10;
b += 1;
Console.WriteLine(b);

b++;
b--;

Console.WriteLine(b);

int input1 = 4;
int vysledek = input1 % 2;

if (vysledek == 1) 
{
    input1 *= 2;
}
if (vysledek == 0)
{
    input1 *= 3;
}
Console.WriteLine(input1);

string s = "Ahoj, ";
string veta = s += "biebersissersasdsa";

Console.WriteLine(veta);

string x = "";
if (string.IsNullOrWhiteSpace(x))
{
    Console.WriteLine("prazdne");
}
else
{
    Console.WriteLine("neco tam je");
}

string input2 = "";

if (string.IsNullOrWhiteSpace(input2))
{
    Console.WriteLine("Ahoj svete");
}
else
{
    Console.WriteLine("Ahoj blabbersisisbers");
}

string input3 = "boopershoopers";

if (input3.Length > 5 && input3.Length <20)
{
    Console.WriteLine("Uzivatelske jmeno bylo zadano");
}
else
{
    Console.WriteLine("Heslo musi mit nejmin 5 charakteru a nejvice 20 charakteru");
}

// konjunkce - ||, disjunkce - &&
//$ - muzu dat text + neco neco

Console.WriteLine("Zadej 2 slova");
string userInput = Console.ReadLine();
string userInput2 = Console.ReadLine();

if (userInput.Length > userInput2.Length)
{
    Console.WriteLine(userInput);
}
else
{
    Console.WriteLine(userInput2);
}











