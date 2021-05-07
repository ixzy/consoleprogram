using System;

namespace program_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Professin story make app cus yes yes yes yes yes yes.
            Console.Title = "Title making App";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
             Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("██▓▒██   ██▒▒███████▒▓██   ██▓  ██████      ██████ ▄▄▄█████▓ ▒█████   ██▀███ ▓██   ██▓     ▄████  ▄▄▄      ███▄ ▄███▓▓█████ ");
            Console.WriteLine("▓██▒▒▒ █ █ ▒░▒ ▒ ▒ ▄▀░ ▒██  ██▒▒██    ▒    ▒██    ▒ ▓  ██▒ ▓▒▒██▒  ██▒▓██ ▒ ██▒▒██  ██▒    ██▒ ▀█▒▒████▄   ▓██▒▀█▀ ██▒▓█   ▀  ");
            Console.WriteLine("▒██▒░░  █   ░░ ▒ ▄▀▒░   ▒██ ██░░ ▓██▄      ░ ▓██▄   ▒ ▓██░ ▒░▒██░  ██▒▓██ ░▄█ ▒ ▒██ ██░   ▒██░▄▄▄░▒██  ▀█▄ ▓██    ▓██░▒███    ");
            Console.WriteLine("░██░ ░ █ █ ▒   ▄▀▒   ░  ░ ▐██▓░  ▒   ██▒     ▒   ██▒░ ▓██▓ ░ ▒██   ██░▒██▀▀█▄   ░ ▐██▓░   ░▓█  ██▓░██▄▄▄▄██▒██    ▒██ ▒▓█  ▄ ");
            Console.WriteLine("░██░▒██▒ ▒██▒▒███████▒  ░ ██▒▓░▒██████▒▒   ▒██████▒▒  ▒██▒ ░ ░ ████▓▒░░██▓ ▒██▒ ░ ██▒▓░   ░▒▓███▀▒ ▓█   ▓██▒██▒   ░██▒░▒████▒");
            Console.WriteLine("░▓  ▒▒ ░ ░▓ ░░▒▒ ▓░▒░▒   ██▒▒▒ ▒ ▒▓▒ ▒ ░   ▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░  ██▒▒▒     ░▒   ▒  ▒▒   ▓▒█░ ▒░   ░  ░░░ ▒░ ░");
            Console.WriteLine(" ▒ ░░░   ░▒ ░░░▒ ▒ ░ ▒ ▓██ ░▒░ ░ ░▒  ░ ░   ░ ░▒  ░ ░    ░      ░ ▒ ▒░   ░▒ ░ ▒░▓██ ░▒░      ░   ░   ▒   ▒▒ ░  ░      ░ ░ ░  ░");
            Console.WriteLine(" ▒ ░ ░    ░  ░ ░ ░ ░ ░ ▒ ▒ ░░  ░  ░  ░     ░  ░  ░    ░      ░ ░ ░ ▒    ░░   ░ ▒ ▒ ░░     ░ ░   ░   ░   ▒  ░      ░      ░   ");
            Console.WriteLine(" ░   ░    ░    ░ ░     ░ ░           ░           ░               ░ ░     ░     ░ ░              ░       ░  ░      ░      ░  ░");
            Console.WriteLine("            ░         ░ ░                                                     ░ ░                                           ");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" make a story all the stories we have right now are boxing and the night's temple which one would you like?");
            string story = Console.ReadLine();
            if(story == "")
            {
                   Console.WriteLine("fr");
                   Console.WriteLine("press a key to exit");
                   Console.ReadKey();
               
            }
            if( story== "nights temple")
            {
                   Console.WriteLine("lets get started!!!");
               Console.WriteLine("you are...");
               string player1 = Console.ReadLine();
               Console.WriteLine("you are " + player1 + " and your mission is to guard the tower of...");
               string tower = Console.ReadLine();
               Console.WriteLine("you are " + player1 + " and your mission is to guard the tower of " + tower + " there are crimson trying to raid your tower make sure you grab your wepons\n what wepons would you like?");
               string wepons = Console.ReadLine();
               Console.WriteLine("so" + player1 + "your here with all of your wepons and horses come by with the CRIMSON and they offer of more knight hood to trade and betray your" + tower + "\n do your accept this offer yes or no?");
               string bbd = Console.ReadLine();
               if (bbd == "yes")
               {
                   Console.WriteLine("you have betrayed your " + tower +" " + player1);
                   Console.WriteLine("now you run for crimson");
                   string lastkey = "Thank you guys for playing this game! it is in development i am happy people are enjoying it.";
                Console.WriteLine(lastkey);
                Console.WriteLine("personal message u did da wrong fing https://giphy.com/gifs/lady-gaga-applause-artpop-AfOYUaEZtXc64");
                   Console.WriteLine("press a key to exit");
                   Console.ReadKey();
               }
               if (bbd == "no")
               {
                   Console.WriteLine("you slash the crimson with your " + wepons + " and you leave 1 alive for a message not to come back or else");
                   string lastkey = "Thank you guys for playing this game! it is in development i am happy people are enjoying it.";
                Console.WriteLine(lastkey);
                   Console.WriteLine("press a key to exit and i am sorry this was short :)");
                   Console.ReadKey();
               }
            }
            if (story == "night's temple")
            {
               Console.WriteLine("lets get started!!!");
               Console.WriteLine("you are...");
               string player1 = Console.ReadLine();
               Console.WriteLine("you are " + player1 + " and your mission is to guard the tower of...");
               string tower = Console.ReadLine();
               Console.WriteLine("you are " + player1 + " and your mission is to guard the tower of " + tower + " there are crimson trying to raid your tower make sure you grab your wepons\n what wepons would you like?");
               string wepons = Console.ReadLine();
               Console.WriteLine("so" + player1 + "your here with all of your wepons and horses come by with the CRIMSON and they offer of more knight hood to trade and betray your" + tower + "\n do your accept this offer yes or no?");
               string bbd = Console.ReadLine();
               if (bbd == "yes")
               {
                   Console.WriteLine("you have betrayed your " + tower +" " + player1);
                   Console.WriteLine("now you run for crimson");
                   string lastkey = "Thank you guys for playing this game! it is in development i am happy people are enjoying it.";
                Console.WriteLine(lastkey);
                Console.WriteLine("personal message u did da wrong fing https://giphy.com/gifs/lady-gaga-applause-artpop-AfOYUaEZtXc64");
                   Console.WriteLine("press a key to exit");
                   Console.ReadKey();
               }
               if (bbd == "no")
               {
                   Console.WriteLine("you slash the crimson with your " + wepons + " and you leave 1 alive for a message not to come back or else");
                   string lastkey = "Thank you guys for playing this game! it is in development i am happy people are enjoying it.";
                Console.WriteLine(lastkey);
                   Console.WriteLine("press a key to exit and i am sorry this was short :)");
                   Console.ReadKey();
               }
            
            
            
            
            }
            if (story == "boxing")
            {
                Console.WriteLine("lets get started!!!");
                  Console.WriteLine("mr...");
            string test = Console.ReadLine();
            Console.WriteLine("mr "  + test + " was fighting mr...");
            string test2 = Console.ReadLine();
            Console.WriteLine(test2 + " was fighting and fighting but then mr...");
            string test3 = Console.ReadLine();
            Console.WriteLine( test3 + " Won the fight knocking mr...");
            string ko = Console.ReadLine();
            Console.WriteLine( ko + " out");
            Console.WriteLine("mr "+ ko + " has sadly lost the fight by being knocked out by...");
            Console.WriteLine( " who won the fight?");
            string test4 = Console.ReadLine();
            Console.WriteLine("mr " + test4 + " knocked out " +  ko);
            Console.WriteLine("mr " + test4 + " won the grand prize of 3,000,000");
            Console.WriteLine("do you think mr " + test4 + " should keep the money or not? yes or no?");
            string str = Console.ReadLine();
            if(str == "yes")
            {
                Console.WriteLine("mr " + test4 + " kept the 3,000,000 !!! do you want to give it to charity? yes or no");
                string charity = Console.ReadLine();
                if (charity == "yes")
                {
                    Console.WriteLine("it was givin to charity");
                }
                if (charity == "no")
                {
                    Console.WriteLine("it was not givin to charity");
                }
            }
            if(str == "no")
            {
                Console.WriteLine("mr " + test4 + " has not kept the money");
            }
            string lastkey = "Thank you guys for playing this game! it is in development i am happy people are enjoying it.";
            Console.WriteLine(lastkey);
            Console.WriteLine("pls press a key and the console will exit!!");
            Console.ReadKey();
            }
            if(story == "none")
            {
                Console.WriteLine("Well that is sad");
                string lastkey = "Thank you guys for playing this game! it is in development i am happy people are enjoying it.";
                Console.WriteLine(lastkey);
                   Console.WriteLine("press a key to exit");
                   Console.ReadKey();
                
            }
            
        
        }
    }
}
