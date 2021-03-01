/*
 * Appendix 4 - Exercise 2: Adventure Game
 */

using System;
using System.Numerics;
using System.Collections;

namespace AdventureGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Room[,] map = new Room[3 , 3];

            for (int row = 0 ; row < 3 ; row++)
            {
                for (int col = 0 ; col < 3 ; col++)
                {
                    map[row , col] = new Room();
                }
            }
            Player p = new Player();
            Enemy e = new Enemy();
            PowerUp pu = new PowerUp();

          

            map[1 , 1].AddGameObject(p);
            map[2 , 0].AddGameObject(e);
            map[0 , 1].AddGameObject(pu);

            for (int row = 0 ; row < 3 ; row++)
            {
                for (int col = 0 ; col < 3 ; col++)
                {
                    
                    map[row , col].Draw();
                    if (map[row , col] == map[0 , 2] || map[row , col] == map[1 , 2] || map[row , col] == map[2 , 2]) Console.WriteLine();
                }   
            }
            Console.WriteLine();


            map[0 , 1].RemoveGameObject(pu);

            for (int row = 0 ; row < 3 ; row++)
            {
                for (int col = 0 ; col < 3 ; col++)
                {

                    map[row , col].Draw();
                    if (map[row , col] == map[0 , 2] || map[row , col] == map[1 , 2] || map[row , col] == map[2 , 2]) Console.WriteLine();
                }
            }




        }
    }
    }
    public abstract class GameObject
    {
        public virtual void Draw()
        {

        }
    }

    public class Room
    {
        GameObject[] objects = new GameObject[3];
        
        public void AddGameObject(GameObject a)
        {
            for (int i = 0 ; i < objects.Length ; i++)
            {
                if (objects[i] == null) 
                {
                    objects[i] = a;
                    break;
                }

            }
        }
        public void RemoveGameObject(GameObject a)
        {
            for (int i = 0 ; i < objects.Length ; i++)
            {
                if (objects[i] == a)
                {
                    objects[i] = null;
                    Array.Sort(objects);
                    break;
                    
                }
            }
        }
        public void Draw()
        {
            for (int i = 0 ; i < objects.Length ; i++)
            {
                if (objects[i] == null)
                {
                    Console.Write("_");
                    break;

                }
                if (objects[i] != null)
                {
                    objects[i].Draw();
                    break;

                }
            }
        }
    }
    public class Character : GameObject
    {
        public override void Draw()
        {

        }
    }
    public class Player : Character
    {
        public Player()
        {

        }
        public override void Draw()
        {
            Console.Write("X");
        }
    }
    public class Enemy : Character
    {
    int hp = 10;
    public Enemy()
        {
        
        }
        public override void Draw()
        {
        if (hp >= 10)
        {
            Console.Write("O");
        }
        else
        {
            Console.Write("o");
        }
            
        }
    }
    public class PowerUp : GameObject
    {
        public override void Draw()
        {
            Console.Write("?");
        }
    }

    

