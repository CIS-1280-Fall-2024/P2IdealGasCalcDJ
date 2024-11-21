// Your Name // Your Email // IdealGas.cs // Date

public class IdealGas
{
    private double mass;
    private double volume;
    private double temp;
    private double molecularWeight;
    private double pressure;

    public object? PV { get; private set; }

    private double P;

    public object? nRT { get; private set; }
    public object? constant { get; private set; }
    public int mol { get; private set; }
    public object? K { get; private set; }
    public int J { get; private set; }
    public double R { get; private set; }

    public void SetMass(double mass)
    { this.mass = mass;
        Calc(GetConstant(), R, GetK());
    }
    public double GetMass()
    {
        return mass;
    }
    public void SetVolume(double volume)
    { this.volume = volume;
        Calc(GetConstant(), R, GetK());
    }
    public double GetVolume()
    { return volume;
    } public void SetTemp(double temp)
    { this.temp = temp; Calc(GetConstant(), R, GetK());
    } public double GetTemp()
    { return temp;
    }
    public void SetMolecularWeight(double molecularWeight)
    {
        this.molecularWeight = molecularWeight; Calc(GetConstant(), R, GetK());
    }
    public double GetMolecularWeight()
    {
        return molecularWeight;
    }
    public double GetPressure()
    {
        return pressure;
    }

    private object GetConstant()
    {
        return constant;
    }

    private object GetK()
    {
        return K;
    }

    private void Calc(object constant, double r, object k)
    {
        PV = nRT;
        P = (mass / molecularWeight) * r * temp / volume; const double R = 8.314;
        int mol2 = (mol);
        Kdouble v = mass / molecularWeight * R * temp;
        pressure = v;
            }
}

internal class Kdouble
{
    public static implicit operator Kdouble(double v)
    {
        throw new NotImplementedException();
    }

    public static implicit operator double(Kdouble v)
    {
        throw new NotImplementedException();
    }
}

internal class GetConstant
{
}

internal class Universal
{
}