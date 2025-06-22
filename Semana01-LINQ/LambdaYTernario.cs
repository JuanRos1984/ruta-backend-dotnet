//Ejercicio 1
var numeros = new List<int> { 1, 2, 3, 4, 5, 6 };
var pares = numeros.Where(a => a % 2 == 0);
foreach (var numeros in pares)
{
    System.Console.WriteLine(numeros);
}

//Ejercicio 2
var personas = new List<(string Nombre, int Edad)>
{
    ("Ana",23),
    ("Luis",17),
    ("Carlos",31),
    ("Elena",15)
};

//Filtrado de los mayores y proyeccion del nombre con Select
var mayores = personas.Where(x=>x.Edad > 18).Select(x=>x.Nombre);
foreach (var item in mayores)
{
    System.Console.WriteLine(item);
}

//usando ternarios
foreach (var item in personas)
{
    System.Console.WriteLine(item.Edad >= 18 ? $"{item.Nombre} es adulto" : $"{item.Nombre} es menor de edad");
}

//Ejercicio 3
//codigo original
bool pagoRealizado = false;
string mensaje;
if (pagoRealizado)
    mensaje = "Gracias por su compra";
else
    mensaje = "No se ha realizado el pago";
//refactorizado con ternario
mensaje = pagoRealizado ? "Gracias por su compra" : "No se ha realizado el pago";
