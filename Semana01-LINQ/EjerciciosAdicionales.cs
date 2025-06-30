/* 
//================Documentacion y ejemplos
//Funciones anónimas
Func<int, int> cuadrado = (x) => x * x;

Func<int, int, int> suma = (a, b) => a + b;

Func<int, int, int> mayor = (a, b) =>
{
    if (a > b)
        return a;
    else
        return b;
};
System.Console.WriteLine(cuadrado(5));
System.Console.WriteLine(suma(10, 20));
System.Console.WriteLine(mayor(30, 50));

*/

//Delegados con lambdas
/*
Delegado                Significado
--------------------------------------
Func<T>                 Retorna un valor. Ultimo parámetro es el tipo de retorno
Action<T>               No retorna valor. Se usa para ejecutar código.
Predicate<T>            Retorna bool. Se usa para pruebas lógicas o condiciones
*/

/*
Action<string> saludar = nombre => System.Console.WriteLine($"Hola, {nombre}");
saludar("Juan");

Predicate<int> espar = (n) => n % 2 == 0;
System.Console.WriteLine(espar(4));

var numeros = new List<int> { 1, 2, 3, 4, 5 };
var pares = numeros.Where(n => n % 2 == 0);
foreach(var n in pares)
    System.Console.WriteLine(n);


var numeros2 = new List<int> { 1, 2, 3, 4, 5 };
var pares2 = numeros2.FindAll(espar);
foreach (var item in pares2)
    System.Console.WriteLine(item);


var numeros3 = new List<int> { 1, 2, 3, 4, 5 };
Func<int, bool> espar2 = (x) => x % 2 == 0;

var pares3 = numeros3.Where(espar2);
foreach(var item in pares3)
    System.Console.WriteLine(item);

*/
//Ejercicio #1
var numeros = new List<int> { 1, 2, 3, 4, 5 };

var cuadrados = numeros.Select(x => x * x);

foreach(var item in cuadrados)
    System.Console.WriteLine(item);

//Ejercicio #2
var nombres = new List<string> { "Ana", "Roberto", "Luis", "Carmen", "Juan" };
var filtrados = nombres.Where(nom => nom.Length > 5);
foreach(var nom in filtrados)
    System.Console.WriteLine(nom);

//Ejercicio #3
var numeros3 = new List<int> { 2, 3, 4, 7, 9, 10 };
var impares = numeros3.Count(a => a % 2 == 1);
System.Console.WriteLine($"{impares} impares");

//Ejercicio #4
var palabras = new List<string> { "casa", "elefante", "sol", "mar" };
palabras = palabras.OrderBy(x => x.Length).ToList();
foreach(var palabra in palabras)
    System.Console.WriteLine(palabra);

var palabrasOrdenadas = palabras.OrderBy(x => x.Length);
foreach(var palabra in palabrasOrdenadas)
    System.Console.WriteLine(palabra);

//Ejercicio #5
Func<int, int> factorial = (n) =>
{
    int resultado = 1;
    for (int i = 1; i <= n; i++)
        resultado *= i;
    return resultado;
};

System.Console.WriteLine(factorial(5));

//Ejercicio #6
Func<int, int, int> potencia = (x, y) =>
{
    //return Convert.ToInt32(Math.Pow(x, y));
    int resultado = 1;
    for (int i = 1; i <= y; i++)
        resultado *= x;
    return resultado;
};

System.Console.WriteLine(potencia(5, 3));

//Ejercicio #7
Predicate<string> esPalindromo = (palabra) =>
{
    palabra = palabra.ToLower();
    string invertida = palabra.Reverse().ToArray().ToString();
    return palabra == invertida;
};

System.Console.WriteLine(esPalindromo("oso"));
System.Console.WriteLine(esPalindromo("Hola"));
