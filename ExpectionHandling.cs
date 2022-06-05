using System;

class ExpectionHandling
{

    public double Compute(double x, double y, double z)
    {

        double b = 0;

        try{

            double a = x + y + z;
            b = a / (y + z);

            if(double.IsInfinity(b)){
                throw new Exception("Division with 0 occured");
            }

        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }

        return b;
    }

}