//TODO: IMPLEMENT MOVEMENT, MOVEMENT NOT WORKING 
//STANDARD W,S,A,D MOVEMENT SYSTEM, WILL UPDATE PLAYER ('@') TO ONE SPACE IN THE DIRECTION
//GIVEN.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CSharpASCIIRogueLike {
    class Level {
        //PUBLIC: 
        public Level() { }

        //getters
        public void getTile(int x, int y, char tile) {

        }

        //setters
        public void setTile(int x, int y, char tile) {

        }

        public void processPlayerMove(Player player) {
            int targetX = 0;
            int targetY = 0;
            int playerXLeft = targetX - 1;
            int playerXRight = targetX + 1;
            int playerYUp = targetY - 1;
            int playerYDown = targetY + 1;

            int playerX = targetX;
            int playerY = targetY;

            player.getPosition(targetX, targetY);
            char input = Convert.ToChar(Console.ReadLine());

            switch(input) {
                case 'W':
                case 'w':
                    player.setPosition(playerX, playerYUp);
                    break;
                case 'S':
                case 's':
                    player.setPosition(playerX, playerYDown);
                    break;
                case 'A':
                case 'a':
                    player.setPosition(playerXLeft, playerY);
                    break;
                case 'D':
                case 'd':
                    player.setPosition(playerXRight, playerY);
                    break;
            }
        }




        //NOTE: IN C++, LEVEL IS LOADED USING IFSTREAM, PASSING LINES OF A FILE 
        //THROUGH std::vector<string> _levelData. 
        public void loadFile() {
            //if the file does not exist, tell the user. else, load and print the file. 
            if(!File.Exists(FILE_PATH)) {
                Console.Write("ERROR: {0} DOES NOT EXIST!", FILE_PATH);
                return;
            }
            FileStream ifstream = new FileStream(FILE_PATH, FileMode.Open,
                FileAccess.ReadWrite,
                FileShare.Read);

            //Print the data from the file to the console. 
            using(StreamReader reader = new StreamReader(ifstream)) {
                string input;
                //while not at the end of the file, print lines from the file to the terminal.
                while(reader.Peek() > -1) {
                    input = reader.ReadLine();
                    Console.WriteLine(input);
                }
            }
        }
        //PRIVATE:
        private const string FILE_PATH = "C:\\Users\\jacobseadorf\\Desktop\\LevelOne.txt";
    }
}
