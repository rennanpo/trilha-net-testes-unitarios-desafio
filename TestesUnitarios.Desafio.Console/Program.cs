using TestesUnitarios.Desafio.Console.Services;

ValidacoesLista v1 = new ValidacoesLista();
List<int> lista = new();
lista.Add(1);
lista.Add(4);
lista.Add(-2);
lista.Add(8);
lista.Add(3);
var resultado = v1.RetornarMaiorNumeroLista(lista);
Console.WriteLine(resultado);