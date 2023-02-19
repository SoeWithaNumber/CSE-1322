using System;
class FibFormula : FindFib
{
    public FibFormula ()
    {

    }
    public int calculateFib(int index)
    {
        double phi = (1 - Math.Sqrt(5))/2;
        double goldenRatio = (1 + Math.Sqrt(5)) / 2;
        double approxNum = (Math.Pow(goldenRatio, index) - Math.Pow(phi, index))/Math.Sqrt(5);
        return (int)Math.Round(approxNum);
    }
}