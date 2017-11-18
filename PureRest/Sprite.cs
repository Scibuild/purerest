using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PureRest
{
    public class Sprite
    {
        //-- Feilds --//

        public Texture2D SpriteTexture;
        public Vector2 Position;
        public bool Active;

        public int Width { get { return SpriteTexture.Width; } }
        public int Height { get { return SpriteTexture.Height; } }

        //-- Methods --//
        public void Initialise(Texture2D texture, Vector2 startingPosition)
        {
            SpriteTexture = texture;
            Position = startingPosition;
            Active = true;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (Active)
            {
                spriteBatch.Draw(SpriteTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
            }
        }
    }
}
