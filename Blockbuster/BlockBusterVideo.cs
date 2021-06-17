using System;
using System.Collections.Generic;
using System.Text;


namespace Blockbuster
{
    class BlockBusterVideo
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();


        public BlockBusterVideo()
        {

            List<string> shrekScenes = new List<string>() { "What are you doing in my swamp", "Shrek meets Donkey", "Castle scene", "Dragon fight scene" };
            DVD d = new DVD();

            Movie m1 = new Movie("Shrek", Genre.Drama, 120, shrekScenes, d);

            List<string> dieHardScenes = new List<string>() { "First day at school", "You must wear pink on Wednesdays", "Riot scene", "Who's afraid of Regina?" };
            VHS v = new VHS();
            Movie m2 = new Movie("Die Hard", Genre.Action, 133, dieHardScenes, v);

            Movies.Add(m1);
            Movies.Add(m2);


        }

        public Movie GetMovie(int index)
        {
            Movie m = Movies[index];
            return m;
        }


        public void PrintAllMovies()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                string title = m.Title;
                Console.WriteLine($"{i}: {title}");
            }
        }

        public void Checkout()
        {
            Console.WriteLine($"What movie would you like to watch? 0 to {Movies.Count -1}");
            string input = Console.ReadLine();
            int index = int.Parse(input);

            Movie m = GetMovie(index);

            m.PlayWholeMovie();
        }
    }
}
