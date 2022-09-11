using System.Text.RegularExpressions;

    public class UserRegistration
    {
        public void FirstName()
        {
            Console.WriteLine("Please Enter First Name :");
            string data = Console.ReadLine();

            string pattern = "^[A-Z][a-z]{2,10}$";

            Regex regobj = new Regex(pattern);

            if (regobj.IsMatch(data))
            {
                Console.WriteLine("First Name is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("First Name is Invalid");
                Console.ResetColor();
            }
        }
    }