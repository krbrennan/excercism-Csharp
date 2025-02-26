static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        //throw new NotImplementedException("Please implement the (static) SavingsAccount.InterestRate() method");
        if (balance < 0)
        {
            return (float) 3.213;
        }
        else if (balance < 1000)
        {
            return (float) 0.5;
        } else if ((balance >= 1000) && balance < 5000)
        {
            return (float) 1.621;
        } else
        {
            return (float) 2.475;
        }
    }

    public static decimal Interest(decimal balance)
    {
        //throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
        return ((decimal) InterestRate(balance) / 100) * (decimal) balance;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        //throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
        return Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        //throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
        int years = 0;
        decimal updatedYearlyBalance = balance;
        // DO WHILE TIME BABY
        do
        {
            updatedYearlyBalance = AnnualBalanceUpdate(updatedYearlyBalance);
            years += 1;
        }
        while (updatedYearlyBalance < targetBalance);
        return years;
    }
}
