using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class Driver
{
    public static void Main(string[] args)
    {
        List<WeatherEvent> weatherEvents = new List<WeatherEvent>();

        Console.WriteLine("[Weather Tracking System]");

        bool cont = true;
        while (cont)
        {
            Console.WriteLine("1. Add weather event");
            Console.WriteLine("2. Update location");
            Console.WriteLine("3. Update active");
            Console.WriteLine("4. View all events");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your option: ");
            int input = Int32.Parse(Console.ReadLine());


            //option 1 to add a weather event
            //ask the user for the type of weather event (rain, snow, fog, particle)
            //ask for all necessary information
            //add weather event to the List
            //print an error message if the user picks a weather event that doesnt exist
            if (input == 1)
            {
                Console.WriteLine("1. Rain");
                Console.WriteLine("2. Snow");
                Console.WriteLine("3. Fog");
                Console.WriteLine("4. Particle");
                Console.Write("What type of weather event is being added? ");
                int weather = Int32.Parse(Console.ReadLine());

                //option 1 for Rain
                if (weather == 1)
                {
                    Console.Write("Where is the event happening? ");
                    string location = Console.ReadLine();
                    Console.Write("What is the rate of fall? (in/h) ");
                    double rateOfFall = double.Parse(Console.ReadLine());
                    Console.Write("What is the diameter of the drops? (in) ");
                    double dropSize = double.Parse(Console.ReadLine());
                    Rain rain = new Rain(location, true, rateOfFall, dropSize);
                    weatherEvents.Add(rain);
                    Console.WriteLine("Rain event added");
                }


                //option 2 for Snow
                else if (weather == 2)
                {
                    Console.Write("Where is the event happening? ");
                    string location = Console.ReadLine();
                    Console.Write("What is the rate of fall? (in/h) ");
                    double rateOfFall = double.Parse(Console.ReadLine());
                    Console.Write("What is the temperature? (F) ");
                    int temperature = Int32.Parse(Console.ReadLine());
                    Snow snow = new Snow(location, true, rateOfFall, temperature);
                    weatherEvents.Add(snow);
                    Console.WriteLine("Snow event added");
                }


                //option 3 for Fog
                else if (weather == 3)
                {
                    Console.Write("Where is the event happening? ");
                    string location = Console.ReadLine();
                    Console.Write("What is the visibility? (1/8 mi) ");
                    int visibility = Int32.Parse(Console.ReadLine());
                    if (visibility < 1)
                    {
                        visibility = 1;
                    }
                    if (visibility > 4)
                    {
                        visibility = 4;
                    }
                    Console.Write("Is the fog freezing? (y/n) ");
                    string freeze = Console.ReadLine();
                    bool freezing = true;
                    if (freeze.Equals("y"))
                    {
                        freezing = true;
                    }
                    if (freeze.Equals("n"))
                    {
                        freezing = false;
                    }
                    Fog fog = new Fog(location, true, visibility, freezing);
                    weatherEvents.Add(fog);
                    Console.WriteLine("Fog event added");
                }


                //option 4 for Particle
                else if( weather == 4)
                {
                    Console.Write("Where is the event happening? ");
                    string location = Console.ReadLine();
                    Console.Write("What is the visibility? (1/8 mi) ");
                    int visibility = Int32.Parse(Console.ReadLine());
                    Console.Write("What is the obscuration made of? (Sand/Dust/Ash/Other) ");
                    string particleType = Console.ReadLine();
                    Particle particle = new Particle(location, true, visibility, particleType);
                    weatherEvents.Add(particle);
                    Console.WriteLine("Particle event added");
                }
                else
                {
                    Console.WriteLine("No event with that id. ");
                }
            }


            //option 2 to update location
            //ask the user for the ID of a weather event
            //if ID exists, ask user for new location of event and update it
            //otherwise print an error
            else if (input == 2)
            {
                Console.Write("Enter id of weather event: ");
                int id = Int32.Parse(Console.ReadLine());
                bool contains = false;
                for (int i = 0; i < weatherEvents.Count; i++)
                {
                    if (weatherEvents[i].getId() == id)
                    {
                        Console.Write("Enter the new location of the weather event (currently \"" + weatherEvents[i].getLocation() + "\"): ");
                        string location = Console.ReadLine();
                        weatherEvents[i].setLocation(location);
                        Console.WriteLine("Location added");
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    Console.WriteLine("No event with that id.");
                }
            }


            //option 3 to update active
            //ask user for ID of an event
            //if ID exists, invert the activity status
            //otherwise print an error message
            else if (input == 3)
            {
                Console.Write("Enter id of weather event: ");
                int id = Int32.Parse(Console.ReadLine());
                bool contains = false;
                for (int i = 0; i < weatherEvents.Count; i++)
                {
                    if (weatherEvents[i].getId() == id)
                    {
                        if (weatherEvents[i].getActive() == true)
                        {
                            weatherEvents[i].setActive(false);
                            Console.WriteLine("Event set to \"inactive\"");
                        }
                        else
                        {
                            weatherEvents[i].setActive(true);
                            Console.WriteLine("Event set to active");
                        }
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    Console.WriteLine("No event with that id.");
                }
            }
            



            //option 4 to view all events
            //Call the toString of each event in the List
            else if (input == 4)
            {
                for (int i = 0; i < weatherEvents.Count; i++)
                {
                    Console.WriteLine(weatherEvents[i].ToString());
                    Console.WriteLine();
                }
            }



            //option 5 to quit
            else if (input == 5)
            {
                cont = false;
            }



            //catch all else to print an error
            else
            {
                Console.WriteLine("Invalid option!");
            }
        }
    }
}