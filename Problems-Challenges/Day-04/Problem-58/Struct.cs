using System.Xml.Linq;

namespace StructProgram;

public class Struct
{
        struct UserData
        {
            public string strName;
            public int nAge;
        }
        public static void Solution()
        {
            UserData user;

        Console.Write("Please enter your name: ");
        user.strName = Console.ReadLine();


        Console.Write("Please enter your age: ");
        bool bIsSuccess1 = int.TryParse(Console.ReadLine(), out  user.nAge);

        user.nAge = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hello, {user.strName}!");
    }
}
        

