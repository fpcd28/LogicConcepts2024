// See https://aka.ms/new-console-template for more information
var numberString = string.Empty;
do
{
    Console.Write("Ingrese Numero entero o 'S  para salir ");
    numberString = Console.ReadLine();  //number = "45"
    var numberInt = 0;
    if (numberString!.ToLower() == "salir" )
    {
        continue;
    }
    if (int.TryParse(numberString, out numberInt!))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El numero {numberInt} es par");
        }
        else
        {
            Console.WriteLine($"El numero {numberInt} es impar");
        }
    }
    else
    {
        Console.WriteLine($"Lo que ingresaste : {numberString} no es un numero entero ");
    }

} while (numberString!.ToLower() != "salir");
Console.WriteLine("Game Over");



