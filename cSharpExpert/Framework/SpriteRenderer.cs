using System;
using System.Reflection;
using System.Security.Cryptography;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace cSharpExpert.Framework
{
    public class SpriteRenderer
    {
        readonly GraphicsDeviceManager graphics;

        private Texture2D texture;
        private Color color = Color.White;
        private float layerDepth = 1;
        private SpriteEffects spriteEffects;

        readonly Transform transform;

        public SpriteRenderer(GraphicsDeviceManager _graphics,Transform _transform)
        {
            graphics = _graphics;
            transform = _transform;
        }
        
        public Texture2D Texture 
        {
            get { return texture; }
            set { texture = value; }
        }
        public Transform Transform
        {
            get { return transform; }
        }
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        public float LayerDepth
        {
            get { return layerDepth; }
            set { layerDepth = value; }
        }
        public SpriteEffects SpriteEffects
        {
            get { return spriteEffects; }
            set { spriteEffects = value; }
        }
        public void LoadContent(ContentManager _content)
        {
            texture = _content.Load<Texture2D>("StarIndicators");
        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(texture, Transform.Position, null, color, Transform.Rotation, Transform.Origin, Transform.Scale, spriteEffects, layerDepth);
        }
    }
}
