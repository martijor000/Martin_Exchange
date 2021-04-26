using System;

namespace Martin_Exchange
{
    class Program
    {

        private static ConsoleKeyInfo oldCurrency;
        private static ConsoleKeyInfo newCurrency;
        private static double inputMoney;
        private static double outputMoney;
        private static double newDollars = 0;
        private static ExchangeMonitor em = new ExchangeMonitor();

        private static void Main(string[] args)
        {

            do
            {
                do
                {

                    StartingCurrency();

                } while (!CheckKey(oldCurrency));

                if (oldCurrency.Key == ConsoleKey.Q)
                {
                    break;
                }

                do
                {
                    ExchangeCurrency();

                } while (!CheckKey(newCurrency));


                if (newCurrency.Key == ConsoleKey.Q)
                {
                    break;
                }
                CurrencySelected(oldCurrency, newCurrency);
                USDollars();

            } while (oldCurrency.Key != ConsoleKey.Q || newCurrency.Key != ConsoleKey.Q);

            GoodBye();
        }


        private static void StartingCurrency()
        {
            Console.WriteLine("Welcome to Money Exchanger TM. Please select your currency.");
            Console.Write("(E)uro, (B)ritish Pound, (C)anadian Dollar, (U)S Dollar, (Q)uit");
            Console.WriteLine("");
            oldCurrency = Console.ReadKey();
            Console.Clear();
        }

        private static bool CheckKey(ConsoleKeyInfo checkChoice)
        {
            if (checkChoice.Key == ConsoleKey.E || checkChoice.Key == ConsoleKey.B || checkChoice.Key == ConsoleKey.C || checkChoice.Key == ConsoleKey.U || checkChoice.Key == ConsoleKey.Q)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void ExchangeCurrency()
        {
            Console.WriteLine("Please select a currency you wish to exchange to.");
            Console.Write("(E)uro, (B)ritish Pound, (C)anadian Dollar, (U)S Dollar, (Q)uit");
            Console.WriteLine("");
            newCurrency = Console.ReadKey();
            Console.Clear();
        }

        private static void CurrencySelected(ConsoleKeyInfo current, ConsoleKeyInfo newExchange)
        {

            string identifyExchange = current.Key.ToString() + newExchange.Key.ToString();

            if (identifyExchange == "EE")
            {
                Input();
                outputMoney = Exchanger.EURtoEUR(inputMoney);
                Output();
            }
            else if (identifyExchange == "EB")
            {
                Input();
                outputMoney = Exchanger.EURtoGBP(inputMoney);
                Output();
            }
            else if (identifyExchange == "EC")
            {
                Input();
                outputMoney = Exchanger.EURtoCAN(inputMoney);
                Output();
            }
            else if (identifyExchange == "EU")
            {
                Input();
                outputMoney = Exchanger.EURtoUSD(inputMoney);
                Output();
            }
            else if (identifyExchange == "BB")
            {
                Input();
                outputMoney = Exchanger.GBPtoGBP(inputMoney);
                Output();
            }
            else if (identifyExchange == "BE")
            {
                Input();
                outputMoney = Exchanger.GBPtoEUR(inputMoney);
                Output();
            }
            else if (identifyExchange == "BC")
            {
                Input();
                outputMoney = Exchanger.GBPtoCAN(inputMoney);
                Output();
            }
            else if (identifyExchange == "BU")
            {
                Input();
                outputMoney = Exchanger.GBPtoUSD(inputMoney);
                Output();
            }
            else if (identifyExchange == "CC")
            {
                Input();
                outputMoney = Exchanger.CANtoCAN(inputMoney);
                Output();
            }
            else if (identifyExchange == "CE")
            {
                Input();
                outputMoney = Exchanger.CANtoEUR(inputMoney);
                Output();
            }
            else if (identifyExchange == "CB")
            {
                Input();
                outputMoney = Exchanger.CANtoGBP(inputMoney);
                Output();
            }
            else if (identifyExchange == "CU")
            {
                Input();
                outputMoney = Exchanger.CANtoUSD(inputMoney);
                Output();
            }
            else if (identifyExchange == "UU")
            {
                Input();
                outputMoney = Exchanger.USDtoUSD(inputMoney);
                Output();
            }
            else if (identifyExchange == "UE")
            {
                Input();
                outputMoney = Exchanger.USDtoEUR(inputMoney);
                Output();
            }
            else if (identifyExchange == "UB")
            {
                Input();
                outputMoney = Exchanger.USDtoGBP(inputMoney);
                Output();
            }
            else if (identifyExchange == "UC")
            {
                Input();
                outputMoney = Exchanger.USDtoCAN(inputMoney);
                Output();
            }
        }

        private static void Input()
        {
            Console.WriteLine("How much would you like to exchange?");
            inputMoney = double.Parse(Console.ReadLine());
        }
        private static void Output()
        {
            Console.Clear();
            em.IncrementAmount();
            Console.WriteLine("Money has been converted to : " + outputMoney);
        }

        private static double USDollars()
        {


            newDollars = Exchanger.USD() + newDollars;

            return newDollars;
        }

        private static void GoodBye()
        {
            Console.Clear();
            Console.WriteLine("Total transactions made : " + em.TotalTransactions);
            Console.WriteLine("Total conversions in USD : " + newDollars);
            Console.WriteLine("Thank you for stopping bye. See you next time!");
        }
    }
    
}
