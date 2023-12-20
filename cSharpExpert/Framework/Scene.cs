using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace cSharpExpert.Framework
{
    public class Scene
    {
        private GraphicsDeviceManager graphics;
        //private ContentManager Content;

        public List<GameObject> stars = new List<GameObject>();
        public Scene() 
        {

        }
        //public List<GameObject> Stars
        //{
        //    get { return stars; }
        //    set { stars = value; }
        //}


        public virtual void Enter()
        {
            // excecutes on scene enter
        }

        public virtual void Exit()
        {
            // excecutes on scene exit
        }
        public virtual void Initialize()
        {

        }

        public virtual void LoadContent(SpriteBatch _spriteBatch, ContentManager _content)
        {
            for (int i = 0; i < stars.Count; i++)
            {
                stars[i].LoadContent(_spriteBatch,_content);

            }
        }
        public virtual void Update(GameTime _gameTime) 
        {
            for (int i = 0; i < stars.Count; i++)
            {
                stars[i].Update(_gameTime);

            }
        }
        public virtual void Draw(SpriteBatch _spriteBatch)
        {
            for (int i = 0; i < stars.Count; i++)
            {
                stars[i].Draw(_spriteBatch);

            }
        }

    }
}
