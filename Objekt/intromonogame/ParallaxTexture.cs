using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace intromonogame
{
    class ParallaxTexture
    {
        private Texture2D _texture;
        private int _positionY;

        public float OffsetX { get; set; }

        public ParallaxTexture(Texture2D Texture, int PositionY)
        {
            _positionY = PositionY;
            _texture = Texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            int width = spriteBatch.GraphicsDevice.Adapter.CurrentDisplayMode.Width;
            int textureStartX = (int)(OffsetX % _texture.Width);
            int textureWidth = _texture.Width - textureStartX;
            int startX = 0;

            while (startX < width)
            {
                spriteBatch.Draw(_texture, new Vector2(startX, _positionY),
                    new Rectangle(textureStartX, 0, textureWidth, _texture.Height), Color.White);
                startX += textureWidth;
                textureStartX = 0;
                textureWidth = _texture.Width;
            }
        }

    }
}

