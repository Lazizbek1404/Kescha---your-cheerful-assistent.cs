namespace KESCHA.Classes
{

    public class Bird : Animal
    {
        
        public Bird (int age, int userAge, string name)
            : base( age, userAge, name )
        {

        }

        public override void Greet(string username)
        {

            Console.WriteLine($"Hi, {username}");
            
        }

    }

}