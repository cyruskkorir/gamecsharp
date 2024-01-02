class Game
{
    public string[] colour = ["white", "blue", "red", "yellow", "green", "sky blue"];
    public string[] footballClub = ["Tottenham spurs", "Chelsea", "Man United", "Arsenal", "Liverpool", "Man City"];


    public static void Salutation()
    {
        Console.Write(" Hello,How are doing?");
        Console.ReadLine();
        Console.WriteLine("Fantastic news to know, welcome to knowledge Game");
        Console.WriteLine("Today I want to introduce you to sport you may like and be fan of it");
        Console.WriteLine("Press'Enter' to know  of it");
        Console.ReadKey();
        Console.WriteLine("Football is the sport, I have the story to tell you ");
        Console.WriteLine("In football we have football clubs and teams");
        Console.WriteLine("Lets talk about football club");
        Console.ReadKey();
    }
    public int Play(){
        int score = 0;
        Console.WriteLine("1: white 2: blue  3: red 4: yellow 5: green 6: sky blue");
        Console.WriteLine("Choose a colour number between 1 to 6: ");
        Random random = new();
        for (int i = 0; i < 6; i++)
            {
                try{
                    int r = random.Next(0,5);
                    string club = footballClub[r];
                    Console.WriteLine($"What is the color of {club}");
                    int answer = Convert.ToInt16(Console.ReadLine());
                    if(r+1==answer){
                        score++;
                    }
                }catch(Exception){
                    Console.WriteLine("Please enter a valid input");
                }
               

            }
            return score;
    }
}