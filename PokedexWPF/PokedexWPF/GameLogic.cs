using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PokedexWPF
{
    public class GameLogic
    {
        //fields withing game logic 
        private string _actualAnswer;
        private string _answer;
        private Pokemon _currentPokemon;
        private List<Pokemon> Answers;

        // list query
        public GameLogic()
        {
            using (var db = new POKEDEXPOKEMONContext())
            {
                Answers =
                    (from p in db.Pokemon
                     select p).ToList();
            }
        }


        public string TheirAnswer
        {
            get { return _answer; }
            
            set
            
            {if (value.Length > 0)
                    _answer = value;
            }
        }

        public string CorrectAnswer()
        {
            _actualAnswer = Answers[0].ToString();
            return _actualAnswer;
        }

        public bool AnswerComparison()
        {
            if (TheirAnswer == CorrectAnswer())
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }



            
            //using (var db = new POKEDEXPOKEMONContext())
            //{
            //    //q1 string (Bulbasaur)
            //    var Answer1q =
            //        from a1 in db.Pokemon
            //        select a1;
            //    foreach (var a1 in Answer1q)
            //    {

            //        if (TheirAnswer == a1.ToString())
            //        {
            //            return "Correct";
            //        }
            //        else
            //        {
            //            return "Wrong";

            //        }
            //    }
            //}
            //return "nope";
        
    }
}

