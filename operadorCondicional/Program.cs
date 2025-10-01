int quantidadeEstoque = 10;
int quantidadeCompra = 4;

Console.WriteLine("-----------------"); 

if (quantidadeEstoque >= quantidadeCompra)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}

////
Console.WriteLine("-----------------");
///Outro exemplo
bool possivelVenda = quantidadeEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda: {possivelVenda}");

