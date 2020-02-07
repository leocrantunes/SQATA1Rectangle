using System;
using System.Collections.Generic;
using System.Linq;

namespace SQATA1Rectangle
{
    /// <summary>
    /// Main program class
    /// </summary>
    class Program
    {
        private const int EXIT_CODE = 7;

        private static readonly Dictionary<int, string> _options = new Dictionary<int, string>()
        {
            { 1, "Get Rectangle Length" },
            { 2, "Change Rectangle Length" },
            { 3, "Get Rectangle Width" },
            { 4, "Change Rectangle Width" },
            { 5, "Get Rectangle Perimeter" },
            { 6, "Get Rectangle Area" },
            { 7, "Exit" }
        };

        private static Rectangle _rectangle;

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the length of the rectangle");
            int length = ReadValidInteger();

            Console.WriteLine("Please, enter the width of the rectangle");
            int width = ReadValidInteger();

            try
            {
                _rectangle = new Rectangle(length, width);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error creating rectangle: {ex.Message}");
                return;
            }
            
            int optionCode;
            do
            {
                ShowListOfOptions();
                optionCode = ReadOptionCode();

                if (optionCode != EXIT_CODE)
                {
                    ExecuteAction(optionCode);
                }
            } while (optionCode != EXIT_CODE);
        }

        /// <summary>
        /// Executes the action according to the option code
        /// </summary>
        /// <param name="optionCode">target option</param>
        private static void ExecuteAction(int optionCode)
        {
            switch (optionCode)
            {
                case 1:
                    Console.WriteLine($"Rectangle length: {_rectangle.GetLength()}");
                    break;
                case 2:
                    Console.WriteLine($"Rectangle length {(SetLength() ? "" : "was not")} updated");
                    break;
                case 3:
                    Console.WriteLine($"Rectangle width: {_rectangle.GetWidth()}");
                    break;
                case 4:
                    Console.WriteLine($"Rectangle width {(SetWidth() ? "" : "was not")} updated");
                    break;
                case 5:
                    Console.WriteLine($"Rectangle perimeter: {_rectangle.GetPerimeter()}");
                    break;
                case 6:
                    Console.WriteLine($"Rectangle area: {_rectangle.GetArea()}");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Auxiliary method to set width and handle exceptions
        /// </summary>
        /// <returns></returns>
        private static bool SetWidth()
        {
            int width = ReadValidInteger();
            
            try
            {
                _rectangle.SetWidth(width);
                return true;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Value not allowed: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected exception: {ex.Message}");
            }

            return false;
        }

        /// <summary>
        /// Auxiliary method to set length and handle exceptions
        /// </summary>
        /// <returns></returns>
        private static bool SetLength()
        {
            int length = ReadValidInteger();

            try
            {
                _rectangle.SetLength(length);
                return true;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Value not allowed: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected exception: {ex.Message}");
            }

            return false;
        }

        /// <summary>
        /// Auxiliary method to show the list of possible options
        /// </summary>
        private static void ShowListOfOptions()
        {
            Console.WriteLine("Please, choose one of the following options:");
            Console.WriteLine(String.Join("\n", _options.Select(o => $"{o.Key}. {o.Value}")));
        }

        /// <summary>
        /// Auxiliary method to read option code and handle exceptions
        /// </summary>
        /// <returns></returns>
        private static int ReadOptionCode()
        {
            bool correct = false;
            do
            {
                bool validInteger = int.TryParse(Console.ReadLine(), out int value);
                if (validInteger)
                {
                    if (_options.ContainsKey(value))
                    {
                        return value;
                    }
                    else
                    {
                        Console.WriteLine("Please inform a code in the list above");
                        ShowListOfOptions();
                    }
                }
                else
                {
                    Console.WriteLine("Please inform a valid integer number");
                    ShowListOfOptions();
                }
            }
            while (!correct);

            return EXIT_CODE;
        }

        /// <summary>
        /// Auxiliary method to read a valid integer and handle exceptions
        /// </summary>
        /// <returns></returns>
        private static int ReadValidInteger()
        {
            bool correct = false;
            do
            {
                Console.Write("Value: ");
                bool validInteger = int.TryParse(Console.ReadLine(), out int value);
                if (validInteger)
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Please inform an integer greater than 0");
                    }
                    else
                    {
                        return value;
                    }
                }
                else
                {
                    Console.WriteLine("Please inform a valid integer number");
                }
            }
            while (!correct);

            return 0;
        }
    }
}