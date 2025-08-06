using System.Globalization;
using Game_Gender.Entities;
using GameGender.Entities.Enums;

namespace Game_Gender
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor Cadastre 3 jogos com nome, Genero e Preço: ");
            Console.WriteLine();

            List<Game> NewGame = new List<Game>();
            
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite o nome do jogo: ");
                string? namegame = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite o Genero do jogo: \n Action \n Adventure \n Rpg \n Sports");
                Console.WriteLine();
                string? genderGame = Console.ReadLine();

                GenderGame gendergame = Enum.Parse<GenderGame>(genderGame);
                
                Console.Write("Agora digite o Preço do Jogo: R$");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Console.WriteLine($"SUCESSO! Jogo {i+1} Cadastrado!");

                Game game = new Game(namegame, gendergame, price, DateTime.Now);
                
                NewGame.Add(game);
                Console.WriteLine();
            }

            Console.WriteLine("Qual genêro deseja buscar? ");
            string? filtergender = Console.ReadLine();
            
            GenderGame gendersearch = Enum.Parse<GenderGame>(filtergender); //Fazendo o cast da string filtergender para o tipo GenderGame Enum

            bool gamefound = NewGame.Any(x => x.GenderGame == gendersearch);

            if (gamefound) //Se o gênero existe vai procurar na lista
            {
                foreach (Game obj in NewGame)
                {
                    if (obj.GenderGame == gendersearch)
                    {
                        Console.WriteLine(obj);
                    }
                }
            }
            else
            {
                Console.WriteLine("Gênero não encontrado!");
            }


            Console.WriteLine();

            Console.WriteLine("Deseja excluir um jogo pelo nome? S/N");
            char choosedelete = char.Parse(Console.ReadLine());

            if (choosedelete == 'S' || choosedelete == 's')
            {
                while (true)
                {
                    Console.Write("Qual jogo você deseja excluir? ");
                    string? gamedelete = Console.ReadLine();
                    
                    Game? gameDelete = NewGame.LastOrDefault(g => g.NameGame == gamedelete);

                    Console.WriteLine();
                    if (gameDelete == null)
                    {
                        Console.WriteLine("Jogo Não Encontrado! Tente Novamente");
                        continue;
                    }
                    else
                    {
                        NewGame.Remove(gameDelete);
                        Console.WriteLine("Jogo deletado com sucesso!");
                        
                        break;
                    }
                }
                foreach (Game obj in NewGame)
                {
                    Console.WriteLine(obj);
                }
            }
            else if (choosedelete == 'N' || choosedelete == 'n')
            {
                foreach (Game obj in NewGame)
                {
                    Console.WriteLine(obj);
                }
            }
        }
    }
}