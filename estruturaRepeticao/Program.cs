int numero = 4;

Console.WriteLine($"{numero} * 1 = {10 * 1}");

Console.WriteLine("-----------For---------------");

for(int contador = 0; contador <= 10; contador ++){
    Console.WriteLine($"{contador} * {numero} = {contador * numero}");
}

Console.WriteLine("-----------while---------------");
int cont = 4;
while(cont <= 50){
    Console.Write(cont);
    Console.Write(" ");
    cont++;
}

Console.WriteLine("-----------Do while---------------");

int soma = 0, number = 0;

do {
    Console.WriteLine("Digite um número: (Para sair digite 0)");
    number = Convert.ToInt32(Console.ReadLine());

    soma += number;

}while(number != 0);

Console.Write($"Total da soma: {soma}");
