public class Program
    {
        public static void DisplayHeader() 
    { Console.WriteLine("Your Name - Ideal Gas Equation Program"); 
        Console.WriteLine("This program calculates the pressure of an ideal gas.");
    }
        public static void GetMolecularWeights(out string[] gasNames, out double[] molecularWeights) 
    { 
        gasNames = new string[] 
        { "Oxygen", "Nitrogen", "Carbon Dioxide"
        }; molecularWeights = new double[] 
        { 32.00, 28.02, 44.01 
        }; 
    }
        public static void DisplayGasNames(string[] gasNames) 
    { Console.WriteLine("Available gases:"); 
        for (int i = 0; i < gasNames.Length; i++) 
        { 
            Console.WriteLine($"{i + 1}. {gasNames[i]}"); 
        }
    }
        public static double GetMolecularWeightFromName(string name, string[] gasNames, double[] molecularWeights) 
    { 
        for (int i = 0; i < gasNames.Length; i++) 
        { 
            if (gasNames[i].Equals(name, StringComparison.OrdinalIgnoreCase)) 
            { return molecularWeights[i]; 
            } 
        } throw new Exception("Gas not found."); 
    }
        public static void DisplayPressure(double pressure) 
    { 
        Console.WriteLine($"Pressure: {pressure} Pa");
    }
        public static double PaToPSI(double pressure) { return pressure * 0.000145038; 
    }
}
