using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ShooterGame
{
    public class GameManager
    {
      
        Texture2D playerTexture;

        public void LoadContent(ContentManager Content)
        {

              playerTexture = Content.Load<Texture2D>("ball");
            
        }

        public void Update(GameTime gameTime)
        {
            
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            float offsetBallWidth = playerTexture.Bounds.Width/2f;
            float offsetBallHeight = playerTexture.Bounds.Height/2f;

            // TODO: Add your drawing code here
           
            spriteBatch.Draw(
                playerTexture,
                new Vector2(
                    Mouse.GetState().X - offsetBallWidth,
                    Mouse.GetState().Y - offsetBallHeight),
                Color.White);
            
        }
    }
}