using System;
using System.Collections.Generic;

namespace Opdracht_1_Console_Applicatie_maken
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            List<List<string>> telefoons = new List<List<string>>()
            {
                new List<string>{"Huawei", 
                                    "P30", 
                                    "697", 
                                    "6.47\" FHD+ (2340x1080) OLED, Kirin 980 Octa - Core(2x Cortex - A76 ", 
                                    "2.6GHz + 2x Cortex-A76 1.92GHz + 4x Cortex-A55 1.8GHz), 8GB RAM,",
                                    "128GB ROM, 40+20+8+TOF/32MP, Dual SIM, 4200mAh, Android 9.0 +",
                                    "EMUI 9.1"
                },
                new List<string>{"Samsung",
                                    "Galaxy A52",
                                    "399",
                                    "64 megapixel camera, 4k videokwaliteit",
                                    "6.5 inch AMOLED scherm",
                                    "128 GB opslaggeheugen (Uitbreidbaar met Micro-sd)",
                                    "Water- en stofbestendig (IP67)"
                },
                new List<string>{"Apple",
                                    "Iphone 11",
                                    "619",
                                    "Met de dubbele camera schiet je in elke situatie een perfecte foto of video",
                                    "De krachtige A13-chipset zorgt voor razendsnelle prestaties",
                                    "Met Face ID hoef je enkel en alleen naar je toestel te kijken om te ontgrendelen",
                                    "Het toestel heeft een lange accuduur dankzij een energiezuinige processor"
                },
                new List<string>{"Google",
                                    "Pixel 4a",
                                    "411",
                                    "12.2 megapixel camera, 4k videokwaliteit",
                                    "5.81 inch OLED scherm",
                                    "128 GB opslaggeheugen",
                                    "3140 mAh accucapaciteit"
                },
                new List<string>{"Xiaomi",
                                    "Redmi Note 10 Pro",
                                    "298",
                                    "108 megapixel camera, 4k videokwaliteit",
                                    "6.67 inch AMOLED scherm",
                                    "128 GB opslaggeheugen (Uitbreidbaar met Micro-sd)",
                                    "Water- en stofbestendig (IP53)"
                },
            };
            
            Console.WriteLine("Kies een mobiel waarover je meer wil weten");
            Console.WriteLine("");
            Console.WriteLine("1. Huawei");
            Console.WriteLine("2. Samsung");
            Console.WriteLine("3. Apple");
            Console.WriteLine("4. Google");
            Console.WriteLine("5. Xiaomi");
            Console.WriteLine("");
            Console.WriteLine("0. Applicatie sluiten");
            var mobile = Console.ReadKey().KeyChar;
            int i = (int)Char.GetNumericValue(mobile) - 1;

            // Give information of chosen mobile
            if (mobile == '1')
            {
                Console.Clear();

                Console.Write($"Merk: {telefoons[i][0]} ; ");
                Console.Write($"Type: {telefoons[i][1]} ; ");
                Console.Write($"Prijs (Euros): {telefoons[i][2]}");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(telefoons[i][3]);
                Console.WriteLine(telefoons[i][4]);
                Console.WriteLine(telefoons[i][5]);
                Console.WriteLine(telefoons[i][6]);

                Console.ReadKey();
                Console.Clear();
                MainMenu();
            }
            else if (mobile == '2')
            {
                Console.Clear();

                Console.Write($"Merk: {telefoons[i][0]} ; ");
                Console.Write($"Type: {telefoons[i][1]} ; ");
                Console.Write($"Prijs (Euros): {telefoons[i][2]}");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(telefoons[i][3]);
                Console.WriteLine(telefoons[i][4]);
                Console.WriteLine(telefoons[i][5]);
                Console.WriteLine(telefoons[i][6]);

                Console.ReadKey();
                Console.Clear();
                MainMenu();
            }
            else if (mobile == '3')
            {
                Console.Clear();

                Console.Write($"Merk: {telefoons[i][0]} ; ");
                Console.Write($"Type: {telefoons[i][1]} ; ");
                Console.Write($"Prijs (Euros): {telefoons[i][2]}");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(telefoons[i][3]);
                Console.WriteLine(telefoons[i][4]);
                Console.WriteLine(telefoons[i][5]);
                Console.WriteLine(telefoons[i][6]);

                Console.ReadKey();
                Console.Clear();
                MainMenu();
            }
            else if (mobile == '4')
            {
                Console.Clear();

                Console.Write($"Merk: {telefoons[i][0]} ; ");
                Console.Write($"Type: {telefoons[i][1]} ; ");
                Console.Write($"Prijs (Euros): {telefoons[i][2]}");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(telefoons[i][3]);
                Console.WriteLine(telefoons[i][4]);
                Console.WriteLine(telefoons[i][5]);
                Console.WriteLine(telefoons[i][6]);

                Console.ReadKey();
                Console.Clear();
                MainMenu();

            }
            else if (mobile == '5')
            {
                Console.Clear();

                Console.Write($"Merk: {telefoons[i][0]} ; ");
                Console.Write($"Type: {telefoons[i][1]} ; ");
                Console.Write($"Prijs (Euros): {telefoons[i][2]}");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(telefoons[i][3]);
                Console.WriteLine(telefoons[i][4]);
                Console.WriteLine(telefoons[i][5]);
                Console.WriteLine(telefoons[i][6]);

                Console.ReadKey();
                Console.Clear();
                MainMenu();
            }
            // Exit the program when 0 is typed
            else if(mobile == '0')
            {
                return;
            }
            // Reset when invalid input
            else
            {
                Console.Clear();
                MainMenu();
            }
        }
    }
}
