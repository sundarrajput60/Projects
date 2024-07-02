using DependencyInjection.Models;

namespace DependencyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Home home = new Home();
            Person person = new Person(home);
            person.school = new School();

            person.TakeRefuge();
            person.Study();
            

        }
    }
}
