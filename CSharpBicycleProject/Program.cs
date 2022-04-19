﻿using CSharpBicycleProject;

// TestingModel();
// TestSerialGenerator();
TestBIkeOptions();

// Testing Bike Options
void TestBIkeOptions()
{
    Touring touring = new Touring(new NormalWheel());
    LeatherGrips grips = new LeatherGrips();
    decimal total = touring.Price + grips.OptionAmount;
    Console.WriteLine($"Bike Price is {touring.Price} and leather grips {grips.OptionAmount}");
    Console.WriteLine($"Total price is {total}");
}



// Testing Serial Number Generator
void TestSerialGenerator()
{
    Downhill downhill = new Downhill(new WideWheel());
    SerialNumberGenerator generator = SerialNumberGenerator.Instance;
    generator.SetModelAndStart(downhill.Model, downhill.StartNumber);
    downhill.SerialNumber = generator.GetNextSerial();
    Console.WriteLine($"First Serial {downhill.SerialNumber}");
    Console.WriteLine($"Next Serial {generator.GetNextSerial()}");
    Console.WriteLine($"Next Serial {generator.GetNextSerial()}");
    Console.WriteLine($"Next Serial {generator.GetNextSerial()}");

    Console.WriteLine();
    SerialNumberGenerator myGen = SerialNumberGenerator.Instance;
    myGen.SetModelAndStart(downhill.Model, generator.RecentNumber);
    Console.WriteLine($"Next myGen Serial {generator.GetNextSerial()}");
    Console.WriteLine($"Next myGen Serial {generator.GetNextSerial()}");



}

// Testing Base Model
void TestingModel()
{
    Vintage myBike = new Vintage(new NormalWheel());
    Console.WriteLine(myBike.Wheel.IsWide);
    Console.WriteLine(myBike.Model);
    Console.WriteLine(myBike.FrameColor);

}