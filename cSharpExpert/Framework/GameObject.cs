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
        //SpriteRenderer renderer;
        //Transform transform;
        public GameObject() 
        {

        }
        public Transform Transform
        {
            get { return Transform; }
        }
        public SpriteRenderer SpriteRenderer
        {
            get { return SpriteRenderer; }
        }
        public virtual void SetTransform()
        {
        }
        public virtual void SetRenderer()
        {
        }
        public virtual void Draw(SpriteBatch _spriteBatch)
        {
            SpriteRenderer.Draw(_spriteBatch);
        }
    }
}
