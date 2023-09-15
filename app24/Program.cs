﻿using System;
using System.Linq;
using validate;

static class Program
{
    static void Main()
    {
        Individual customerA = new Individual("pesho", "0845161435", "0145072222");
        Individual customerB = new Individual("kiro", "+359812457896", "0145074585");
        Compani customerC = new Compani("Nashata", "0885161435", "01454095478");
        Compani customerD = new Compani("NzBrat", "+359812457111", "01454095478");

        Deposit akauntA = new Deposit(customerA, 500, 0.5);
        Deposit akauntB = new Deposit(customerC, 56500, 0.4);
        Loan akauntC = new Loan(customerA, 12500, 0.8);
        Loan akauntD = new Loan(customerD, 14500, 0.9);
        Mortgage akauntE = new Mortgage(customerB, 200000, 1);
        Mortgage akauntS = new Mortgage(customerC, 455566, 1.2);

        Bank bank = new Bank();
        bank.AddAcount(akauntA);
        bank.AddAcount(akauntB);
        bank.AddAcount(akauntC);
        bank.AddAcount(akauntD);
        bank.AddAcount(akauntE);
        bank.AddAcount(akauntS);
        //Console.WriteLine(bank);

        string output = "";

        for (int i = 0; i < bank.Acounts.Count; i++)
        {
            //output += bank.Acounts[i].CalculateInterest(10).ToString() + "\n";
            bank.Acounts[i].DepositMoney(1000);
        }

        Console.WriteLine(bank);
    }
}