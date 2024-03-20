using System.Text;
using LR12_1_ASP_Zhyhlova.Models;
using LR12_1_ASP_Zhyhlova.DataContext;

namespace LR12_1_ASP_Zhyhlova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            createUser("Катерина", "Жиглова", 20);
            createUser("Аміна", "Голубєва", 21);
            createUser("Марія", "Жиглова", 10);
            readUser();
        }
        static void createUser(string name, string surname, int age)
        {
            using (var results = new UsersContext())
            {
                User user = new User();
                user.Name = name;
                user.Surname = surname;
                user.Age = age;

                results.Users.Add(user);
                results.SaveChanges();
            }
            return;
        }
        static void readUser()
        {
            using (var results = new UsersContext())
            {
                List<User> users = results.Users.ToList();
                foreach (User user in users)
                {
                    Console.WriteLine("{0} {1} {2}", user.Name, user.Surname, user.Age);
                }
            }
            return;
        }
        static void updateUser(User user, User newUser)
        {
            using (var results = new UsersContext())
            {
                if (user != null)
                {
                    user.Name = newUser.Name;
                    user.Surname = newUser.Surname;
                    user.Age = newUser.Age;

                    results.SaveChanges();
                }
            }
            return;
        }
        static void deleteUser(User user)
        {
            using (var results = new UsersContext())
            {
                results.Users.Remove(user);
                results.SaveChanges();
            }
            return;
        }
    }
}
