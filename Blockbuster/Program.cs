using System;
using System.Collections.Generic;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {

            BlockBusterVideo bv = new BlockBusterVideo();
            bv.PrintAllMovies();
            bv.Checkout();


            List<string> scenes = new List<string>();
            scenes.Add("test1");

            DVD d = new DVD();
            VHS v = new VHS();
            Movie m1 = new Movie("test", Genre.Action, 90, scenes, d);
            Movie m2 = new Movie("test2", Genre.Romance, 120, scenes, v);

            //d1.Play1();
            m1.Play();
            m2.Play();

        }
    }
}
