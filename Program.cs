using System;

namespace SpaceShip
{
    internal class Program
    {
        static void DecodeMessage(string hexMessage)
        {
            int message;
            try
            {
                message = Convert.ToInt32(hexMessage, 16);
            }
            catch
            {
                Console.WriteLine("\nError: Invalid message format!\n");
                return;
            }

            /* | X  X  X  Y  Y  Y  Z  Z | */
            int severity = message % 4; //Z Z = severity
            int device = ((message >> 2) & 0b111) + 1; // Shift right by 2 bits, then set 3 bits    Y Y Y = device   (0b indicates that this is a binary number.) 
            int failureType = (message >> 5) & 0b111; //X X X = failureType

            Console.WriteLine($"DEBUG: message={message}, severity={severity}, device={device}, failureType={failureType}");

            if (device < 1 || device > 5 || failureType < 1 || failureType > 6)
            {
                Console.WriteLine("Error: Invalid message format!");
                return;
            }

            Console.WriteLine("\n-----------------");

            Console.Write("Severity: ");
            if (severity == 0) Console.WriteLine("No error");
            else if (severity == 1) Console.WriteLine("Suspicion");
            else if (severity == 2) Console.WriteLine("Critical");
            else Console.WriteLine("Severe");

            Console.Write("Device: ");
            if (device == 1) Console.WriteLine("Power Block");
            else if (device == 2) Console.WriteLine("Transmitter");
            else if (device == 3) Console.WriteLine("Receiver");
            else if (device == 4) Console.WriteLine("Camera");
            else Console.WriteLine("Trust Engine");

            Console.Write("Failure Type: ");
            if (failureType == 1) Console.WriteLine("Overheating");
            else if (failureType == 2) Console.WriteLine("Device not responding");
            else if (failureType == 3) Console.WriteLine("Communication breakdowns");
            else if (failureType == 4) Console.WriteLine("Excessive power consumption");
            else if (failureType == 5) Console.WriteLine("Unknown failure");
            else Console.WriteLine("Circuit failure");

            Console.WriteLine("-------------------\n");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a hexadecimal message (or type 'exit' to quit): ");
                string hexMessage = Console.ReadLine().ToUpper();
                if (hexMessage == "EXIT")
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }
                DecodeMessage(hexMessage);
            }
        }
    }
}
