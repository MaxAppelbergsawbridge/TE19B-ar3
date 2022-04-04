using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace intromonogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D normalTexture;
        private Texture2D jumpingTexture;
        private Texture2D crouchTexture;
        private Texture2D fireballTexture;
        private List<Vector2> fireballs;
        private int fireballtimer = 120;
        private Random rnd;
        private Vector2 position;
        private Vector2 speed;
        private bool isJumping;
        private bool iscrouching;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            position = new Vector2(300, 200);
            fireballs = new List<Vector2>();
            rnd = new Random();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            normalTexture = Content.Load<Texture2D>("normal");
            jumpingTexture = Content.Load<Texture2D>("jump");
            fireballTexture = Content.Load<Texture2D>("fireball");
            crouchTexture = Content.Load<Texture2D>("crouch");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            position += speed;
            if (position.Y > 200)
            {
                position = new Vector2(position.X, 200);
                speed = Vector2.Zero;
                isJumping = false;
            }
            speed += new Vector2(0, 0.1f);
            var state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.W) && !isJumping)
            {
                speed = new Vector2(0, -2.0f);
                isJumping = true;
            }
            if (state.IsKeyDown(Keys.S) && !isJumping)
            {
                iscrouching = true;
            }
            else
            {
                iscrouching = false;
            }

            fireballtimer--;
            if (fireballtimer <= 0)
            {
                fireballtimer = 120;


                if (rnd.Next(2) == 0)
                {
                    fireballs.Add(new Vector2(800, 200));
                }
                else
                {
                    fireballs.Add(new Vector2(800, 240));

                }

            }
            for (var i = 0; i < fireballs.Count; i++)
            {
                fireballs[i] = fireballs[i] + new Vector2(-2, 0);
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            if (isJumping)
            {
                _spriteBatch.Draw(jumpingTexture, position, Color.White);
            }
            else
            if (iscrouching)
            {
                _spriteBatch.Draw(crouchTexture, position, Color.White);
            }
            else
            {
                _spriteBatch.Draw(normalTexture, position, Color.White);
            }
            foreach (var fireball in fireballs)
            {
                _spriteBatch.Draw(fireballTexture, fireball, Color.White);
            }
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
