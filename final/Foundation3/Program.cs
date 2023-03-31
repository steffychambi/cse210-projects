using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //Lectures

        //Setting Variables for the Lecture event
        string title1 = "The Therapist as Human: An Existential Perspective";
        string date1 = "Fri, Mar 31, 2023";
        string time1 = "10:30 AM";
        Address address1 = new Address("7470 Durgan Mountain Suite 569", "Krajcikhaven", "Montana", "USA");
        
        //Creating the Lecture Event 
        LectureEvent lectureEvent = new LectureEvent(title1, date1, time1, address1);

        //Setting the Description
        lectureEvent.SetDescription("This seminar will attempt to address a number of issues and concerns raised by and for therapists regarding the possibility of their own and their clients’ experience of their humanity while retaining an appropriate professional stance.");

        //Setting the Capacity
        lectureEvent.SetCapacity(30);

        //Setting the Speaker Name
        lectureEvent.SetSpeakerName("Ernesto Spinelli");
        
        //Displaying the three different types of messages
        Console.WriteLine("First Event\n\r");
        lectureEvent.ShowShortDescription();
        Console.WriteLine();
        lectureEvent.ShowStandardDetails();
        Console.WriteLine();
        lectureEvent.ShowFullDetails();
        Console.WriteLine();

        //Receptions

        //Setting Variables for the Reception event
        Console.WriteLine("Second Event\n\r");
        string title2 = "Layla and Gabriel WEDDING RECEPTION";
        string date2 = "Sat, Apr 01, 2023";
        string time2 = "05:00 PM";
        Address address2 = new Address("Studio 52m Edwards Shoals", "Lake Nikkitown", "Pricestad", "United Kingdom");
        
        //Creating the Reception Event 
        ReceptionEvent receptionEvent = new ReceptionEvent(title2, date2, time2, address2);

        //Setting the Description
        receptionEvent.SetDescription($"Together with their families, Layla and Gabriel have chosen the first day of their new life together to be saturday, april 1rst, 2023 at {address2.ReturnAddress()}, you are invited to share in their joy as they exchange marriage vows, please kindly confirm your participation by March 30th.");
        
        //Setting the RSVP email
        receptionEvent.SetEmail($"laylaandgabriel@gmail.com");

        //Displaying the three different types of messages
        receptionEvent.ShowShortDescription();
        Console.WriteLine();
        receptionEvent.ShowStandardDetails();
        Console.WriteLine();
        receptionEvent.ShowFullDetails();
        Console.WriteLine();

        //Outdoor Gathering

        //Setting Variables for the Outdoor Gathering
        string title3 = "Summer Party";
        string date3 = "Sat, Apr 08, 2023";
        string time3 = "11:30 AM";
        Address address3 = new Address("Calle Carrión, 317, 01º B", "Os Campos", "Salamanca", "Spain");
        
        //Creating the Outdoor Event 
        OutdoorEvent outdoorEvent = new OutdoorEvent(title3, date3, time3, address3);

        //Setting the Description
        outdoorEvent.SetDescription("Sun's out! Time to get the grill out!");

        //Setting the weather
        outdoorEvent.SetWeather("Sunny");

        //Displaying the three different types of messages
        Console.WriteLine("Third Event\n\r");
        outdoorEvent.ShowShortDescription();
        Console.WriteLine();
        outdoorEvent.ShowStandardDetails();
        Console.WriteLine();
        outdoorEvent.ShowFullDetails();
        Console.WriteLine();

    }
}