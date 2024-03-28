using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Assignment1.Framework
{
    public class Scene
    {
        private SceneManager sceneManager;
        private SpriteFont spriteFont;


        public List<GameObject> stars = new List<GameObject>();
        public Scene(SceneManager _scene)
        {
            sceneManager = _scene;
        }
        public SceneManager SceneManager
        {
            get { return sceneManager; }
            set { sceneManager = value; }
        }
        public SpriteFont SpriteFont
        {
            get { return spriteFont; }
            set { spriteFont = value; }
        }
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
            spriteFont = _content.Load<SpriteFont>("font");
            for (int i = 0; i < stars.Count; i++)
            {
                stars[i].LoadContent(_spriteBatch, _content);
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
