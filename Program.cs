using System.Globalization;
{

    double xA, xB, xC, yA, yB, yC;

    Console.Write("Eentre com as medidas do triângulo X:");
    xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Eentre com as medidas do triângulo Y:");
    yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double p = (xA + xB + xC) / 2.0;
    double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
    p = (yA + yB + yC) / 2.0;
    double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
    Console.WriteLine("Àrea de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
    Console.WriteLine("Àrea de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

    if (areaX > areaY)
    {
        Console.WriteLine("Maior àrea: X");
    }
    else {
        Console.WriteLine("Maior àrea : Y");
    }
}