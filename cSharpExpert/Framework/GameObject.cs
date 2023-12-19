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
        SpriteRenderer renderer;
        Transform transform;
        public GameObject(SpriteRenderer _renderer, Transform _transfrom) 
        {
            renderer = _renderer;
            transform = _transfrom;
        }
        public Transform Transform
        {
            get { return transform; }
        }
        public SpriteRenderer SpriteRenderer
        {
            get { return renderer; }
        }
        public void LoadContent(ContentManager _content)
        {
            //renderer.LoadContent(_content);
        }
        public virtual void SetTransform()
        {
            Transform.Position = new Vector2(100 , 200);
            Transform.Scale = 1;
            Transform.Rotation = 0;
            Transform.Origin = new Vector2(SpriteRenderer.Texture.Width / 2, SpriteRenderer.Texture.Height / 2);
        }
        public virtual void SetRenderer()
        {
            SpriteRenderer.Color = Color.White;
            SpriteRenderer.LayerDepth = 1;
            SpriteRenderer.SpriteEffects = SpriteEffects.None;

        }
        public virtual void Draw(SpriteBatch _spriteBatch)
        {
            SetTransform();
            SetRenderer();
            SpriteRenderer.Draw(_spriteBatch);
        }
    }
}
