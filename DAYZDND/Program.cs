// See https://aka.ms/new-console-template for more information
using DAYZDND.util;

namespace DAYZDND;

public class Program
{
    
    public static void Main()
    {
        var numOfUsers = UserInput.Int("Enter a number of users: ");
        string[] usernames = new string[numOfUsers];
        for (int i = 0; i < numOfUsers; i++)
        {
            usernames[i] = UserInput.Line("Enter a name for user #" + (i + 1) + ": ");
        }
    }

}
