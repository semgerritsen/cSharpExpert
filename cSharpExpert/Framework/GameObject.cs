using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpExpert.Framework
{
    public class GameObject
    {
        readonly GraphicsDeviceManager graphics;

        SpriteRenderer spriteRenderer;
        Transform transform;
        public GameObject(SpriteRenderer _renderer, Transform _transfrom, GraphicsDeviceManager _graphics) 
        {
            spriteRenderer = _renderer;
            transform = _transfrom;
            graphics = _graphics;
        }
        public Transform Transform
        {
            get { return transform; }
            set { transform = value; }
        }
        public SpriteRenderer SpriteRenderer
        {
            get { return spriteRenderer; }
            set { spriteRenderer = value; }
        }
        public void LoadContent(SpriteBatch _spriteBatch, ContentManager _content)
        {
        }
        public virtual void SetTransform()
        {
            Transform.Position = new Vector2(100, 100);
            Transform.Scale = 1;
            Transform.CalculateDegrees(0);
            //Transform.Origin = new Vector2(SpriteRenderer.Texture.Width / 2, SpriteRenderer.Texture.Height / 2);
        }
        public virtual void SetRenderer()
        {
            SpriteRenderer.Color = Color.White;
            SpriteRenderer.LayerDepth = 1;
            SpriteRenderer.SpriteEffects = SpriteEffects.None;

        }

        public virtual void Update(GameTime _gameTime)
        {

        }
        public virtual void Draw(SpriteBatch _spriteBatch)
        {
            SetTransform();
            SetRenderer();
            SpriteRenderer.Draw(_spriteBatch);
        }
    }
}
