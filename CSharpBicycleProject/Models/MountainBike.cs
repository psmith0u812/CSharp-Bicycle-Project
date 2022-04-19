
namespace CSharpBicycleProject;

internal abstract class MountainBike : Bicycle
{
    public override string Style { get; } = "Mountain Bike";

    protected MountainBike(IWheelInterface Wheel)
        : base(Wheel) { }
}
