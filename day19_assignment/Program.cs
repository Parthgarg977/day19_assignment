// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to user registration program");
Console.WriteLine("Select Options Please :\n" +"1-Enter First Name\n");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    UserRegistration user = new UserRegistration();
                    user.FirstName();
                    break;

                default:
                    Console.WriteLine("Choose Proper options");
                    break;
            }
