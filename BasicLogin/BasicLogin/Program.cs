using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogin
{
    class Program
    {
        string user, pass;
        public void getString()
        {
            Console.Write("Please input default username: ");
            user = Console.ReadLine();
            Console.Write("Please input default password: ");
            pass = Console.ReadLine();
        }
        public void login()
        {
            int count = 0;
            while (count < 3) {
                    Console.Write("Please input username: ");
                    string login_user = Console.ReadLine();
                    Console.Write("Please input password: ");
                    string login_pass = Console.ReadLine();
                    if ((login_user == user) && (login_pass == pass))
                    {
                        Console.WriteLine("Login successful.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong username or password. Login unsuccessful.");                        
                        count++;
                        Console.ReadKey();
                        continue;
                    }
                }
            if (count >= 3) Console.WriteLine("Access Denied. Please try again later.");
        }
        static void Main(string[] args)
        {
            Program access = new Program();
            access.getString();
            access.login();
            Console.ReadKey();
        }
    }
}
