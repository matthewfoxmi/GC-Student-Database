//loop back to start of program
bool runProgram = true;
while (runProgram)
{ 
    //list of students, favorite foods and hometowns
    string[] students = { "Justin Jones", "Connor Wood", "Kris Pranger", "Josh Carolin", "Krista Anderson", "Travis Amador", "Asia Drew", "Ali Al-Hashemi",
                          "Vinh Dang", "Tolulope Olubunmi", "Robot Haupt", "Matt Fox", "Daniel Schuler", "Anthony Ventura", "Mara Johnson", "Brandon Harman", "Olukayode Olubunmi" };

    string[] food = { "Baja Blast", "Chicken Sandwich", "Sushi", "Naleśniki", "Sushi", "General Tso's", "Jerk chicken", "Steak",
                          "Sushi", "Rice and Dodo", "Bread", "Steak", "BBQ", "Thai", "tacos", "Pasta", "Pounded Yam" };

    string[] hometown = { "Wyoming, MI", "Grosse Pointe, MI", "Grosse Pointe, MI", "Westland, MI", "Grosse Ile, MI", "Brown City, MI", "Detroit, MI", "Dearborn Heights, MI",
                          "Shelby, MI", "Asese, Nigeria", "Green Bay, WI", "Sterling Heights, MI", "Potterville, MI", "Canton, MI", "Rochester, MI", "Dallas, TX", "Ibadan, Nigeria" };
  
    //loop back here if user input is out of range
    bool wrongInput = true;
    while (wrongInput)
    {
        Console.WriteLine("Enter a number 1-17 to learn more about students.");
        int input = int.Parse(Console.ReadLine()) - 1;

        if (input < 0 || input > students.Length -1)
        {
            Console.WriteLine($"Sorry, the number you entered is out of range!  Please try again! Enter a number between 1 and 17");
        }
        else
        {
            Console.WriteLine($"That student is: {students[input]}.  Would you like to know their hometown or favorite food?  Enter hometown/favorite food");
            //loop back here if user inputs wrong phrase
            bool choice2 = true;
            while (choice2)
            {
                string choice1 = Console.ReadLine();

                if (choice1.ToLower().Trim() == "hometown")
                {
                    Console.WriteLine($"{students[input]}'s hometown is {hometown[input]}");
                    choice2 = false;
                    break;
                }
                else if (choice1.ToLower().Trim() == "favorite food" || choice1.ToLower().Trim() == "food")
                {
                    Console.WriteLine($"{students[input]}'s favorite food is {food[input]}");
                    choice2 = false;
                    break;
                }
                else
                {
                    Console.WriteLine($"{choice1} is not the right phrase to use.  Please enter hometown/favorite food");
                }
            }
            //looping back to start of program
            Console.WriteLine("would you like to learn about another student? y/n");
            string choice = Console.ReadLine();
            if (choice.ToLower().Trim() == "y")
            {
                break;
            }
            else if (choice.ToLower().Trim() == "n")
            {
                Console.WriteLine("Goodbye!");
                runProgram = false;
                break;
            }
        }
    }
}

