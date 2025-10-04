//Operador or
bool ehMaiorDeidade = false;
bool possuiAurorizacaoDoResponsavel = false;

Console.WriteLine("--------or---------");

if(ehMaiorDeidade || possuiAurorizacaoDoResponsavel ) {
   Console.WriteLine("Entrada liberada");
} else {
    Console.WriteLine("Entrada não liberada");
}

Console.WriteLine("--------and---------");
//Operador and

bool possuiPresençaMinima = true;
 
double nota = 7.5;

if(possuiPresençaMinima && nota >= 7.5) {
    Console.WriteLine("Aprovado!");
}else {
    Console.WriteLine("Reprovado!");
}




