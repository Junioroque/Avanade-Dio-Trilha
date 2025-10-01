int quantidadeEstoque = 3;
int quantidadeCompra = 5;

bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

Console.WriteLine("-----------------");

if (quantidadeCompra == 0) {
    Console.WriteLine("Venda invalida!");
}

else if (quantidadeEstoque >= quantidadeCompra) {
    Console.WriteLine("Venda realizada.");
} else {
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}

////
Console.WriteLine("-----------------");
///Outro exemplo


Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda: {possivelVenda}");




