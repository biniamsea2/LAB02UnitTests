﻿using System;

namespace LAB02UnitTests
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {

            bool displayMenu = true;
            while(displayMenu)
            {
                displayMenu = MainMenu();
            }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The Program is done");
            }

        }
        public static bool MainMenu()
        {
            double balance = 100000;
            Console.WriteLine("Welcome to your Personal ATM!");
            Console.WriteLine("1) View balance");
            Console.WriteLine("2) Deposit Money");
            Console.WriteLine("3) Withdraw balance");
            Console.WriteLine("4) Exit");
            string result = Console.ReadLine();
            try
            {
            if (result == "1")
            {
                View(balance);
                return true;
            }
            else if(result == "2")
                {
                    Console.WriteLine("How much would you like to deposit: ");
                    string amount = Console.ReadLine();
                    double amountNum = Convert.ToInt32(amount);
                    Deposit(balance, amountNum);
                return true;
            }
            else if (result == "3")
            {
                    Console.WriteLine("How much would you like to withdraw? Note: You may not withdraw more than you deposit amount: ");
                    string withdraw1 = Console.ReadLine();
                    double withdrawAmount = Convert.ToInt32(withdraw1);
                    Withdraw(balance, withdrawAmount);
                return true;
            }
            else
            {
                return false;
            }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        public static double View(double balance)
        {
            Console.WriteLine($"Your balance is {balance}");
            return balance;
        }


        public static double Deposit(double balance, double amountNum)
        {

            double total = amountNum + balance;
            Console.WriteLine($"Your new balance is {total}");
            return total;
        }


        public static double Withdraw(double balance, double withdrawAmount)
        {
            
            if (withdrawAmount > balance)
            {
                Console.WriteLine("Uff, sorry you can't withdraw that amount, you dont have that much money...Yikes!");
                return balance;
            }
            else
            {
                double newBalance = balance - withdrawAmount;
                Console.WriteLine($"Your new balance is {newBalance}");

                return newBalance;
            }
        }
    }
}
