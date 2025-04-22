public class Program
{
    public static void Main(string[] args)
    {
        KontoBankowe konto1 = new KontoBankowe("Jan", 123456780, 5000.00m);

        KontoOszczednosciowe konto2 = new KontoOszczednosciowe("Anna", 987654320, 10000.00m, 0.02m);

        Console.WriteLine(konto1.ZwrocInformacje());

        Console.WriteLine(konto2.ZwrocInformacje());

        konto1.Wplac(1500.00m);

        konto2.Wplac(2500.00m);

        Console.WriteLine(konto1.ZwrocInformacje());

        Console.WriteLine(konto2.ZwrocInformacje());

        konto1.Wyplac(100.00m);

        konto2.Wyplac(1000.00m);

        Console.WriteLine(konto1.ZwrocInformacje());

        Console.WriteLine(konto2.ZwrocInformacje());

        KontoBankowe konto3 = new KontoOszczednosciowe("Anna", 987654321, 10000.00m, 0.02m);

        konto3.Wplac(1000.00m);

        Console.WriteLine(konto3.ZwrocInformacje());
    }
}