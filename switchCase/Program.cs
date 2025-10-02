Console.WriteLine("Digite uma letra: ");

string letra = Console.ReadLine();

Console.WriteLine("-------------------------");

if (letra == "a")
{
    Console.WriteLine("VOGAL");
}
else if (letra == "e")
{
    Console.WriteLine("VOGAL");
}
else if (letra == "i")
{
    Console.WriteLine("VOGAL");
}
else if (letra == "o")
{
    Console.WriteLine("VOGAL");
}
else if (letra == "u")
{
    Console.WriteLine("VOGAL");
}
else
{
    Console.WriteLine("Não e VOGAL!");
}

//Outro jeito de fazer

Console.WriteLine("-------------------------");

if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")
{
    Console.WriteLine("Vogal");
}
else
{
    Console.WriteLine("Não é vogal!");
}

Console.WriteLine("-------------------------");

//Usando switch case
switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal vogal!");
        break;
}

Console.WriteLine("-------------------------");
