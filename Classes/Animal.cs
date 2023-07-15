namespace KESCHA.Classes
{

    public class Animal: IAnimal
    {
        public int UserAge { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public int AgeDifference { get; set; }
        public string Allinfo { get; set; }
        public Animal()
        {
            Age = 0;
            AgeDifference = 0;
            Name = "No Name";
            Allinfo = "There is no information";
        }


        public Animal(
            int animalAge, 
            int userAge, 
            string animalName)
        {
            UserAge = userAge;
            Age = animalAge;
            AgeDifference = Math.Abs(userAge - animalAge);
            Name = animalName;
            Allinfo = informationgather(Age, AgeDifference, Name);
        }

        public virtual void Greet (string username)
        {

            Console.WriteLine($"Hello, {username}");

        }

        public void ageCheck()
        {
            if (Age > UserAge)
            {
                Console.WriteLine($"You younger than {Name}");
            }
            
            else if (Age == UserAge)
            {
                Console.WriteLine($"You are at the same age as {Name}");
            }

            else
            {
                Console.WriteLine($"You are older than {Name}");
            }
        }


        public void tellAboutYourFriends()
        {
            string[] friendsName = {"Zufar", "Behruz", "Jasur", "Muhammadjon"};
            string[] friendsAddress = { "Gulistan", "Oqoltin", "Shirin", "Shirin"};
            int[] friendsAge = {14, 15, 15, 15};

            int counter = 0;
            int limit = friendsName.Length;
            while (limit > counter)
            {
                Console.WriteLine($"My friend's name is {friendsName[counter]}.");
                Console.WriteLine($"He is {friendsAge[counter]} years old.");
                Console.WriteLine($"He is from {friendsAddress[counter]}");

                counter++;
            }
        }


        public string informationgather (int age, int ageDiff, string name)
        {
            return $"{name} is {age} year old, the difference between your and Kescha's age is {ageDiff}";
        }

    }


}