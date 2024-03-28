using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Assignment2.Framework
{
    public class GameObject
    {
        readonly GraphicsDeviceManager graphics_;
        readonly ContentManager _content;

        private SpriteRenderer spriteRenderer;
        private Transform transform;


        public GameObject(SpriteRenderer _renderer, Transform _transfrom, GraphicsDeviceManager _graphics)
        {
            spriteRenderer = _renderer;
            transform = _transfrom;
            graphics_ = _graphics;
        }

        public Transform Transform
        {
            get { return transform; }
        }
        public SpriteRenderer Spriterenderer
        {
            get { return spriteRenderer; }
        }
        public void LoadContent(SpriteBatch _spriteBatch, ContentManager _content)
        {

        }
        public virtual void Update(GameTime _gameTime)
        {
        }
        public virtual void Draw(SpriteBatch _spriteBatch)
        {
            spriteRenderer.Draw(_spriteBatch);
        }

    }
}
