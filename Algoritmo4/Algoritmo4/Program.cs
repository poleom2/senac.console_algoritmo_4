using System.Globalization;

double largura;
double comprimeto, area, valormetro, valorterreno;

largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
comprimeto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
valormetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

area = largura * comprimeto;
valorterreno = area * valormetro;
Console.WriteLine("AREA - " + area.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("PRECIO = " + valorterreno.ToString("F2",CultureInfo.InvariantCulture));

