using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace monogamee
{
    public class Player : DrawableGameComponent, IgameObject
    {
        public bool IsDead { get; set; }
        public Vector2 Position { get; set; }
        public float Radius { get; set; }
        public Vector2 Speed { get; set; }
        public float Rotation { get; set; }
        private Texture2D playertexture;
        public Player(Game game) : base(game)
        {
            Position = new Vector2(Globals.ScreenWidth / 2, Globals.ScreenHeight / 2);
        }
        protected override void LoadContent()
        {
            playertexture = Game.Content.Load<Texture2D>("player");
            base.LoadContent();
        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(playertexture, Position, Color.White);
        }
    }
}