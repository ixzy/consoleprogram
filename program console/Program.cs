using System;

namespace program_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var enable = Console.ForegroundColor = ConsoleColor.DarkRed;
            var reset1 = Console.BackgroundColor = ConsoleColor.Black;
            var reset2 = Console.ForegroundColor = ConsoleColor.White;
           
            //Professin story make app cus yes yes yes yes yes yes. so this code makes it so u pick a story
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
            Console.WriteLine(" make a story all the stories we have right now are boxing,night's temple,updated boxing which one would you like?");
            

            string story = Console.ReadLine();
            if(story == "")
            {
                   Console.WriteLine("fr");
                   Console.WriteLine("press a key to exit");
                   Console.ReadKey();
               
            }
            if( story== "nights temple")
            {
                Console.Title = "story = night's temple";
                   Console.WriteLine("lets get started!!!");
               Console.WriteLine("you are...");
               string player1 = Console.ReadLine();
               Console.WriteLine("you are " + player1 + " and your mission is to guard the tower of...");
               string tower = Console.ReadLine();
               Console.WriteLine("you are " + " " + player1 + "" + "and your mission is to guard the tower of " + tower + " there are crimson trying to raid your tower make sure you grab your wepons\n what wepons would you like?");
               string wepons = Console.ReadLine();
               Console.WriteLine("so" + "" + player1 +   " your here with all of your wepons and horses come by with the CRIMSON and they offer of more knight hood to trade and betray your" + tower + "\n do your accept this offer yes or no?");
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
                Console.Title = "story = night's temple";
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
            if(story == "updated boxing")
            {
                Console.Title = "story = updated boxing";
                Console.WriteLine("lets get started");
                Console.WriteLine("mr");
                string boxer1 = Console.ReadLine();
                Console.WriteLine("mr " + boxer1 + " is fighting mr");
                string boxer2 = Console.ReadLine();
                Console.WriteLine("who would you like to win?");
                string winner = Console.ReadLine();
                Console.WriteLine("who would u like to loose?");
                string looser = Console.ReadLine();
                Console.WriteLine("there are 3 moves for each boxer which moves will " + boxer1 + " have?");
                string player1m1 = Console.ReadLine();
                string player1m2 = Console.ReadLine();
                string player1m3 = Console.ReadLine();
                Console.WriteLine("what moves will " + boxer2 + " have?");
                string player2m1 = Console.ReadLine();
                string player2m2 = Console.ReadLine();
                string player2m3 = Console.ReadLine();
                Console.WriteLine("each boxer gets in the Boxing ring who will take the first move?");
                string pm1 = Console.ReadLine();
                Console.WriteLine(pm1 + " takes the first move which move will it be?");
                string pm2 = Console.ReadLine();
                Console.WriteLine(pm1 + " does the " + pm2 + " on");
                string pd1 = Console.ReadLine(); 
                Console.WriteLine(pm1 + " did the " + pm2 + " on " + pd1 +  " what move will "  + pd1 + " do?");
                string md = Console.ReadLine();
                Console.WriteLine(pd1 + " did the " + md + " on " + pm1 + " then "  + winner + " got mad so he did the...");
                string master = Console.ReadLine();
                 Console.WriteLine(pd1 + " did the " + md + " on " + pm1 + " then " + winner + " got mad so he did the " + master + " on " + looser + " " + master + " won the 3,000,000 dollar prize should he keep it?");
                 string money = Console.ReadLine();
                 if(money == "yes")
                 {
                     Console.WriteLine(winner + " has kept the money prize :)");
                 }
                 if(money == "no")
                 {
                     Console.WriteLine("he no kep moneys");
                 }
            }
            if (story == "boxing")
            {
                Console.Title = "story = boxing";
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
