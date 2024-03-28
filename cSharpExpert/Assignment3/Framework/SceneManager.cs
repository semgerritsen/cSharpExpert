using Assignment3.scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Assignment3.Framework
{
    public class SceneManager
    {
        readonly Game1 game;
        readonly GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        readonly ContentManager content;

        readonly List<Scene> allScenes = new List<Scene>();

        private Scene currentScene;
        private TestScene testScene;


        public SceneManager(Game1 _game, GraphicsDeviceManager _graphics)
        {
            game = _game;
            graphics = _graphics;


        }
        public Scene CurrentScene { get { return currentScene; } }
        public TestScene TestScene { get { return testScene; } }


        public void Initialize()
        {
            testScene = new TestScene(this);

            allScenes.Add(testScene);

            for (int i = 0; i < allScenes.Count; i++)
            {
                allScenes[i].Initialize();
            }
            currentScene = TestScene;

        }
        public void LoadContent(SpriteBatch _spriteBatch, ContentManager _content)
        {
            spriteBatch = _spriteBatch;

            for (int i = 0; i < allScenes.Count; i++)
            {
                allScenes[i].LoadContent(_spriteBatch, _content);
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

            LoadContent(spriteBatch, content);
        }
    }
}
