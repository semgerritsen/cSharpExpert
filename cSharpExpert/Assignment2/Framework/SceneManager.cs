using Assignment2.scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Assignment2.Framework
{
    public class SceneManager
    {
        readonly Game1 game;
        readonly GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        readonly ContentManager content;

        private BouncersScene bouncerScene;
        private RotatorScene rotatorScene;
        private ScalerScene scalerScene;


        readonly List<Scene> allScenes = new List<Scene>();

        private Scene currentScene;


        public SceneManager(Game1 _game, GraphicsDeviceManager _graphics)
        {
            game = _game;
            graphics = _graphics;


        }
        public Scene CurrentScene { get { return currentScene; } }
        public BouncersScene BouncerScene { get { return bouncerScene; } }
        public RotatorScene RotatorScene { get { return rotatorScene; } }
        public ScalerScene ScalerScene { get { return scalerScene; } }


        public void Initialize()
        {
            bouncerScene = new BouncersScene(this);
            rotatorScene = new RotatorScene(this);
            scalerScene = new ScalerScene(this);

            allScenes.Add(bouncerScene);
            allScenes.Add(rotatorScene);
            allScenes.Add(scalerScene);

            for (int i = 0; i < allScenes.Count; i++)
            {
                allScenes[i].Initialize();
            }
            currentScene = bouncerScene;

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
