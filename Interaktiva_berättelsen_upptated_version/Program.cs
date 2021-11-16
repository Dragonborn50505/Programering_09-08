using System;

string currentRoom = "crossroads";

string option = "";

while (currentRoom != "gameover")
currentRoom == Crossroads();
{
    if (currentRoom == "crossroads")
    {
        Console.WriteLine("Förklaring");
        
    }
    else if (currentRoom == "house")
    {
        if (option == "knock")
        {
            currentRoom = "knock";
        }


    }


    else if (currentRoom == "cave")
    {

    }


    else if (currentRoom == "knock")
    {

    }

    else if (currentRoom == "fortästt")
    {

    }

    else if (currentRoom == "Kill")
    {

    }



}


static string Crossroads()
{
    Console.WriteLine("Då är blöt och har gått i timmar du kommer fram till en vägkorsning. Du kan antingn gå höger eller vänster, vilken väg välger du?");
    string option = Console.ReadLine();
    option = option.ToLower();

    if (option == "vänster")
    {
        return "house";
    }

    else if (option == "höger")
    {
        return "cave";
    }
}



Console.WriteLine("Då är blöt och har gått i timmar du kommer fram till en vägkorsning. Du kan antingn gå höger eller vänster, vilken väg välger du?");
string choice = Console.ReadLine();

choice = choice.ToLower();


if (choice == "höger") // Första möjliga vallet med flera val på väg
{
    Console.WriteLine("Efter ha föjlt den högra texten så hittar du en grotta. Medans du utforskar den så hittar du en sovande drake. Försöker du döda den eller springa");
    choice = Console.ReadLine();

    if (choice == "döda" || choice == "kill" || choice == "död")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Du dog... Det är en drake vad trode du? GAME OVER");
        choice = Console.ReadLine();
    }

    if (choice == "Lämna" || choice == "gå" || choice == "gå tillbaka" || choice == "spring" || choice == "springa")
    {
        Console.WriteLine("Bravo nu är du tillbaka vart du start, ska du ta den vänstra vägen?");
        choice = Console.ReadLine();


        if (choice == "vänster")
        {
            Console.WriteLine("Du gick den vänstra vägen och efter ett tag kom fram till ett hus, knackar du på eller fortsätter du");
            choice = Console.ReadLine();

            if (choice == "knacka")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Du knackade på men ingen svara... Detta är för detta är en demo och du kommer inget längre. Slut");
                choice = Console.ReadLine();
            }
            if (choice == "gå" || choice == "fortsätt")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Du fortsatte gå men du hittade inga mer hus för tillverkarna orkade inte lägga in fler. Slut");
                choice = Console.ReadLine();
            }
        }
        if (choice == "höger")
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Varför?? Du har redan gått den här vägen?? Vi trode ingen skulle gå höger igen så det här är allt ni får! SLUT!!");
            choice = Console.ReadLine();    // Undrar hur många försöker få det här slutet
        }
    }

}



if (choice == "vänster")
{
    Console.WriteLine("Du gick den vänstra vägen och efter ett tag kom fram till ett hus, knackar du på eller fortsätter du");
    choice = Console.ReadLine();

    if (choice == "knacka")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Du knackade på men ingen svara... Detta är för detta är en demo och du kommer inget längre. Slut");
        choice = Console.ReadLine(); //Orkade inte fortsätta på det här spelet, kommer förmodligen aldrig bli klar men det säger vi inte till dom
    }
    if (choice == "gå" || choice == "fortsätt")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Du fortsatte gå men du hittade inga mer hus för tillverkarna orkade inte lägga in fler. Slut");
        choice = Console.ReadLine();//Joan du vet att jag läser igenom alla av dina koder, gå tillbaka till arbete annars måste jag säga till bossen
    }

}

Console.ReadLine();


//while