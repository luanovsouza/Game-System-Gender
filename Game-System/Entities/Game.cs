using GameGender.Entities.Enums;

namespace Game_Gender.Entities;

public class Game
{
    public string? NameGame { get; set; }
    public GenderGame GenderGame { get; set; }
    public double Price { get; set; }

    public DateTime RegisteredGameMomente { get; set; }

    
    public Game(string? nameGame, GenderGame genderGame, double price, DateTime registeredgamemoment)
    {
        NameGame = nameGame;
        GenderGame = genderGame;
        Price = price;
        RegisteredGameMomente = registeredgamemoment;
    }

    public override string ToString()
    {
        return $"Nome: {NameGame}, Price: R$ {Price}, Gender: {GenderGame}";
    }
}