using System;

public class Player
{
    public int RollDie() {

        Random rndNmb = new Random();
        
        return rndNmb.Next(1, 18);
    }

    public double GenerateSpellStrength() {

        Random rndDbl = new Random();

        double rndDec = rndDbl.NextDouble();
        
        return  rndDbl.Next(0, 99) + rndDec;
    }
}
