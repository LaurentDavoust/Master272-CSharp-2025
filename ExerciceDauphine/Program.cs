// See https://aka.ms/new-console-template for more information

using ExerciceDauphine;

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
var maturity = 5;
for (double i = 0.01; i <= 0.1; i += 0.001)
{
    var discountFactor = 1 / Math.Pow(1 + i, maturity);
    Console.WriteLine($"Taux={i*100:F1}% -> DF={discountFactor:F5}");
}

// Exercice - Fibonacci
var u0 = 0;
var u1 = 1;
var fibonacci = u0 + u1;
for (var i = 2; i <= 30; i++)
{
    fibonacci = u0 + u1;
    u0 = u1;
    u1 = fibonacci;
}
Console.WriteLine($"Fibonacci(30)={fibonacci}");


// Avec fonction
long Fibonacci(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
//Console.WriteLine($"Fibonacci(49)={Fibonacci(49)}");


// List & Dictionary
var list = new List<double>() { 1, 2, 3, 4 };
list.Add(23.6);
if(list.Contains(4)) list.Remove(4);
foreach (var item in list)
{
    Console.WriteLine(item);
}

var dict=new Dictionary<string, int>()
{
    {"un", 1 },
    {"deux", 2 },
    {"trois", 3 }
};
foreach (var keyValue in dict)
{
    Console.WriteLine($"{keyValue.Key}->{keyValue.Value}");
}

// Exercice :
//[10, 9, 8, 7, 6]
//    - Filtrer les multiples de 2
//    - Renvoyer x^2
var numbers = new List<int>() { 10, 9, 8, 7, 6 };
var results = numbers
                                .Where(x => x % 2 == 0)
                                .Select(x => x * x);
foreach (var r in results) Console.WriteLine(r);

// Exercice :
//[10, 9, 8, 7, 6]
//    - Regrouper par si élément pair ou non (GroupBy)
//    - Faire la moyenne par groupe (Average)
//    - Dict<bool, double> -> true = pair (=> (10²+8²+6²)/3)
//                          , false = impair (=> (7²+9²)/2)
var dictExercice= numbers
                            .GroupBy(elmt=>elmt%2)
                            .ToDictionary(
                                g => g.Key == 0, 
                                g => g.Average(
                                        elmt=>elmt*elmt
                                    )
                            );           


// Création de voitures
var voiture1 = new Voiture(); // Bleue
var voiture2 = new Voiture("Rouge");
var voiture3 = new Voiture("Verte", 200, 100);

Console.WriteLine(voiture1.Couleur);
voiture1.Trajet(100);
voiture1.Trajet("100miles");
Console.WriteLine(voiture1.DistanceParcourue);

Console.WriteLine("+ Fin du programme");
