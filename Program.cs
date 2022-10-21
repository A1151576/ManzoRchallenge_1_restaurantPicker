/*                                  Rafael Manzo
                            Restaurant Random Generator.
                                    10/19/2022
In this program we will make an array and call to each of our food catagories, when the user picks a category, it will call 1 - 10 of those indicies and then randomize it through Random.Next() method at the same time. 
            Our three catagories will be as follows: Breakfast, Lunch & Dinner w/ dessert as an extra. These Restaurants are in the Northern Stockton area.
*/Console.Clear();

string[] Breakfast = new string[]{"I HOP","Alberto's Mexican Restaurant", "Noah's NY Bagels","Panera Bread","Tommy's Cafe","Taco Bell","Besito's","Chik-Fil-A","American Waffles", "McDonalds"
};
string[] Lunch = new string[]{"Green Papaya", "Heirloom Kitchen", "Boudin SF", "Yen Du Restaurant", "L&L Hawaiin BBQ", "Tandoori Nites", "Qiang's Bakery", "Halal Pizza", "East N' West Chinese Cuisine", "Pho Binh Minh"
};
string[] Dinner = new string[]{"The Kitchen at StoneBrier", "Market Tavern", "Prime Table", "Domo Stockton", "La Mesa- A Mexican Kitchen", "Peking Chinese Restaurant", "Tu Pueblito Taqueria", "The Creamery", "Sizzler", "De Vega Brothers"
};
string[] Dessert = new string[]{"Dream Ice Cream Parlor", "DF Donuts", "Tutti Frutti Frozen Yogurt", "Yogurtland", "Baskin Robins", "Morada Neveria", "Disco's Waffle on a Stick", "Big Worm's Bakery & Deli"
};
//----------------------------------------------------------------------------------

bool playover = true;

while (playover)
{
    Random rand = new Random();
    Console.WriteLine("Enter 1 for Breakfast, 2 for Lunch, 3 for Dinner, or 4 for Dessert!");
    String userInput = Console.ReadLine();

    int swts = rand.Next(1, 10);


    int dine = rand.Next(1, 10);


    int sunrise = rand.Next(1, 10);
    int lonche = rand.Next(1, 10);

    //-----------------------------------------------------------------
    switch (userInput)
    {
        case "1":

            {
                Console.WriteLine(Breakfast[sunrise]);
                break;
            }

        case "2":
            {
                Console.WriteLine(Lunch[lonche]);
                break;
            }

        case "3":
            {
                Console.WriteLine(Dinner[dine]);

                break;
            }

        case "4":
            {
                Console.WriteLine(Dessert[swts]);
                break;
            }

        default:
            Console.WriteLine("Hmm, try again..");
            break;

    }
    Console.WriteLine("would you like to play again? type no to quit or any key to play again.");
    string answer01 = Console.ReadLine();
    if (answer01 == "no")
    {
        playover = false;
    }

}