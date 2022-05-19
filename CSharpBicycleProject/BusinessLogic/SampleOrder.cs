/*
 Sample order will be based on purchasing 1 bicycle
can be improved by handling more than 1 bicycle
This handling has to do with the custom options and 
how they tie in per bicycle. This could be a simple
fix, like a property of a custom option list. 
 */

namespace CSharpBicycleProject;

internal class SampleOrder
{
    private List<IBicycle> bikeOrder;
    private List<IBikeOption> bikeOptions;
    private SampleInventory inventory;
    private IBicycle bikeChoice;

    public SampleOrder()
    {
        bikeOrder = new List<IBicycle>();
        bikeOptions = new List<IBikeOption>();
        inventory = new SampleInventory();
    }

    public void WelsomeMessage()
    {
        Console.WriteLine("Welcome to Acme Bicycle Company");
        Console.WriteLine("Your One stop shop for Road and Mountain Bikes");
        BuyBike();
    }

    private void BuyBike()
    {
        Console.WriteLine("What kind of bike would you like to buy today?");
        Console.WriteLine("Your Options are:\n"+
            "C - Cross Country\n" +
            "D - DownHill\n" +
            "T - Touring\n" +
            "V - Vintage");


        string type = Console.ReadLine();
        // validate type
        ValidateType(type.ToLower());
        //custome options
        CustomOptions();
        // add to order 
        bikeOrder.Add(bikeChoice);
        // send order to reciept
        new SampleReceipt(bikeOrder, bikeOptions);

    }


    private void CustomOptions()
    {
        Console.WriteLine("We offer various custom options for your bike.");
        Console.WriteLine("What upgrades would ou like?");
        Console.WriteLine(" ls -Leather Seat\n" +
            "lg - Leather Grips\n" +
            "gf - Gold Painted Frame\n" +
            "wt - White Tires\n" +
            "n - None");
        string option = Console.ReadLine();

        ValidateOptions(option);
    }
    // Add additional Options
    /* private void AdditionalOption()
    {
        CustomOptions();
        


    } // end additional options
    */
    private void ValidateOptions(string option)
    {
        switch (option)
        {
            case "ls":
                bikeOptions.Add(new LeatherSeat());
                break;
            case "lg":
                bikeOptions.Add(new LeatherGrips());
                break;
            case "gf":
                bikeOptions.Add(new GoldFrame());
                break;
            case "wt":
                bikeOptions.Add(new WhiteTires());
                break;
            case "done": break;
            default:
                Console.WriteLine("You have made an Invalid choice, Type Done when finished");
                CustomOptions();
                break;
            
        }
    }

    private void ValidateType(string type)
    {
        switch (type)
        {
            case "c":
                bikeChoice = inventory.CrossCountryList.ElementAt(0);
                inventory.CrossCountryList.RemoveAt(0);
                break;
            case "D":
                bikeChoice = inventory.DownHillList.ElementAt(0);
                inventory.DownHillList.RemoveAt(0);
                break;
            case "T":
                bikeChoice = inventory.TouringList.ElementAt(0);
                inventory.TouringList.RemoveAt(0);
                break;
            case "V":
                bikeChoice = inventory.VintageList.ElementAt(0);
                inventory.VintageList.RemoveAt(0);
                break;
        }

    }


}
