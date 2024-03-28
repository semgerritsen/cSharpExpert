using Assignment3.Framework;
using ComponentDesignPattern.Assignment4;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Assignment3.scenes
{
    public class TestScene : Scene
    {
        public TestScene(SceneManager _scene) : base(_scene)
        {
        }
        public override void Initialize()
        {
            base.Initialize();
        }

        public override void LoadContent(SpriteBatch _spriteBatch, ContentManager _content)
        {
            base.LoadContent(_spriteBatch, _content);
            _spriteBatch.Begin();
            _spriteBatch.DrawString(SpriteFont, "rotator test scene: Rotatespeed = 1 + 0.25, direction is rechts", new Vector2(10, 10), Color.Black, 0, Vector2.Zero, 1.25f, SpriteEffects.None, 1);
            _spriteBatch.End();
        }

        public override void Update(GameTime _gameTime)
        {
            base.Update(_gameTime);
        }
        public override void Draw(SpriteBatch _spriteBatch)
        {
            base.Draw(_spriteBatch);
        }
        
    }
}
