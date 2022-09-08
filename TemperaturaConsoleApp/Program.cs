// See https://aka.ms/new-console-template for more information

using KataTemperature;
Console.WriteLine("Temperaturas");
Console.WriteLine("A) Farenheit");
Console.WriteLine("B) Celsius");
Console.WriteLine("C) Kelvin");
Console.WriteLine(); 
Console.Write("Digite una opcion: ");
var aOption = Console.ReadLine();
Console.Clear();
Console.Write("Escriba la temperatura: ");
var aTemp = Console.ReadLine();
Console.Clear();
Console.WriteLine("Temperaturas");
Console.WriteLine("A) Farenheit");
Console.WriteLine("B) Celsius");
Console.WriteLine("C) Kelvin");
Console.WriteLine(); 
Console.Write("Digite una opcion la cual decia convertir la temperatura: ");
var aConvertTo = Console.ReadLine();
TemperatureScale aConvertTempValue;
Temperature aNewTemp = null;
switch (aOption)
{
    case "A":
        aNewTemp= new Temperature(Convert.ToInt32(aTemp), TemperatureScale.Fahrenheit);
        break;
    case "B":
        aNewTemp = new Temperature(Convert.ToInt32(aTemp), TemperatureScale.Celsius); 
        break;
    case "C":
        aNewTemp = new Temperature(Convert.ToInt32(aTemp), TemperatureScale.Kelvin);  
        break;
    default: 
        break;
}

switch (aConvertTo)
{
    case "A":
        Console.WriteLine(aNewTemp.ToFahrenheit().Value); 
        break;
    case "B":
        Console.WriteLine(aNewTemp.toCelsius().Value);  
        break;
    case "C":
        Console.WriteLine(aNewTemp.toKelvin().Value);   
        break;
    default: 
        break;
}



Console.ReadKey();

 