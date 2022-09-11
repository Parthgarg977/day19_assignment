// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to user registration program");
Console.WriteLine("Select Options Please :\n" +"1-Enter First Name\n" + "2-Enter Last Name\n" + "1-Enter E-mail\n");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    UserRegistration user = new UserRegistration();
                    user.FirstName();
                    break;
                case 2:

                    UserRegistration user1 = new UserRegistration();
                    user1.LastName();
                    break;
    case 3:
        UserRegistration user2 = new UserRegistration();
       
        user2.Email();
        break;

    default:
                    Console.WriteLine("Choose Proper options");
                    break;
            }
