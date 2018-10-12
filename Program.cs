using System;
using System.IO;

namespace CSharpASCIIRogueLike {
    class Program {
        static void Main(string[] args) {
            GameSystem game = new GameSystem();
            game.menu();

            Console.ReadLine(); 
        }
    }
}
