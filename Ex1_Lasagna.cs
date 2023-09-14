class Lasagna {
    public int ExpectedMinutesInOven() {

        return 40;
    }
    public int RemainingMinutesInOven(int actual) {

        return (ExpectedMinutesInOven() - actual);
    }
    public int PreparationTimeInMinutes(int amountLayer) {
        
        return (amountLayer * 2);
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int amountLayer, int actual)
    {

        return ((amountLayer * 2) + actual);
    }
}
