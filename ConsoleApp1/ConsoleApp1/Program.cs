using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("sdf","1456787");
            user.Username = "rzyv.ruslan";
            user.Password = "dbvdnd";
            user.Login();
            user.CheckPassword(user.Password);
        }
    }
}