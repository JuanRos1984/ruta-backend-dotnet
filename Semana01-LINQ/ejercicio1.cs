var numeros = new List<int> { 1, 2, 3, 4, 5, 6 };
var pares = numeros.Where(a => a % 2 == 0);
foreach (var numeros in pares)
{ 
    System.Console.WriteLine(numeros);
}