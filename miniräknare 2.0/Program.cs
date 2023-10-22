

class Program
{
    static void Main()
    {
        bool loop = true; //skapar en loop för att kunna stänga av programmet 

        while (loop)
        {
            //Låter användaren välja en reäknemetod och sen spara den till senare
            double resultat = 0;
            string val = "";
            Console.Clear();
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            Console.WriteLine("");

            Console.WriteLine("Please choose one of the methods above");
            Console.WriteLine(""); // skapar en osynlig rad

            Console.Write(">>");
            string metod = Console.ReadLine();

            switch (metod)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    val = metod;
                    break;
                default:
                    Console.WriteLine("Not a valid input"); //om det användaren skrivit in inte stämmer med
                                                            //dem valen som finns så skriver den ut att det inte
                                                            //är giltigt och man får börja om
                    break;
            }

            if (val != "") // kollar om valet inte har ändrats
            {
                Console.Clear();
                Console.WriteLine("Choose the first number"); // låter användaren välja första siffran
                                                               // och sen andra siffran och sparar dem
                Console.Write(">>");
                string tal1 = Console.ReadLine();

                if (double.TryParse(tal1, out double nummer1))
                {
                    Console.WriteLine("Choose the second number");
                    string tal2 = Console.ReadLine();

                    if (double.TryParse(tal2, out double nummer2))
                    {
                        switch (val) // här tar den metoden som vi valde förut och kombinerar med första och andra talet 
                        {
                            case "+":
                                resultat = nummer1 + nummer2;
                                break;
                            case "-":
                                resultat = nummer1 - nummer2;
                                break;
                            case "*":
                                resultat = nummer1 * nummer2;
                                break;
                            case "/":
                                resultat = nummer1 / nummer2;
                                break;
                        }
                        Console.Clear();
                        Console.WriteLine("= " + resultat); //skriver ut resultatet
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input");
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid input");
                }
            }
            
            Console.WriteLine("");
            Console.WriteLine("Write 'quit' to exit or press Enter to continue");
            Console.WriteLine("");
            Console.Write(">>");
            string exitInput = Console.ReadLine().ToLower();
            if (exitInput == "quit")
            {
                loop = false; // här avslutar man programmet
            }
        }
    }
}
