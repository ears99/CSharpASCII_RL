//TODO: IMPLEMENT MONSTER MOVEMENT, RANDOMLY IN ANY DIRECTION (W,S,A,D) IF TILE != WALL.
//IF PLAYER IS ONE TILE AWAY FROM MONSTER, AND MOVES IN THE DIR. OF MONSTER, COMBAT WILL
//HAPPEN.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpASCIIRogueLike {

    //Base Monster class
    class Monster {
        //PUBLIC:
        public Monster() { }
        public virtual void attack() { }
        public void init(string name, char tile, int health, int attack, int defense) {
            _name = name;
            _tile = tile; 
            _health = health;
            _attack = attack;
            _defense = defense; 
        }

        public void getPosition(int x, int y) {
            _x = x;
            _y = y;
        }

        public void setPosition(int x, int y) {
            x = _x;
            y = _y;
        }

        public int currentX, currentY;

        //PROTECTED: 
        protected string _name;
        protected char _tile;

        protected int _health;
        protected int _attack;
        protected int _defense;
        protected int _x;
        protected int _y;
    }

    class Goblin : Monster {
        //PUBLIC: 
        public Goblin() {
            _name = "Goblin";
            _tile = 'g';
            _health = 2;
            _defense = 1;
        }

        //attack handles the goblin's attack, wether or not it scores a critical hit against the player.
        new public void attack() {
            Random RNG = new Random();
            int randAttack = RNG.Next(1, 2);

            //getters and setters

            void getPosition(int x, int y) {
                _x = x;
                _y = y;
            }

            void setPosition(int x, int y) {
                x = _x;
                y = _y;
            }


            switch(randAttack) {
                case 1:
                    Console.Write("{0} attacks for {1} damage!", _name, _attack);
                    break;
                case 2:
                    Console.Write("{0} attacks for {1 * 2} damage!", _name, _attack);
                    break;
            }
        }
        

        //PROTECTED: 
        protected new string _name;
        protected new char _tile;

        protected new int _health;
        protected new int _attack;
        protected new int _defense;

        protected new int _x;
        protected new int _y;

    }
}
