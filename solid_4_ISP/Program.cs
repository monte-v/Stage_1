using solid_4_ISP;

class Program
{
    static void Main(string[] args)
    {
        IPrinter laserPrinter = new LaserPrinter();
        laserPrinter.Print("Документ для печати");

        IMultifunctionDevice allInOnePrinter = new AllInOnePrinter();
        allInOnePrinter.Print("Документ для печати с многофункционального устройства");
        allInOnePrinter.Scan("Документ для сканирования");
    }
}
