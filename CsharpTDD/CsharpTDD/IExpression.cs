﻿namespace CsharpTDD
{
    internal interface IExpression
    {
        Money Reduce(Bank bank, string to);
    }
}