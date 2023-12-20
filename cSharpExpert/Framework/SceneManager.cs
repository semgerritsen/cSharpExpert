using cSharpExpert.scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace cSharpExpert.Framework
{
    public class SceneManager
    {

        private Game1 game;
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private ContentManager content;

        private Test1 test1;

        private List<Scene> allScenes = new List<Scene>();

        public Scene currentScene;


        public SceneManager(Game1 _game, GraphicsDeviceManager _graphics)
        {
            game = _game;
            graphics = _graphics;

        }
        public void Initialize()
        {
            test1 = new Test1();

            allScenes.Add(test1);

            for (int i = 0; i < allScenes.Count; i++)
            {
                allScenes[i].Initialize();
            }
            currentScene = test1;

        }
        public void LoadContent(SpriteBatch _spriteBatch, ContentManager _content)
        {
            spriteBatch = _spriteBatch;

            for (int i = 0; i < allScenes.Count; i++)
            {
                allScenes[i].LoadContent(_spriteBatch,_content);
            }
        }
        public void Update(GameTime _gametime)
        {
            currentScene.Update(_gametime);
        }
        public void Draw(SpriteBatch _spriteBatch)
        {
            currentScene.Draw(_spriteBatch);
        }

        public void ChangeScene(Scene _newScene)
        {
            currentScene.Exit();
            currentScene = _newScene;
            currentScene.Enter();
        }

        public void Reset()
        {
            allScenes.Clear();

            Initialize();
            LoadContent(spriteBatch, content);
        }
    }
}
