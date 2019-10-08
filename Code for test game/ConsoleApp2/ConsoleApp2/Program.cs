using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.WriteLine(@"   __                     _   _____              _      _       
  / /    __ _  _ __    __| |  \_   \ _ __   ___ (_)  __| |  ___ 
 / /    / _` || '_ \  / _` |   / /\/| '_ \ / __|| | / _` | / _ \
/ /___ | (_| || | | || (_| |/\/ /_  | | | |\__ \| || (_| ||  __/
\____/  \__,_||_| |_| \__,_|\____/  |_| |_||___/|_| \__,_| \___|
                                                                ");

        Console.WriteLine("(Mr Void): Hello, And Welcome Fellow Traveller To The World Of LandInside. Now What Is Your  Name?" + "");

        string username = Console.ReadLine();

        Console.WriteLine("(Mr Void): Hello " + username + "");

        Console.WriteLine("(Mr Void): Are You Sure Your Ready To Start Your Journey [Yes] [No]");

        string end = Console.ReadLine();

        if (end == "No")
        {
            Console.WriteLine("(Mr Void): Fair Enough, Perhaps I Shall See You Some Other Time, Goodbye For Now");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("(Mr Void): Then I Shall Let You Continue On Your Adventure. Good Luck You Are Going To Need  It...");
        }

        Console.WriteLine("(World): ~~~Your Adventure Begins~~~");
        {
            Console.WriteLine("(World): Do you want to go [Left] or [Right]");

            string direction = Console.ReadLine();

            if (direction == "Left")
            {

                Console.WriteLine("(World): You have gone left. A Fire blocks your path. Would you like to go back [Yes] [No]?" + "\n");





            }
            else
            {
                Console.WriteLine("(World): You begin to walk down the dark corridor and come face to face with a big  wooden door" + "\n");
            }

        }










    }
}