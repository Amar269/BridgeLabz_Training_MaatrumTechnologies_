using System;
// now creating a interfaces
interface Ivechicle
{
    void vechiclesound();

}

// actually alredy class car created first now going to implment the abstract class and method .
// Abstract class creation 
public abstract class Pricing
{
    public abstract double Calculatecost();
}

// Fuel Pricing class creation .

class FuelPricing : Pricing
{
    private double Tankcapacity;
    private double priceperliter;

    public FuelPricing(double capacity, double price)
    {
        Tankcapacity = capacity;
        priceperliter = price;
    }
    public override double Calculatecost()
    {
        return Tankcapacity * priceperliter;
    }

}

// so we will create a class for the Ev pricing 

class Evpricing : Pricing
{
    private double chargingcost;

    public Evpricing(double cost)
    {
        chargingcost = cost;

    }
    public override double Calculatecost()
    {
        return (chargingcost / 1000.0) * 500;
    }

}

// class created

class Car : Ivechicle
{
    public string brand; // this field
    public string color { get; set; } // this is property
    protected Pricing pricing;
    private int speed;


    public int Speed
    {
        get
        {
            return speed;
        }
        set
        {
            if (value < 0)
            {
                speed = 0;
                Console.WriteLine("speed cannot be  less than 0.");

            }
            else if (value > 300)
            {
                speed = 300;
                Console.WriteLine("speed cannot be more than 300.");
            }
            else
            {
                speed = value;
            }
        }
    }


    //public string color = "black";// the field
    //public int speed = 200.


    public Car(string b, string c, int s, Pricing p) //this is the  cosntructor and created  with multiple parameters
    {
        brand = b;
        color = c;
        // this is used before the creating the set and get.
        // speed = s;
        Speed = s;
        pricing = p;

    }
    public void model() // this it the method 
    {
        Console.WriteLine("The " + brand + " car is the king of SUV's");
    }
    public virtual void start()
    {
        Console.WriteLine(" -> This cars starts with fuel or diesel.");
    }
    public void ShowRunningCost()
    {
        Console.WriteLine("Running cost:" + pricing.Calculatecost() + " Rs");
    }
    public virtual void vechiclesound()
    {
        Console.WriteLine("-> The " + brand + "sounds very loud");
    }

}

// created new class and it is drived class form the car , new class name  is Evcar.
// \- "Sealed Class Name" -/
// if we use "Sealed class car " , then we can derive it for the Evcar

class Evcar : Car
{
    public int battery;
    public Evcar(string b, string c, int s, int bat, Pricing p) : base(b, c, s, p)
    {
        battery = bat;
    }

    /* this base is used :
      If parent class has parameterized constructor, child class must call it using base(...)*/
    public void modelEv()
    {
        Console.WriteLine("The " + brand + " Ev is the best Evcar in the Evcar segement. ");

    }

    public override void start()
    {
        Console.WriteLine(" -> EVcars starts with the current.");
    }
    public override void vechiclesound()
    {
        Console.WriteLine("-> The " + brand + "Evcar sound is very silent");
    }

}

class Bike : Ivechicle
{
    public int speeds;
    public string Brandn;

    public Bike(int ss, string bn)
    {
        speeds = ss;
        Brandn = bn;
    }
    public void vechiclesound()
    {
        Console.WriteLine("This bike sounds like a racing bike");
    }
}
// here working wiht main function of all class.
class Amar
{
    static void Main(String[] args)
    {
        // before creating constructor code.
        /* cfhhf
        c2.brand = "BMW";
        c2.color = "Black";
        c2.speed = 200;*/

        // before creating constructor code.
        /*c1.brand = "AUDI";
        c1.color = "Red";
        c1.speed = 250; */
        Pricing fuel1 = new FuelPricing(45, 115); // using abstract method implemted 
        Car c1 = new Car("Audi", "Red", 200, fuel1); // this code after constructor created

        Pricing fuel2 = new FuelPricing(35, 105);
        Car c2 = new Car("BMW", "Black", 200, fuel2);

        Pricing Evpr1 = new Evpricing(5000);
        Evcar Ev1 = new Evcar("TATA", "Green", 190, 5000, Evpr1);

        Bike bk1 = new Bike(150, "Duke 150");



        Console.WriteLine();
        c1.model();
        Console.WriteLine("The car color is : " + c1.color);
        Console.WriteLine("The car speed is : " + c1.Speed);
        c1.vechiclesound();
        c1.ShowRunningCost();

        Console.WriteLine();
        c2.model();
        Console.WriteLine("The car color is : " + c2.color);
        Console.WriteLine("The car speed is : " + c2.Speed);
        c2.ShowRunningCost();
        Console.WriteLine();

        Ev1.modelEv();
        Ev1.start();
        Console.WriteLine("The Evcar color is : " + Ev1.color);
        Console.WriteLine("The Evcar speed is : " + Ev1.Speed);
        Ev1.vechiclesound();
        Ev1.ShowRunningCost();
        Console.WriteLine();

        Console.WriteLine("The Bike speed is : " + bk1.speeds);
        bk1.vechiclesound();


        Console.ReadLine();

    }
}
