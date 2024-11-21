// if(6 >= 3)
// {
//     Console.WriteLine("Hello, World!");
// }

// Console.WriteLine("Skriv ditt namn");

// string name = Console.ReadLine();

// Console.WriteLine("Skriv lösenord");

// string pass = Console.ReadLine();


// if (name == "noname" && pass == "nopass")
// {
//     Console.WriteLine("Welcome");
// }

// else 
// {
//     Console.WriteLine("Wrong username or password");
// }

// for (int i = 0; i < 32; i++)
// {
//     Console.WriteLine("Hello, World!");
// }

// bool PassIsTrue = false;

// string password;


// while (PassIsTrue == false)
// {
//     Console.WriteLine("Skriv lösenordet");
//     password = Console.ReadLine();

//     if (password == "Hello")
//     {
//         PassIsTrue = true;
//     }

// }


// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine("Skriv ett tall");
//     string nummer = Console.ReadLine();
//     bool sucess = int.TryParse(nummer, out int result);
//     if (result > 5)
//     {
//         Console.WriteLine("Större än fem");
//     }
// }



// bool IntTrue = false;

// while (IntTrue == false)
// {
//     Console.WriteLine("Skriv ett tall");
//     string svar = Console.ReadLine();

//     if (int.TryParse(svar, out int result))
//     {
//         Console.WriteLine(svar);
//         IntTrue = true;
//     }

//     else
//     {
//         Console.WriteLine("Skriv ett nummer");
//     }
// }



Random generator = new Random();

int tal = Random.Shared.Next(1, 101);

Console.WriteLine("Försök gissa talet");

int gissning = -1;

while(tal != gissning)

{
    bool IntTrue = false;


    while (IntTrue == false)
    {
        string svar = Console.ReadLine();

        if (int.TryParse(svar, out gissning))
        {
            // Console.WriteLine(svar);
            if (gissning < tal)
            {
                Console.WriteLine("För litet");
            }
            else if(gissning > tal)
            {
                Console.WriteLine("För högt");
            }

            else
            {
                Console.WriteLine($"Du gissade rätt talet var {tal}");
            }
            IntTrue = true;
        }

        else
        {
            Console.WriteLine("Inte en siffra");
        }


    }
}







Console.ReadLine();