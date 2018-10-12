//MAIN GAME ENGINE FOR ASCII R.L.
//HANDLES MENU, RUNNING THE GAME, & LOADING THE LEVEL FROM A FILE STREAM.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpASCIIRogueLike {
    class GameSystem {
        
//public: 

        //constructor sets up the game. 
        public GameSystem() {
    
        }

        public bool isRunning = false; 
        //Play function allows the level to be printed, the character to move around and attack monsters, etc. 
        public void menu() {
            char choice;
            Console.WriteLine("** MAIN MENU ** ");
            Console.WriteLine("P: PLAY");
            Console.WriteLine("Q: QUIT TO CONSOLE");
            Console.Write("> ");
            choice = Convert.ToChar(Console.ReadLine());
            switch(choice) {
                case 'P':
                case 'p':
                    isRunning = true;
                    play();
                    break;
                case 'Q':
                case 'q':
                    break;
                default:
                    Console.Clear();
                    menu();
                    break;
            }
        }

        public void play() {
            isRunning = true;
            Console.Clear();
            _level.loadFile();
            while(isRunning) {
                _level.processPlayerMove(_player);
            }
            
       
        }

        
//private: 

        ~GameSystem() { }
        private Level _level = new Level(); 
        private Player _player = new Player();
    }
}



