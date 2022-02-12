// Importing neccessary Libraries
using System;
using System.Collections.Generic;
//Class Definition
public class Car
{
    //Attributes to store the values of object
    public string make, model, speed_string;
    public int speed;

    //Constructor Definition
    //No parameter were passed as it ask for user input in this constructor
    Car()
    {
        //User input for Maker of the car
        Console.WriteLine("Enter the maker = ");
        this.make = Console.ReadLine();
        //User input for model of the car 
        Console.WriteLine("Enter the Model = ");
        this.model = Console.ReadLine();
        //User input for Speed of the car
        Console.WriteLine("Enter the speed = ");
        this.speed_string = Console.ReadLine();

        //Converting String to Integer Type
        this.speed = Convert.ToInt32(speed_string);
    }

    //Method to check the cars information
    //If more than 10 demerits then Liscence Suspended
    void Check_car(int limit)
    {
        int demerits;
        if (this.speed < limit)
        {
            Console.WriteLine(this.make + " " + this.model + " " + this.speed_string + "mph : OK");
            return;
        }
        else
        {
            demerits = (this.speed - limit) / 5;
            if (demerits >= 10)
            {
                //In sample test case, number of demerits were 12, but it was showing 10
                //if you want that demerits should be shown as 10 if they exceed 10
                //Just make minor changes in Console.ReadLine() here

                Console.WriteLine(this.make + " " + this.model + " " + this.speed_string + "mph : " + demerits.ToString() + "demerits <LICENSE SUSPENDED>");
                return;
            }
            else
            {
                Console.WriteLine(this.make + " " + this.model + " " + this.speed_string + "mph : " + demerits.ToString() + "demerits");
                return;
            }
        }

    }

    //main Method
    public static void Main(string[] args)
    {
        //Asking user for speed limit
        Console.WriteLine("Enter the speed Limit");
        string speed_limit = Console.ReadLine();
        int speed_limit_int = Convert.ToInt32(speed_limit);

        //Creating three car objects
        Car c1 = new Car();
        Car c2 = new Car();
        Car c3 = new Car();
        Console.WriteLine("\n");

        //Calling check_car() method on all three cars
        c1.Check_car(speed_limit_int);
        c2.Check_car(speed_limit_int);
        c3.Check_car(speed_limit_int);


    }
}