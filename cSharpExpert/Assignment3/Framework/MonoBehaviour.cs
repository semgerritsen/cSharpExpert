using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Assignment3.Framework
{
    public class MonoBehaviour
    {
        private Transform transform;
        protected GameObject gameObject;

        public MonoBehaviour(Transform _transfrom, GraphicsDeviceManager _graphics)
        {
            transform = _transfrom;
        }
        

        public void Awake()
        {

        }
        public void Start()
        {

        }

        public virtual void LoadContent(ContentManager _content)
        {
            
        }

        public virtual void Update(GameTime _gameTime)
        {
            
        }
        public virtual void Draw(SpriteBatch _spriteBatch)
        {
            
        }
    }
}
