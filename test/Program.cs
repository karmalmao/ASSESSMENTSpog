using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialise
            Room[,] worldMap = new Room[3, 3]; //x, y
            Enemy e = new Enemy();
            Player p = new Player();
            PowerUp pu = new PowerUp();

            //Populate the map
            for (int xWorldCoord = 0; xWorldCoord < 3; xWorldCoord++)
            {
                for(int yWorldCoord = 0; yWorldCoord < 3; yWorldCoord++)
                {
                    Room currRoom = new Room() { };
                    

                    if (yWorldCoord == 0) // First y coord
                        currRoom.AddGameObject(e);
                    else if (yWorldCoord == 2) // Last y coord
                        currRoom.AddGameObject(p);
                    else
                        currRoom.AddGameObject(pu);

                    worldMap[xWorldCoord, yWorldCoord] = currRoom;
                }
            }

            foreach(var room in worldMap)
            {
                foreach (var gObject in room.Objects)
                {
                    if(gObject == e || gObject == pu || gObject == p)
                    {
                        Console.Write("_");
                        gObject.Draw();
                        Console.Write("_");

                    }
                }
            }

            Console.Read();
        }

        public class Room
        {
            public GameObject[] Objects = new GameObject[3];

            public void AddGameObject(GameObject gObj)
            {
                for(int currObj = 0; currObj < 3; currObj++)
                {
                    if (Objects[currObj] == null)
                    {
                        Objects[currObj] = gObj;
                        break;
                    }
                }
            }

            public void RemoveGameObject(GameObject gObj)
            {

            }
        }

        public class GameObject
        {
            public int AT = 0;
            public int HP = 0;
            public int DF = 0;
            public bool IsAlive = false;

            public virtual void Draw()
            {
                //Default drawing
            }
        }

        public class Player : GameObject
        {
            public override void Draw()
            {
                Console.Write("X");

                base.Draw();
            }
        }

        public class Enemy : GameObject
        {
            public override void Draw()
            {
                if (base.HP > 10)
                    Console.Write("O");
                else
                    Console.Write("o");

                base.Draw();
            }
        }

        public class PowerUp : GameObject
        {
            public override void Draw()
            {
                Console.Write("?");

                base.Draw();
            }
        }
    }
}
