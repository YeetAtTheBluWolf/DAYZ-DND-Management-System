// See https://aka.ms/new-console-template for more information
using DAYZDND.util;
using DAYZDND.users;
using DAYZDND.loot;

namespace DAYZDND;

public class Program
{
    
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
            if(userInput == 2)
            {
                PrintUsers(usernames);
                userInput = UserInput.Int("Choose a user(Type 0 to exit): ");
                if (userInput == 0)
                    break;
                Console.WriteLine(usernames[userInput - 1]);
            }
            if(userInput == 3)
                Console.WriteLine(Generate.ChanceRoll(UserInput.Int("Pick a maximum number: ")));

        }

    }

    private static void PrintUsers(User[] users)
    {
        Console.WriteLine("Users: ");
        for(int i = 0; i < users.Length; i++)
        {
            Console.WriteLine("[{1}] {0}", users[i], i + 1);
        }
    }

}
