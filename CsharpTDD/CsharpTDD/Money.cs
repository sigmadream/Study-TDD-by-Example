﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTDD
{
    internal class Money : IExpression
    {
        public int amount;

        public string currency;

        public string Currency()
        {
            return this.currency;
        }

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public static Money Dollor(int amout)
        {
            return new Money(amout, "USD");
        }

        public static Money Franc(int amout)
        {
            return new Money(amout, "CHF");
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && Currency().Equals(money.Currency());
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public IExpression Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public Money Reduce(Bank bank, string to) 
        {
            int rate = bank.rate(currency, to);
            return new Money(amount / rate, to);
        }

    }
}
