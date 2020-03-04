using System;
using System.Collections.Generic;
using System.Text;
using PokedexWPF;
using System.Linq;

namespace DBQueries
{
    class Program
    {
        public static void Main(string []args)
        {       // quueries for bulbasaur data
            using (var db = new POKEDEXPOKEMONContext())
            {
                //q1 string (bulbasaur)
                var Answer1q = 
                    from a1 in db.Pokemon
                    select a1;
                
                foreach (var a1 in Answer1q) 
                {
                    Console.WriteLine(a1);
                }

                //image string (bulbasaur)
                var Image1q =
                    from i1 in db.Pokemon
                    select i1.PokemonImage1;

                foreach (var i1 in Image1q)
                {
                    Console.WriteLine(i1);
                }

                //blacked out image string(bulbasaur blacked)
                var Image21q =
                    from i2 in db.Pokemon
                    select i2.PokemonImage2;
                foreach(var i2 in Image21q)
                {
                    Console.WriteLine(i2);
                }


            }
        }
    }
}
