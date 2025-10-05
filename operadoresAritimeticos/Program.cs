using operadoresAritimeticos;

Calculadora calc = new Calculadora();
calc.Somar(40, 2);
calc.Subtrair(10,3);
calc.Multiplicar(3, 22);
calc.Dividir(100, 20);

Console.WriteLine("------------Potenciação---------------");
calc.Potencia(5, 5);

Console.WriteLine("------------Seno---------------");
calc.Seno(20);

Console.WriteLine("------------Coseno---------------");
calc.Coseno(20);

Console.WriteLine("------------Tangente---------------");
calc.Tangente(20);

Console.WriteLine("--------------------------------");
int numero = 10;
Console.WriteLine("Incrementa o numero: ");
Console.WriteLine(++numero);//11

Console.WriteLine("--------------------------------");

Console.WriteLine("Decrementa o numero: ");
Console.WriteLine(--numero);//10
Console.WriteLine(--numero);//9
Console.WriteLine(--numero);//8
Console.WriteLine(--numero);//7
Console.WriteLine(--numero);//6

Console.WriteLine("--------------Raiz quadrada---------------");
calc.RaizQuadrada(10);