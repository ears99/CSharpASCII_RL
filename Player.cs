//NOTE: IMPLEMENT POTENTIAL HEALTH VALUE BEING PRINTED ON SCREEN?
//DEFENSE VALUE? ETC. 

//TODO: FIGURE OUT WHY GETTERS AND SETTERS AREN'T WORKING CORRECTLY
//TODO: FIGURE OUT HOW TO PASS PARAMETERS BY REFERENCE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpASCIIRogueLike {
    class Player {
 
        //PUBLIC: 

        public Player() { }

        public void init(string name, int health, int attack, int defense) {
            _name = name;
            _health = health;
            _attack = attack;
            _defense = defense; 
        }

        //Getters
     public void getPosition(int x, int y) {
            _x = x;
            _y = y;
        }
        
        //Setters 
     public void setPosition(int x, int y) {
            x = _x;
            y = _y;
        }

        public bool inCombat = false;

        public void attack(bool inCombat) {
            int currentX = _x; int currentY = _y;

            //if the player is in the enemy proximity, set inCombat equal to true. 
            if(_isInEnemyProx == true) {
                inCombat = true;
            }
            //if inCombat is equal to true, the instance of monster attacks the player. 
            if(inCombat == true) {
                _monster.attack();
            }
        }

        //PRIVATE:         
        private string _name;
        private int _health;
        private int _attack;
        private int _defense;
 
        private int _x;
        private int _y;
        private bool _isInEnemyProx; //is in the proximity of an enemy 
                                    //(i.e if the enemy or player is next to each other)

        private Monster _monster;
    }
}
