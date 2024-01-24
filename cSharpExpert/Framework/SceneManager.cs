using cSharpExpert.scenes;
using cSharpExpert.TestScenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace cSharpExpert.Framework
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
        private OriginTest origin;
        private PositionTest position;
        private RotationTest rotation;
        private ScaleTest scale;
        private ColorShifterScene colorShifter;


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
        public OriginTest OriginTest { get { return origin; } }
        public PositionTest PositionTest { get { return position; } }
        public RotationTest RotationTest { get { return rotation; } }
        public ScaleTest ScaleTest { get { return scale; } }
        public ColorShifterScene ColorShifter { get { return colorShifter; } }

        public void Initialize()
        {
            bouncerScene = new BouncersScene(this);
            rotatorScene = new RotatorScene(this);
            scalerScene = new ScalerScene(this);
            origin = new OriginTest(this);
            position = new PositionTest(this, graphics);
            rotation = new RotationTest(this);
            scale = new ScaleTest(this);
            colorShifter = new ColorShifterScene(this, graphics);

            allScenes.Add(bouncerScene);
            allScenes.Add(rotatorScene);
            allScenes.Add(scalerScene);
            allScenes.Add(origin);
            allScenes.Add(position);
            allScenes.Add(rotation);
            allScenes.Add(scale);
            allScenes.Add(colorShifter);

            for (int i = 0; i < allScenes.Count; i++)
            {
                allScenes[i].Initialize();
            }
            currentScene = origin;

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
