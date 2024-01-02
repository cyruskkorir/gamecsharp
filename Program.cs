string text = File.ReadAllText("input.txt");
string[] prizes = text.Split(",");
Game game = new();
Console.WriteLine(game.footballClub[0]);
Game.Salutation();
Console.WriteLine("It is estatic to be a Football fan and be part of  a football club ");
Console.WriteLine(" Do you know that the English premier league is the most watched  league across the globe ");
int s = game.Play();
Console.WriteLine($"Your score is {s}/6");
switch(s){
    case 6:Console.WriteLine($"You won {prizes[0]}"); break;
    case 5:Console.WriteLine($"You won {prizes[1]}");break;
    case 4:Console.WriteLine($"You won {prizes[2]}");break;
    default :Console.WriteLine("Try again next time");break;

}
