using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Assignment3.Framework
{
    public class GameObject : MonoBehaviour
    {
        readonly GraphicsDeviceManager graphics_;
        readonly ContentManager _content;

        private Transform transform;

        private List<MonoBehaviour> components = new List<MonoBehaviour>();

        public GameObject(Transform _transfrom, GraphicsDeviceManager _graphics) : base(_transfrom, _graphics)
        {

        }
        public T GetComponent<T>() where T : MonoBehaviour
        {
            for (int i = 0; i < components.Count; i++)
            {
                if (components[i] is T behaviour)
                {
                    return behaviour;
                }
            }
            return null;
        }
        public Transform Transform
        {
            get { return transform; }
        }
        public List<MonoBehaviour> Components
        {
            get { return components; }
        }

        public void LoadContent(SpriteBatch _spriteBatch, ContentManager _content)
        {

        }
        public override void Update(GameTime _gameTime)
        {
        }
        public override void Draw(SpriteBatch _spriteBatch)
        {
            //spriteRenderer.Draw(_spriteBatch);
        }

    }
}
