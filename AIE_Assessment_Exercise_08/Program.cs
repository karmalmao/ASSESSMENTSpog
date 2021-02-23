/*
 * Appendix 4 - Exercise 2: Adventure Game
 */

using System;
using System.Numerics;

namespace AIE_Assessment_Exercise_08
{
    class Program
    {
        static void Main(string[] args)
        {

            Room[,] map = new Room[3 , 3];

            Character p = new Player(1,1,1,true);
            Character e = new Enemy(1,1,1,true);
            GameObject pu = new Powerup();
          //  map[].AddGameObject()




            for (int row = 0 ; row < 3 ; row++)
            {
                for (int col = 0 ; col < 3 ; col++)
                {
                    if (map[row,col]==null)
                    {
                        map[row , col] = new Room();
                    }
                  
                }
            }

            //Console.Write("_"); Console.Write("?"); Console.WriteLine("_");
            //Console.Write("_"); Console.Write("X"); Console.WriteLine("_");
            //Console.Write("O"); Console.Write("_"); Console.WriteLine("_");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine(e);






            // Player p = new Player(10,27,6,true);
            // Enemy e = new Enemy(10, 27, 6, true);
            // PowerUp pu = new PowerUp();
            //
            // map[1, 1].AddGameObject(p);
            // map[2, 0].AddGameObject(e);
            // map[0, 1].AddGameObject(pu);
            //
            for (int row = 0 ; row < 3 ; row++)
            {
                for (int col = 0 ; col < 3 ; col++)
                {
                    map[row , col].Draw();
                }
                Console.WriteLine();
            }
            // Console.ReadLine();

        }
    }
    class Room
    {
        public Room()
        {

        }
        public void AddGameObject(GameObject a)
        {
          
        }
        public virtual void Draw()
        {

        }
        public void RemoveGameObject()
        {

        }
    }

    class GameObject
    {

    }
    class Powerup : GameObject
    {

    }

    class Character : GameObject
    {
        public int AT = 0;
        public int HP = 0;
        public int DF = 0;
        public bool IsAlive = false;
        public Character(int AT , int HP , int DF , bool IsAlive)
        {
            this.AT = AT;
            this.HP = HP;
            this.DF = DF;
            this.IsAlive = IsAlive;
        }

    }
    class Player : Character
    {
        public Player(int AT , int HP , int DF , bool IsAlive) : base(AT , HP , DF , IsAlive)
        {
            this.AT = AT;
            this.HP = HP;
            this.DF = DF;
            this.IsAlive = IsAlive;

        }
        public virtual void Draw()
        {
            Console.Write("X");
        }
    }
    class Enemy : Character
    {
        public Enemy(int AT , int HP , int DF , bool IsAlive) : base(AT , HP , DF , IsAlive)
        {
            this.AT = AT;
            this.HP = HP;
            this.DF = DF;
            this.IsAlive = IsAlive;
        }
    }
}
    

