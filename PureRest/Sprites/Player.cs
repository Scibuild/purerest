using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace PureRest.Sprites
{
    public class Player : MultiAnimationSprite
    {

        public Player(Texture2D texture, Vector2 startingPosition,
            int frames, TimeSpan interval,
            Dictionary<String, Tuple<int, int>> animations, String startingAnimation) :

            base( texture,  startingPosition,  frames,  interval, animations, startingAnimation)
        { }

        public override bool Update(GameTime gameTime)
        {
            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.A))
                Position.X -= 1;

            if (state.IsKeyDown(Keys.W))
                Position.Y -= 1;

            if (state.IsKeyDown(Keys.D))
                Position.X += 1;

            if (state.IsKeyDown(Keys.S))
                Position.Y += 1;


            return base.Update(gameTime);
        }

    }
}
