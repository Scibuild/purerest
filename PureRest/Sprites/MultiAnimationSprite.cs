using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PureRest.Sprites
{
    public class MultiAnimationSprite : AnimationSprite
    {
        Dictionary<String, Tuple<int, int>> Animations;
        
        String CurrentAnimation { get; set; }


        public MultiAnimationSprite(Texture2D texture, Vector2 startingPosition,
            int frames, TimeSpan interval,
            Dictionary<String, Tuple<int, int>> animations, String startingAnimation)
            : base( texture,  startingPosition,  frames,  interval)
        {
            Animations = animations;
            CurrentAnimation = startingAnimation;
        }

        public override bool Update(GameTime gameTime)
        {

            bool progressed;

            if (NextFrame >= FrameInterval)
            {
                CurrentFrameNum++;
                CurrentFrameNum = (CurrentFrameNum > Animations[CurrentAnimation].Item2 || CurrentFrameNum < Animations[CurrentAnimation].Item1) ?
                    Animations[CurrentAnimation].Item1 : CurrentFrameNum;
                SetFrame(CurrentFrameNum);
                progressed = true;
                NextFrame = TimeSpan.Zero;
            }
            else
            {
                NextFrame += gameTime.ElapsedGameTime;
                progressed = false;
            }

            return progressed;
        }
    }
}
