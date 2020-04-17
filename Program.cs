using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using Microsoft.Azure.Amqp.Framing;
using Newtonsoft.Json.Serialization;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CraterSizeCalculator
{
    class Program
    {
        private static int Main(string[] args)
        {
            // CrateSizeCalc.cpp : This file contains the 'main' function. Program execution begins and ends there.
            //


            Console.WriteLine("Hello World! I will help you calculate the size of a moon crater based on your telescope camera. I will need: P is the image scale per pixel in arc seconds, S is the size of the pixel in microns, FL is the focal length in inches, and the f/ of your telescope For the record:");

            Console.WriteLine("");
            
            Console.WriteLine("Day Length  Mercury 1, 408 hours Venus 5, 832 hours Earth 24 hours Mars 25 hour Jupiter 10 hours Saturn 11 hours Uranus 17 hours Neptune 16 hours.");

            Console.WriteLine("");
            
            Console.WriteLine("Year Length Mercury: 88 days Venus: 225 days Earth : 365 days Mars : 687 days  Jupiter : 4, 333 days Saturn : 10,759 days Uranus : 30,687 days Neptune : 60,190 days ");

            Console.WriteLine("");
            
            Console.WriteLine("Press 1 to find how many miles across a Moon crater is based on the focal length of your telescope..\n");

            Console.WriteLine("");
            
            Console.WriteLine("Press 2 to calculate the depth of a Moon crater.");

            Console.WriteLine("");

            Console.WriteLine("Version 1.0. Things to fix: program crashing when user enteres decimal. Interface is pretty crappy, need to clean up a bit. Need to test on more telescope focal lengths and camera pixels as well.");
 Console.WriteLine("");
            
            Console.WriteLine("C 2020 Keifmeister. May be a bit experimental. May not give an eact number, but close enough. I base my calculation on the rounded distance from the Earth to the Moon which is slightly different every day.");
            int action= Convert.ToInt32(Console.ReadLine());



            switch (action)
            

            {
                
                case 1:


                    Console.WriteLine("Enter size of pixel in microns");
                    double input_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter size of f/ of your telescope.");
                    double input_2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter focal length of your telescope.");
                     double input_3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter how many pixels across item is.");
                    double input_4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter your cameras micropixels.");
                   double cmicropixels
                     = Convert.ToInt32(Console.ReadLine());
                    double cmicropixelsd;
                    

                    double result;
                    double result2;
                    double mresult;
                    
                    double moonresult;
                 double P;
                    double mresult2;


                    cmicropixelsd = cmicropixels / 10000;
                    moonresult = input_4 * cmicropixelsd;




                    Console.WriteLine("The size of your moon object in kilometers from one side to another is");
                    Console.WriteLine(moonresult * 2);
                    

                    Console.WriteLine("The size in miles is");
                    mresult = moonresult *0.621371;
                    Console.WriteLine(mresult);

                    break;


                  
                    

                case 2:

                    Console.WriteLine("Enter the shadow angle of the crater");
                    int input_5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the length of the crater");
                    int input_7 = Convert.ToInt32(Console.ReadLine());
                double H;
                    

                    H = Math.Tan(input_5) * input_7;

                    Console.WriteLine("Your crater is");
                    Console.WriteLine(H);

                    break;





                    


            }

            return action;
        }
    }
}