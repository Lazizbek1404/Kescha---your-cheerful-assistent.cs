namespace KESCHA.Classes
{

    public class Pet: Animal
    {

        public Pet (int age, int userAge, string name)
            : base( age, userAge, name )
        {

        }

        public override void Greet(string username)
        {
            
            Console.WriteLine($"Meow, {username}");

        }

    }

}