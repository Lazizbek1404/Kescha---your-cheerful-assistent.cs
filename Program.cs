using KESCHA.Classes;

namespace KESCHA
{

    class Program
    {

        static void Main()
        {

            try
            {

                Console.WriteLine("Hello, New User!");
                Console.WriteLine("Please, Input your name: ");
                string foydalanuvchiIsmi = Console.ReadLine();
                Console.WriteLine("Nice to meet you, " + foydalanuvchiIsmi);

                Console.WriteLine("Please, Input your age: ");
                int userAge = Convert.ToInt32(Console.ReadLine());

                const int ANIMALAGE = 2;
                const string ANIMALNAME = "Kescha";
                Animal kescha = new Animal(ANIMALAGE, userAge, ANIMALNAME);

                Console.WriteLine(kescha.Allinfo);

                kescha.tellAboutYourFriends();
                kescha.ageCheck();

                Animal finch = new Bird(10, userAge, "Finchy");
                finch.ageCheck();
                Console.WriteLine(finch.Allinfo);
                finch.Greet(foydalanuvchiIsmi);

                Animal luna = new Pet (12, userAge, "Luna");
                luna.ageCheck();
                Console.WriteLine(luna.Allinfo);
                luna.Greet(foydalanuvchiIsmi);

            }
            catch (FormatException formatException)
            {
                Console.WriteLine($"Error was detected. {formatException.Message}");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error was detected in uknown type");
            }

        }

    }

}


