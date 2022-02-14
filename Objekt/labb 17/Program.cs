using System.Collections.Generic;
using System;
using System.Numerics;

namespace labb_17
{
    public class GameObject
    {
        public bool IsDead;
        public Vector2 Position { get; set; }
        public float Radius { get; set; }
        public Vector2 Speed { get; set; }
        public float Rotation { get; set; }

        public bool CollidesWith(IGameObject other)
        {
            return true;
        }
    }
    public class Meteor : GameObject
    {
        public Type MeteorType { get; set; }
        public float ExplosionScale { get; set; }
        public void Meter(Type MeteorType)
        {

        }
        public void Update(gameTime GameTime)
        {

        }
        public IEnumerable<Meteor> BreakMeteor(Meteor meteor, string a)
        {
            return null;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
        }

    }
}


