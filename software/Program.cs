using System;

namespace hardwareunemcu;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "Hardware u Němců : Loading..";
        Console.ResetColor();
        Console.WriteLine("Loading..");
        Thread.Sleep(2000);
        Console.Title = "Hardware u Němců : Loading devices..";
        Console.WriteLine("Devices detected: ");

        Console.Write(" Motherboard Ultra Pro Plus+");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (" + RandomHex() + ")");
        Console.ResetColor();

        Thread.Sleep(500);

        Console.Write(" Hardware u Němců HyperCPU 10 GHz");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (" + RandomHex() + ")");
        Console.ResetColor();

        Thread.Sleep(320);

        Console.WriteLine(" RAM: ");

        Console.Write("     NanoParticle DDR5 v1 100 GB");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (" + RandomHex() + ")");
        Console.ResetColor();

        Thread.Sleep(150);

        Console.Write("     NanoParticle DDR5 v1 100 GB");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (" + RandomHex() + ")");
        Console.ResetColor();

        Thread.Sleep(150);

        Console.Write("     NanoParticle DDR5 v1 100 GB");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (" + RandomHex() + ")");
        Console.ResetColor();

        Thread.Sleep(150);

        Console.Write("     NanoParticle DDR5 v1 100 GB");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (" + RandomHex() + ")");
        Console.ResetColor();

        Thread.Sleep(400);

        Console.WriteLine(" GPU: ");

        Console.Write("     AirCompute RTX-9080 1 TB vRAM");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (" + RandomHex() + ")");
        Console.ResetColor();

        Thread.Sleep(300);

        Console.WriteLine(" Other: ");

        Console.Write("     AirCompute Network: Starlink ");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Connected");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (0x0ELON00MUSK00FF)");
        Console.ResetColor();

        Thread.Sleep(100);

        Console.Write("     AirCompute Neural Processing Unit 978 TOPS");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (" + RandomHex() + ")");
        Console.ResetColor();

        Thread.Sleep(100);

        Console.Write("     AirCompute Regular SoundCard NEVER GONNA GIVE YOU UP");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" (" + RandomHex() + ")");
        Console.ResetColor();

        Thread.Sleep(500);

        Console.Title = "Hardware u Němců : Establishing connection..";
        Console.WriteLine("Establishing connection..");

        int y = Console.GetCursorPosition().Top;
        Console.Write("[");
        for (int i = 0; i < Console.WindowWidth - 2; i++)
        {
            Console.Write("_");
        }
        Console.Write("]");

        Random rng = new Random();
        for (int i = 1; i < Console.WindowWidth - 1; i++)
        {
            Console.SetCursorPosition(i, y);
            Console.Write("#");
            Thread.Sleep(5 + rng.Next(-4, 250));
        }

        string device = RandomHex();
        Console.Title = "Hardware u Němců : Connected to " + device;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nCONNECTED");

        for (int i = 0; i < 180; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Received packet: " + RandomHex());
            Thread.Sleep(100);
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("DISCONNECTED");
        Console.Title = "Hardware u Němců : Disconnected from " + device;
    }

    public static string RandomHex(int length = 16)
    {
        string result = "0x";
        Random rng = new Random();
        for (int i = 0; i < length; i++)
        {
            int num = rng.Next(0, 16);
            switch (num)
            {
                case 10:
                    result += "A";
                    break;
                case 11:
                    result += "B";
                    break;
                case 12:
                    result += "C";
                    break;
                case 13:
                    result += "D";
                    break;
                case 14:
                    result += "E";
                    break;
                case 15:
                    result += "F";
                    break;
                default:
                    result += num;
                    break;
            }
        }
        return result;
    }
}