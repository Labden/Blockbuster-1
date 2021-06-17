using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
   public class Movie
    {

        public string Title { get; set; }
        public Genre Category { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }
        public IPlay MoviePlay { get; set;}

        public Movie(string Title, Genre Category, int Runtime, List<string> Scenes, IPlay MoviePlay)
        {
            this.Title = Title;
            this.Category = Category;
            this.Runtime = Runtime;
            this.Scenes = Scenes;
            this.MoviePlay = MoviePlay;
        }
        
        public void PrintInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Category: "+ Category);
            Console.WriteLine("Run Time: "+ Runtime);
        }

        public void PrintScenes()
        {
            Console.WriteLine("Scenes: ");
            foreach(string scene in Scenes)
            {
                Console.WriteLine(scene);
            }
        }

        //Virtual == the child has the option to override the method
        //Abstract == the child MUST override this method
        public void Play()
        {
            MoviePlay.Play(Scenes);
        }

        public virtual void PlayWholeMovie()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                string scene = Scenes[i];
                Console.WriteLine($"{i}:{scene}");
            }
        }
    }
}
