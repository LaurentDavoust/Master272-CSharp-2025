// See https://aka.ms/new-console-template for more information
Console.WriteLine("+ Début du programme");

// Variables numériques
int x1 = 10; // Déclaration et initialisation
int x2; // Déclaration (très rare)
var x3 = 30; // int par type d'initialisation
//x3 = 30.5; // Erreur de compilation
/*
Entiers : 
 - int : -2 147 483 648 à +2 147 483 647
 - long : -9 223 372 036 854 775 808 à +9 223 372 036 854 775 807
*/
// Nombres à virgules
var d1 = 10.5; // double

// Booléens
var b1 = true; // bool
var b2 = false;
// var b3 = False; // Erreur de compilation

// Chaînes de caractères
var s1 = "Bonjour"; // string
var s2 = @"Dau\phine";
var s3 = "Dau\nhine";
Console.WriteLine(s2);
Console.WriteLine(s3);

Console.WriteLine($"s1={s1}");

// Opérations de base : +, -, *, /, %
var puissance = Math.Pow(2, 5); // 2^5

// Opérations de comparaison: ==, !=, <, >, <=, >=
// Opérations logiques : && (AND), || (6 - OR), ! (NOT)


// Exercice 1 
Console.WriteLine("\n+ Exercice 1");
var a = 5;
var b = 3;
Console.WriteLine(a+b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b); // Division entière
Console.WriteLine(a % b);
Console.WriteLine(1.0 * a / b); // Division décimale

// Opérations sur les conditions
Console.WriteLine(a == b);
Console.WriteLine(a != b);
Console.WriteLine(a < b);
Console.WriteLine(a > b);

// Opérations sur les booléens
Console.WriteLine("\n+ Opérations sur les booléens");
b1 = true;
b2 = false;
Console.WriteLine(b1 && b2);
Console.WriteLine(b1 || b2);
Console.WriteLine(!b1);

// Opérations sur les chaînes de caractères
var s4 = "Bonjour";
Console.WriteLine(s4.Replace("o", "0"));
Console.WriteLine(s4.ToUpper());
Console.WriteLine(s4.ToLower());
Console.WriteLine(s4.Length);
Console.WriteLine(s4.Substring(1, 3));
Console.WriteLine(s4.Contains("jour"));
Console.WriteLine(s4.Split('j'));
Console.WriteLine(s1 + " " + s4);
Console.WriteLine($"{s1} {a:F2}");

// Convention de variables
var spot_price = 100; // Mauvaise -> Python style
var spotPrice = 100.0; // Bonne -> Camel case

// Conditions
if (a > 20)
{
    Console.WriteLine("a > 20");
    a = a * 2; // a*=2;
}
else if (a > 10)
{
    Console.WriteLine("10 < a <= 20");
}
else
{
    Console.WriteLine("a <= 10");
}

switch (a)
{
    case 1:
        Console.WriteLine("a == 1");
        break;
    case 2:
    case 3:
        Console.WriteLine("a == (2 or 3)");
        break;
    default:
        Console.WriteLine("a != 1 et a != (2 ou 3)");
        break;
}

// Boucles
for (int i = 0; i <= 4; i = i + 1) // i++ ou i+=1
{
    Console.WriteLine($"i={i}");
}
foreach (var c in s4)
{
    Console.WriteLine(c);
}
while (b1)
{
    Console.WriteLine("b1 est vrai");
    b1 = false;
}
// continue, break


// Exercice : pour tous les taux d'intérêts allant de 1% à 10% (inclus), calculer le discount factor associé =1/(1+taux)^T (maturité stockée 
// dans une variable)

Console.WriteLine("+ Fin du programme");
