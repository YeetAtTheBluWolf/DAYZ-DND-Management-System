#pragma warning disable CS8604 
#pragma warning disable CS8603

namespace DAYZDND.util
{
    public class UserInput
    {
        public static int Int(string question)
        {
            try
            {
                Console.Write(question);
                return int.Parse(Console.ReadLine());
            } catch
            {
                return Int(question);
            }
        }

        public static string Line(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

    }
}
