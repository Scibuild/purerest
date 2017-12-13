using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PureRest.Sprites
{
    public class AnimationSprite : Sprite, IInteractive
    {

        protected int Frames, FrameWidth, CurrentFrameNum;
        protected Rectangle CurrentFrame;
        protected TimeSpan NextFrame, FrameInterval;

        public AnimationSprite(Texture2D texture, Vector2 startingPosition, int frames, TimeSpan interval) : base(texture, startingPosition)
        {
            Frames = frames; 
            FrameWidth = Width / Frames;
            CurrentFrameNum = 0;
            FrameInterval = interval;
        }

        public void SetFrame(int frame)
        {
            if(frame >= Frames)
            {
                throw new  System.ArgumentException("Frame is greater than the number of frames.", "frame");
            }
            CurrentFrame = new Rectangle(FrameWidth * frame, 0, FrameWidth, Height);
        }

        
        public new void Draw(SpriteBatch spriteBatch)
        {
            if (Active)
            {
                spriteBatch.Draw(SpriteTexture, Position, CurrentFrame, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
            }
        }

        public virtual bool Update(GameTime gameTime)
        {

            bool progressed;

            if(NextFrame>=FrameInterval)
            {
                CurrentFrameNum++;
                CurrentFrameNum %= Frames;
                SetFrame(CurrentFrameNum);
                progressed = true;
                NextFrame = TimeSpan.Zero;
            } else {
                NextFrame += gameTime.ElapsedGameTime;
                progressed = false;
            }

            return progressed;
        }
    }
}
