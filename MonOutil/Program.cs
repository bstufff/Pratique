// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bonjour, veuillez entrez votre nom d'utilisateur :");
string nom=Console.ReadLine();
Console.WriteLine("Bienvenue "+nom+" à l'application MonOutil.");
Console.WriteLine("Entrez une température en Celsius :");
double C = Convert.ToDouble (Console.ReadLine());
double F = C * 1.8;
F = F +32;
Console.WriteLine("Cette température est de " + F + " degrés Fahrenheit.");
Console.ReadKey();