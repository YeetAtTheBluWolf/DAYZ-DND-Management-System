// See https://aka.ms/new-console-template for more information
using DAYZDND.util;
using DAYZDND.users;
using DAYZDND.loot;

namespace DAYZDND;

public class Program
{

    private static readonly ItemIdentidy Items = new();

    public static void Main()
    {
        var numOfUsers = UserInput.Int("Enter a number of users: ");
        User[] usernames = new User[numOfUsers];
        for (int i = 0; i < numOfUsers; i++)
        {
            usernames[i] = new User(UserInput.Line("Enter a name for user #" + (i + 1) + ": "));
        }

        while(true)
        {
            int userInput = UserInput.Int("[1] To Quit\n[2] Users\n[3] Roll a dice\n[4] Generate Loot\nType a number to continue: ");
            if (userInput == 1)
                break;
            else if(userInput == 2)
            {
                PrintUsers(usernames);
                userInput = UserInput.Int("Choose a user(Type 0 to exit): ");
                if (userInput == 0)
                    break;
                int chosenUser = userInput - 1;
                userInput = UserInput.Int("[1] Status\n[2] Get Inventory\n[3] Add a item\n[4] Remove a item\n[5] Edit Description\n[6] Change health\n[7] Add zombie kills\nWhat do you want to do: ");
                if(userInput == 1)
                {
                    Console.WriteLine(usernames[chosenUser].ToString());
                }
                if(userInput == 2)
                {
                    Console.WriteLine(usernames[chosenUser].GetInv());
                }
                if(userInput == 3)
                {
                    Console.WriteLine(Items.GetItemList());
                    userInput = UserInput.Int("What item do you chose: ");
                    usernames[chosenUser].AddToInv(Items.GetItem(userInput));
                    Console.WriteLine(usernames[chosenUser].GetInv());
                }
            }
            else if(userInput == 3)
                Console.WriteLine(Generate.ChanceRoll(UserInput.Int("Pick a maximum number: ")));

        }

    }

    private static void PrintUsers(User[] users)
    {
        Console.WriteLine("Users: ");
        for(int i = 0; i < users.Length; i++)
        {
            Console.WriteLine("[{1}] {0}", users[i].Name, i + 1);
        }
    }

}
