using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyConveter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 5000;

            decimal Bitcoin = 7840;
            decimal Etherium = 586.15m;
            decimal Litecoin = 119.04m;


            decimal cash = 0;
            decimal bitcoinBalance = 0;
            decimal etheriumBalance = 0;
            decimal litecoinBalance = 0;

            bool exit = true;



            do
            {
                Console.WriteLine("Would you like to: \nP)urchase currency\nS)ell currency for cash\nV)iew account balances\nT)ransfer between currency types");

                ConsoleKey answer = Console.ReadKey(true).Key;
                Console.Clear();
                switch (answer)
                {
                    case ConsoleKey.P:
                        Console.WriteLine("What currency do you want to purchase\nB)itcoin\nE)therium\nL)itecoin");
                        ConsoleKey purchaseAnswer = Console.ReadKey(true).Key;
                        switch (purchaseAnswer)
                        {
                            case ConsoleKey.B:
                                Console.WriteLine("How much bitcoin do you want to buy in $?");
                                decimal bitcoinPurchaseAmount = decimal.Parse(Console.ReadLine());
                                if (balance >= bitcoinPurchaseAmount)
                                {
                                    balance = balance - bitcoinPurchaseAmount;
                                    bitcoinBalance = bitcoinPurchaseAmount / Bitcoin;
                                    Console.WriteLine($"You know own {bitcoinBalance} bitcoin");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient funds.");
                                }


                                break;
                            case ConsoleKey.E:
                                Console.WriteLine("How much Etherium do you want to buy in $?");
                                decimal etheriumPurchaseAmount = decimal.Parse(Console.ReadLine());
                                if (balance >= etheriumPurchaseAmount)
                                {
                                    balance = balance - etheriumPurchaseAmount;
                                    etheriumBalance = etheriumPurchaseAmount / Etherium;
                                    Console.WriteLine($"You know own {etheriumBalance} Etherium");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient funds.");
                                }
                                break;
                            case ConsoleKey.L:
                                Console.WriteLine("How much LiteCoin do you want to buy in $?");
                                decimal litecoinPurchaseAmount = decimal.Parse(Console.ReadLine());
                                if (balance >= litecoinPurchaseAmount)
                                {
                                    balance = balance - litecoinPurchaseAmount;
                                    litecoinBalance = litecoinPurchaseAmount / Litecoin;
                                    Console.WriteLine($"You know own {litecoinBalance} LiteCoin");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient funds.");
                                }
                                break;

                            default:
                                break;
                        }
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("What currency do you want to sell\nB)itcoin\nE)therium\nL)itecoin");
                        ConsoleKey sellAnswer = Console.ReadKey(true).Key;
                        switch (sellAnswer)
                        {
                            case ConsoleKey.B:
                                Console.WriteLine($"How much bitcoin do you want to sell?\nBitCoin Balance: {bitcoinBalance}");
                                decimal bitcoinSellAmount = decimal.Parse(Console.ReadLine());
                                if (bitcoinBalance >= bitcoinSellAmount)
                                {
                                    balance = balance + (bitcoinSellAmount * Bitcoin);
                                    bitcoinBalance = bitcoinBalance - bitcoinSellAmount;
                                    Console.WriteLine($"Your cash balance is now {balance:c}");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient funds.");
                                }


                                break;
                            case ConsoleKey.E:
                                Console.WriteLine($"How much Ethierium do you want to sell?\nEtherium Balance: {etheriumBalance}");
                                decimal etheriumSellAmount = decimal.Parse(Console.ReadLine());
                                if (etheriumBalance >= etheriumSellAmount)
                                {
                                    balance = balance + (etheriumSellAmount * Etherium);
                                    etheriumBalance = etheriumBalance - etheriumSellAmount;
                                    Console.WriteLine($"Your cash balance is now {balance:c}");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient funds.");
                                }
                                break;
                            case ConsoleKey.L:
                                Console.WriteLine($"How much LiteCoin do you want to sell?\nLiteCoin Balance: {litecoinBalance}");
                                decimal litecoinSellAmount = decimal.Parse(Console.ReadLine());
                                if (litecoinBalance >= litecoinSellAmount)
                                {
                                    balance = balance + (litecoinSellAmount * Litecoin);
                                    litecoinBalance = litecoinBalance - litecoinSellAmount;
                                    Console.WriteLine($"Your cash balance is now {balance:c}");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient funds.");
                                }
                                break;
                        }
                        break;
                    case ConsoleKey.V:
                        Console.WriteLine($"Cash Blanance: {balance:c}\nBitcoin Balance: {bitcoinBalance}\n" +
                            $"Etherium Balance: {etheriumBalance}\nLiteCoin Balance: {litecoinBalance}");
                        break;
                    case ConsoleKey.T:
                        Console.WriteLine("What currency do you want to purchase\nB)itcoin\nE)therium\nL)itecoin");
                        ConsoleKey transferAnswer = Console.ReadKey(true).Key;
                        string toBeBoughtName = "";
                        decimal toBeBoughtCoin = 0;
                        decimal coinBalance = 0;
                        switch (transferAnswer)
                        {
                            case ConsoleKey.B:
                                toBeBoughtName = "Bitcoin";
                                toBeBoughtCoin = Bitcoin;
                                coinBalance = bitcoinBalance;
                                break;
                            case ConsoleKey.E:
                                toBeBoughtName = "Etherium";
                                toBeBoughtCoin = Etherium;
                                coinBalance = etheriumBalance;
                                break;
                            case ConsoleKey.L:
                                toBeBoughtName = "Litecoin";
                                toBeBoughtCoin = Litecoin;
                                coinBalance = litecoinBalance;
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("What currency do you want to transfer from\nB)itcoin\nE)therium\nL)itecoin");
                        ConsoleKey transferFromAnswer = Console.ReadKey(true).Key;


                        decimal toBeTransferedCoin = 0;
                        string toBeTransferedName = "";
                        decimal transferCoinBalance = 0;

                        switch (transferFromAnswer)
                        {
                            case ConsoleKey.B:
                                toBeTransferedName = "Bitcoin";
                                toBeTransferedCoin = Bitcoin;
                                transferCoinBalance = bitcoinBalance;
                                break;
                            case ConsoleKey.E:
                                toBeTransferedName = "Etherium";
                                toBeTransferedCoin = Etherium;
                                transferCoinBalance = etheriumBalance;
                                break;
                            case ConsoleKey.L:
                                toBeTransferedName = "Litecoin";
                                toBeTransferedCoin = Litecoin;
                                transferCoinBalance = litecoinBalance;
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine($"How much {toBeTransferedName} (in coins) would you like to exchange for {toBeBoughtName}\n Balance: {transferCoinBalance}?");
                        decimal coinTransferAmount = decimal.Parse(Console.ReadLine());

                        if (transferCoinBalance * toBeTransferedCoin >= coinTransferAmount)
                        {
                            transferCoinBalance = transferCoinBalance - coinTransferAmount;

                            coinBalance += (toBeTransferedCoin * coinTransferAmount) / toBeBoughtCoin;
                            Console.WriteLine($"You know own {coinBalance} {toBeBoughtName}");

                            if (toBeTransferedCoin == Bitcoin)
                            {
                                bitcoinBalance = transferCoinBalance;
                            }

                            if (toBeTransferedCoin == Etherium)
                            {
                                etheriumBalance = transferCoinBalance;
                            }

                            if (toBeTransferedCoin == Litecoin)
                            {
                                litecoinBalance = transferCoinBalance;
                            }

                            if (toBeBoughtCoin == Bitcoin)
                            {
                                bitcoinBalance = coinBalance;
                            }

                            if (toBeBoughtCoin == Etherium)
                            {
                                etheriumBalance = coinBalance;
                            }

                            if (toBeBoughtCoin == Litecoin)
                            {
                                litecoinBalance = coinBalance;
                            }


                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds.");
                        }


                        break;
                    case ConsoleKey.Escape:
                        exit = false;
                        break;

                    default:

                        break;
                }
            } while (exit);

        }
    }
}

