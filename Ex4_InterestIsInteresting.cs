using System;
using System.Diagnostics.CodeAnalysis;

static class SavingsAccount {
    public static float InterestRate(decimal balance) {

        switch (balance) {
            
            case < 0:
                
                return 3.213f;
            case >= 0 and < 1000:
                
                return 0.5f;
            case >= 1000 and < 5000:
                
                return 1.621f;
            case >= 5000:
                
                return 2.475f;
        }
    }

    public static decimal Interest(decimal balance) {

        return decimal.Multiply(balance, decimal.Divide((decimal) InterestRate(balance), 100));
    }

    public static decimal AnnualBalanceUpdate(decimal balance) {

        return decimal.Multiply(balance, decimal.Divide((decimal) InterestRate(balance), 100) + 1);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance) {

        var years = 0;
        
        while (balance < targetBalance) {

            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
