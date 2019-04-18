using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
Constructs randomized sentances following this format:
"Ok Kel, I'm gonna need you to get <THING>, <THING>, and <THING> and meet me <PLACE>! Come on, <NICKNAME>!"
 */
namespace RandomGen1
{
    class RandomGen1
    {
        static void Main(string[] args)
        {
			Random rnd1 = new Random();
			string[] Things = {"a cow",
										"a sandbag",
										"a television",
										"a pound of butter",
										"some snow shoes",
										"some peanut butter",
										"a spice girl",
										"a pony",
										"a handful of dirt",
										"a dinosaur egg",
										"an iPad",
										"a waffle",
										"PewDiePie",
										"some kryptonite",
										"some orange soda",
										"a flagpole",
										"a clown",
										"some cookies",
										"three hamsters",
										"some guacamole",
										"your uncle",
										"twenty seven pizzas",
										"a macaroon",
										"George Wahsington's left nipple",
										"a potato battery",
										"900 hard boiled eggs"};
			string[] Places = {"at the church",
										"at the bus stop",
										"at the library",
										"where I'm going",
										"at the pool",
										"on the roof",
										"at the pool",
										"at Dr. Frank's House of Waffles",
										"by the old oak tree",
										"over there",
										"at the courthouse",
										"on the moon",
										"in a dumpster",
										"by a downed power line",
										"somewhere in Africa",
										"at the potato farm",
										"here, but in an hour",
										"here, but yesterday",
										"at the blood bank",
										"at Mt. Fuji",
										"at the Statue of Liberty",
										"in the audience",
										"on the Internet",
										"at the car lot",
										"in Death Valley",
										"on Minecraft"};
            string[] Nicknames = {"Blocky",
										"Stuffy",
										"Froggy",
										"Tiddilywink",
										"Hiroshima",
										"Punchy",
										"Fishy",
										"Plucky",
										"Scrubby",
										"Sneezy",
										"Billy",
										"Partner",
										"Spicy",
										"Blocky",
										"Monkey",
										"Troll",
										"OrangeSodaFan27",
										"...You",
										"Kel",
										"Crazy",
										"Kel-chan",
										"Sharpie",
										"and don't forget anything",
										"get a move on",
										"Slowpoke",
										"Knucklehead"};
			string QUIT = "quit"; //When user enters this stgring, the program will exit.
            bool exit = false; //This becomes true when the user types in "quit"
			Console.WriteLine("To exit program, type \"quit\" into the console.");
            while(exit == false)
            {
                /*
				To generate 2 different values from one list, use this
				int g1 = rnd1.Next(0,GroupA.Length); 
                int g2 = rnd1.Next(0,GroupA.Length);
                */
                int sp = rnd1.Next(0,999); //one in 1000 chance of special outcome
				int t1 = rnd1.Next(0,Things.Length); //get first int for thing list 
                int t2 = rnd1.Next(0,Things.Length); //get second int for thing list
				while(t1 == t2)
				    t2 = rnd1.Next(0,Things.Length); //ensure no duplicates
                int t3 = rnd1.Next(0,Things.Length); // get third int for thing list
                while(t3 == t2 || t3 == t1)
				    t3 = rnd1.Next(0,Things.Length); //ensure no duplicates
                int pl = rnd1.Next(0,Places.Length); //get int for Place
                int nk = rnd1.Next(0,Nicknames.Length);//get int for nickname
                if (sp == 23)
                {
                    Console.WriteLine("Ok Kel, I'm gonna need you to get some cheerleaders, some cheerleaders, and some cheerleaders, and meet me at the pool. Come on, Shifty!");
                }
                else if (sp == 42)
                {
                    Console.WriteLine("Ok Kel, I'm gonna need you to get something, something else, a third thing, and meet me there. Come on, Nickname!");
                }
                else{
                Console.WriteLine("Ok Kel, I'm gonna need you to get {0}, {1}, and {2} and meet me {3}! Come on, {4}!", Things[t1], Things[t2], Things[t3], Places[pl], Nicknames[nk]);
                }
                string input = Console.ReadLine();
                if(input == QUIT)// If user enters "quit" program closes.
                {
                    exit = true;
                }
            }
		}
	}
}
