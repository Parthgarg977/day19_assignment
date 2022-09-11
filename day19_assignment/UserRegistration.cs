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

    public void LastName()
    {
        Console.WriteLine("Please Enter Last Name :");
        string data = Console.ReadLine();

        string pattern = "^[A-Z][a-z]{2,12}$";

        Regex regobj = new Regex(pattern);

        if (regobj.IsMatch(data))
        {
           
            Console.WriteLine("Last Name is Valid");
            Console.ResetColor();
        }
        else
        {
            
            Console.WriteLine("Last Name is Invalid");
            Console.ResetColor();
        }
    }
    public void Email()
    {
        Console.WriteLine("Please Enter Email :");
        string data = Console.ReadLine();

        string pattern = "^[a-zA-z]{3,}([.][a-zA-Z]{3,})[@][a-z]{2}[.][a-z]{2}([.][a-z]{2})$";

        //creating object of the Regex superclass

        Regex regobj = new Regex(pattern);

        if (regobj.IsMatch(data))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Email is Valid");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Email is Invalid");
            Console.ResetColor();
        }
    }
}