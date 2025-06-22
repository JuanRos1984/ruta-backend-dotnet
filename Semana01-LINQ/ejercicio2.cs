var personas = new List<(string Nombre, int Edad)>
{
    ("Ana",23),
    ("Luis",17),
    ("Carlos",31),
    ("Elena",15)
};

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

