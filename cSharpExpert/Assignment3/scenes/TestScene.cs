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
