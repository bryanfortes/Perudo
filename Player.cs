using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Perudo
{
    public class Player
    {
        private bool _yourTurn = false;

        //member functions to assign values to player private data. Turn is set to false by default as Game and Round classes will assign player turns.
        public string Name { get; set; }
        public int DiceHeld { get; set; }
        public bool YourTurn { set { _yourTurn = value; } }
        public enum Actions
        {
            continueBet,
            call,
            Raise,
            calza
        }
        public int Action { get; set; }


        //honestly this member function might have to be in the game class but im leaving it here for now
        public void MakeAction(int choice, bool turn)
        {
            
            switch (choice)
            {
                case 0: //continueBet: raise the quantity of current bet by only 1, no change to quality i.e. die number
                    { 
                        if (!turn)                         
                            Console.Error.WriteLine("You can only bet on your turn!");
                        else
                        {
                            //continueBet implementation here
                        }
                    }
                    break;
                case 1: //call: bet stops. game ONLY reveals relevant die for the count. resolve outcome
                    {
                        if (!turn)
                            Console.Error.WriteLine("You can only call on your turn!");
                        else
                        {
                            //call implementation here
                        }
                    }
                    break;
                case 2: //raise rules found here: https://en.wikipedia.org/wiki/Dudo
                    {
                        if (!turn)
                            Console.Error.WriteLine("You can only call on your turn!");
                        else
                        {
                            /*raise implementation here
                            //if die quality is 6 the player can only raise quantity. after that the OPTION to change quality to any number>1 && number<=6 should be presented
                            //player doesnt have to change quality after quantity has been raised.


                            //if quality>1  && quality<6 player can decide to either raise quantity or quality
                              if quantity is raised, then quality can be changed to any number between 2 and 6 inclusively
                              if quality is raised, break

                            //                                                                                              */
                        }
                    }
                    break;

            }
        }

    }
}
