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
            string opgave;
            int fejl = 1;
            //Har en do while til at starte med for at kunne prøve flere opgaver igennem eller hvis fejl skrivning skulle ske.
            do
            {
                Console.Clear();
                Console.WriteLine("Hej her kan du vælge mellem løste opgaver!");
                Console.WriteLine("Du skal skrive hvilket kapitel og kapiteldel, ligesom såden her '1_1'");
                Console.WriteLine("Indtil videre er 1_1, 1_2, 1_3, 1_4, 1_5, 2_1, 2_2, 2_3 klaret");
                Console.WriteLine("Hvis man vil ud af programmet kan man skrive exit");
                //Konvertere til upper så det ligegyldig hvordan de skriver.
                opgave = Console.ReadLine().ToUpper();
                switch (opgave)
                {
                    case "1_1":                       
                        opgave1_1.InputMethod();
                        break;
                    case "1_2":
                        opgave1_2.InputMethod();
                        break;
                    case "1_3":
                        opgave1_3.InputMethod();
                        break;
                    case "1_4":                        
                        opgave1_4.InputMethod();
                        break;
                    case "1_5":                       
                        opgave1_4.InputMethod();
                        break;
                    case "2_1":
                        opgave2_1.InputMethod();
                        break;
                    case "2_2":
                        opgave2_1.InputMethod();
                        break;
                    case "2_3":
                        opgave2_3.InputMethod();
                        break;
                    case "3_1":
                        opgave3_1.InputMethod();
                        break;
                    case "3_2":
                        opgave3_2.InputMethod();
                        break;
                    case "4":
                        opgave4.InputMethod();
                        break;
                    case "4_1":                                               
                        opgave4_1.SquareMethod();
                        break;
                    case "4_5":
                        opgave4_5.InputMethod();
                        break;
                    case "5_1":
                        opgave5_1.CounterMethod();
                        break;
                    case "5_2":
                        opgave5_2.CounterMethod();
                        break;
                    case "5_3":
                        opgave5_3.TextMethod();
                        break;
                    case "6_1":
                        opgave6_1.InputMethod();
                        break;
                    case "7_1":
                        opgave7_1.InputMethod();
                        break;
                    case "7_2":
                        opgave7_2.InputMethod();
                        break;
                    case "7_3":
                        opgave7_3.InputMethod();
                        break;
                    case "7_5":
                        opgave7_5.InputMethod();
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
