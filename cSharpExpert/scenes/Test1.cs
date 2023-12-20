using cSharpExpert.Framework;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpExpert.scenes
{
    public class Test1 : Scene
    {
        readonly GraphicsDeviceManager graphics;

        SpriteRenderer renderer;
        Transform transform;
        private GameObject gameObject;
        public Test1()
        {

        }

        public override void Initialize()
        {
            base.Initialize();
            renderer = new SpriteRenderer(graphics, transform);
            transform = new Transform();


            gameObject = new GameObject(renderer, transform, graphics);

            stars.Add(gameObject);
        }

        public override void LoadContent(SpriteBatch _spriteBatch, ContentManager _content)
        {
            base.LoadContent(_spriteBatch,_content);
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
