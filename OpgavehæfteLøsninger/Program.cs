using System;

namespace OpgavehæfteLøsninger
{
    class Program
    {
        static void Main(string[] args)
        {
            Opgave1_1 opgave1_1 = new Opgave1_1();
            Opgave1_2 opgave1_2 = new Opgave1_2();
            Opgave1_3 opgave1_3 = new Opgave1_3();
            Opgave1_4 opgave1_4 = new Opgave1_4();
            Opgave2_1 opgave2_1 = new Opgave2_1();
            Opgave2_3 opgave2_3 = new Opgave2_3();
            Opgave3_1 opgave3_1 = new Opgave3_1();
            Opgave3_2 opgave3_2 = new Opgave3_2();
            Opgave4 opgave4 = new Opgave4();
            Opgave4_1 opgave4_1 = new Opgave4_1();
            Opgave4_5 opgave4_5 = new Opgave4_5();
            Opgave5_1 opgave5_1 = new Opgave5_1();
            Opgave5_2 opgave5_2 = new Opgave5_2();
            Opgave5_3 opgave5_3 = new Opgave5_3();
            Opgave6_1 opgave6_1 = new Opgave6_1();
            Opgave7_1 opgave7_1 = new Opgave7_1();
            Opgave7_2 opgave7_2 = new Opgave7_2();
            Opgave7_3 opgave7_3 = new Opgave7_3();
            Opgave7_5 opgave7_5 = new Opgave7_5();
            Opgave8_1 opgave8_1 = new Opgave8_1();
            string opgave, kapitel;
            int fejl = 1;
            //Har en do while til at starte med for at kunne prøve flere opgaver igennem eller hvis fejl skrivning skulle ske.
            do
            {
                Console.Clear();
                Console.WriteLine("Hej her kan du vælge mellem løste opgaver!");
                Console.WriteLine("Du skal skrive hvilket kapitel du vil ind for");
                Console.WriteLine("Kapitel 1 Introduktion\n\nKapitel 2 Sammenligninger\n\nKapitel 3 Switch Case\n\nKapitel 4 DO WHILE og WHILE\n\nKapitel 5 FOR løkke\n\nKapitel 6 Matematiske funktioner\n\nKapitel 7 String funktioner\n\nKapitel 8 Arrays\n\n");
                Console.WriteLine("Skriv hvilket nummer kapitel du vil ind på, hvis man vil ud af programmet kan man skrive exit");
                //Konvertere til upper så det ligegyldig hvordan de skriver.
                kapitel = Console.ReadLine().ToUpper();
                switch (kapitel)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("*** Velkommen til Kapitel 1 Introduktion ***");
                        Console.WriteLine("Vælg mellem disse løste opgaver: \n");
                        Console.WriteLine("Opgave 1 om Fahrenhiet til Celcius\n\nOpgave 2 om Celcius til Fahrenheit, Kelvin og Réaumr\n\nOpgave 3 om Euro til Kroner\n\nOpgave 4/5 om regnskab\n\n");
                        Console.WriteLine("Skriv hvilken nummer opgave du vil ind på, hvis man vil ud af programmet kan man skrive exit");
                        opgave = Console.ReadLine().ToUpper();
                        switch (opgave)
                        {
                            case "1":
                                opgave1_1.InputMethod();
                                break;
                            case "2":
                                opgave1_2.InputMethod();
                                break;
                            case "3":
                                opgave1_3.InputMethod();
                                break;
                            case "4":
                                opgave1_4.InputMethod();
                                break;
                            case "5":
                                opgave1_4.InputMethod();
                                break;
                            case "EXIT":
                                fejl = 0;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("*** Velkommen til Kapitel 2 Sammenligninger ***");
                        Console.WriteLine("Vælg mellem disse løste opgaver: \n");
                        Console.WriteLine("Opgave 1/2 om navn og alder input\n\nOpgave 3 om alder og karakter\n\n");
                        Console.WriteLine("Skriv hvilken nummer opgave du vil ind på, hvis man vil ud af programmet kan man skrive exit");
                        opgave = Console.ReadLine().ToUpper();
                        switch (opgave)
                        {
                            case "1":
                                opgave2_1.InputMethod();
                                break;
                            case "2":
                                opgave2_1.InputMethod();
                                break;
                            case "3":
                                opgave2_3.InputMethod();
                                break;
                            case "EXIT":
                                fejl = 0;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("*** Velkommen til Kapitel 3 Switch Case ***");
                        Console.WriteLine("Vælg mellem disse løste opgaver: \n");
                        Console.WriteLine("Opgave 1 om tal input til ugedag\n\nOpgave 2 om Switch udvidelse af Celcius til Fahrenheit, Kelvin og Réaumr\n\n");
                        Console.WriteLine("Skriv hvilken nummer opgave du vil ind på, hvis man vil ud af programmet kan man skrive exit");
                        opgave = Console.ReadLine().ToUpper();
                        switch (opgave)
                        {
                            case "1":
                                opgave3_1.InputMethod();
                                break;
                            case "2":
                                opgave3_2.InputMethod();
                                break;
                            case "EXIT":
                                fejl = 0;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("*** Velkommen til Kapitel 4 DO WHILE og WHILE ***");
                        Console.WriteLine("Vælg mellem disse løste opgaver: \n");
                        Console.WriteLine("Opgave 0 om tabel regner\n\nOpgave 1/2/3/4 om en boks maker\n\nOpgave 5 om at skrive et bestemt ord for at stoppe\n\n");
                        Console.WriteLine("Skriv hvilken nummer opgave du vil ind på, hvis man vil ud af programmet kan man skrive exit");
                        opgave = Console.ReadLine().ToUpper();
                        switch (opgave)
                        {
                            case "0":
                                opgave4.InputMethod();
                                break;
                            case "1":
                                opgave4_1.SquareMethod();
                                break;
                            case "2":
                                opgave4_1.SquareMethod();
                                break;
                            case "3":
                                opgave4_1.SquareMethod();
                                break;
                            case "4":
                                opgave4_1.SquareMethod();
                                break;
                            case "5":
                                opgave4_5.InputMethod();
                                break;
                            case "EXIT":
                                fejl = 0;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("*** Velkommen til Kapitel 5 FOR løkke ***");
                        Console.WriteLine("Vælg mellem disse løste opgaver: \n");
                        Console.WriteLine("Opgave 1 om at skrive Celsius og Fahrenheit ud indtil Celcius rammer 100\n\nOpgave 2 om at skrive Celsius og Fahrenheit ud indtil Celcius rammer 100, dog stiger med 10\n\nOpgave 3 om at udskrive 2 sætninger med 2 forskellige farver, med kun en writeline\n\n");
                        Console.WriteLine("Skriv hvilken nummer opgave du vil ind på, hvis man vil ud af programmet kan man skrive exit");
                        opgave = Console.ReadLine().ToUpper();
                        switch (opgave)
                        {
                            case "1":
                                opgave5_1.CounterMethod();
                                break;
                            case "2":
                                opgave5_2.CounterMethod();
                                break;
                            case "3":
                                opgave5_3.TextMethod();
                                break;
                            case "EXIT":
                                fejl = 0;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("*** Velkommen til Kapitel 6 Matematiske funktioner ***");
                        Console.WriteLine("Vælg mellem disse løste opgaver: \n");
                        Console.WriteLine("Opgave 1 om en Circles omkreds beregner\n\n");
                        Console.WriteLine("Skriv hvilken nummer opgave du vil ind på, hvis man vil ud af programmet kan man skrive exit");
                        opgave = Console.ReadLine().ToUpper();
                        switch (opgave)
                        {
                            case "1":
                                opgave6_1.InputMethod();
                                break;
                            case "EXIT":
                                fejl = 0;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("*** Velkommen til Kapitel 7 String funktioner ***");
                        Console.WriteLine("Vælg mellem disse løste opgaver: \n");
                        Console.WriteLine("Opgave 1 om at tælle mellemrum i vilkårlig tekst\n\nOpgave 2 om at sætte ny start ved mellemrum i vilkårlig tekst\n\nOpgave 3/4 om at forstørre første bogstav i hver navn i et fuldt navn\n\nOpgave 5 om at bytte rund på rækkefølgen i et fuldt navn\n\n");
                        Console.WriteLine("Skriv hvilken nummer opgave du vil ind på, hvis man vil ud af programmet kan man skrive exit");
                        opgave = Console.ReadLine().ToUpper();
                        switch (opgave)
                        {
                            case "1":
                                opgave7_1.InputMethod();
                                break;
                            case "2":
                                opgave7_2.InputMethod();
                                break;
                            case "3":
                                opgave7_3.InputMethod();
                                break;
                            case "4":
                                opgave7_3.InputMethod();
                                break;
                            case "5":
                                opgave7_5.InputMethod();
                                break;
                            case "EXIT":
                                fejl = 0;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("*** Velkommen til Kapitel 8 arrays ***");
                        Console.WriteLine("Vælg mellem disse løste opgaver: \n");
                        Console.WriteLine("Opgave 1/2/3/4 om at skrive måneder på forskellige måder\n\n");
                        Console.WriteLine("Skriv hvilken nummer opgave du vil ind på, hvis man vil ud af programmet kan man skrive exit");
                        opgave = Console.ReadLine().ToUpper();
                        switch (opgave)
                        {
                            case "1":
                                opgave8_1.InputMethod();
                                break;
                            case "2":
                                opgave8_1.InputMethod();
                                break;
                            case "3":
                                opgave8_1.InputMethod();
                                break;
                            case "4":
                                opgave8_1.InputMethod();
                                break;
                            case "EXIT":
                                fejl = 0;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "EXIT":
                        fejl = 0;
                        break;
                    default:
                        break;
                }
            }
            //While er for hvis nogen skriver exit.
            while (fejl == 1);
        }
    }

}
