using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PureRest
{
    public class Player
    {
        //-- Feilds --//

        public Texture2D PlayerTexture;
        public Vector2 Position;
        public bool Active;

        public int Width { get { return PlayerTexture.Width; } }
        public int Height { get { return PlayerTexture.Height;  } }

        //-- Methods --//
        public void Initialise(Texture2D texture, Vector2 startingPosition)
        {
            PlayerTexture = texture;
            Position = startingPosition;
            Active = true;
        }
        public void Update()
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}
