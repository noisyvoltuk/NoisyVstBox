using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace NoisyVstBox.Host.Services
{
    public class RemoteIOService: IRemoteIOService
    {

        public void SendMessageToLCD(string msg)
        {
            string portName = "COM4"; // Change this to your Arduino's port (e.g., COM3, /dev/ttyACM0, etc.)
            int baudRate = 9600;

            // Open the serial port
            using (SerialPort serialPort = new SerialPort(portName, baudRate))
            {
                try
                {
                    serialPort.Open();
                    Console.WriteLine($"Connected to {portName} at {baudRate} baud.");

                    // Prompt the user for a message to send
                  //  Console.WriteLine("Enter a message to send to Arduino (or 'exit' to quit):");

                    serialPort.WriteLine(msg);

                    /*
                    while (true)
                    {
                        // Read input from the user
                        string message = Console.ReadLine();

                        if (message.ToLower() == "exit")
                        {
                            break;
                        }

                        // Send the message to the Arduino
                        serialPort.WriteLine(message);
                        Console.WriteLine($"Message sent: {message}");
                    }
                    */
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
