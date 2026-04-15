class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutes_in_oven)
    {
        return ExpectedMinutesInOven() - minutes_in_oven;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int lasagna_layers) 
    {
        return lasagna_layers * 2;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int lasagna_layers, int minutes_in_oven) 
    {
        return minutes_in_oven + PreparationTimeInMinutes(lasagna_layers);
    }
}
