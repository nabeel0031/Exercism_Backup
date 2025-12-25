static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed == 0)
            return 0.00;
        if(speed>=1 && speed <= 4)
            return 1.00;
        if(speed>=5 && speed <= 8)
            return 0.90;
        if(speed==9)
            return 0.80;
        if(speed==10)
            return 0.77;

        return 0.00;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double prodPerHour = SuccessRate(speed)*221*speed;
        return prodPerHour;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        int perMinPro = (int)(ProductionRatePerHour(speed) /60);
        return perMinPro;
    }
}
