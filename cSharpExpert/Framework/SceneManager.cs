using cSharpExpert.scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace cSharpExpert.Framework
{
    public class SceneManager
    {
        private Game1 game;
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private ContentManager content;

        private BouncersScene bouncer;
        private RotatorScene rotator;
        private ScalerScene scaler;
        private StarScene star;

        private List<Scene> allScenes = new List<Scene>();

        private Scene currentScene;


        public SceneManager(Game1 _game, GraphicsDeviceManager _graphics)
        {
            game = _game;
            graphics = _graphics;


        }
        public Scene CurrentScene
        {
            get { return currentScene; }
            set { currentScene = value; }
        }
        public BouncersScene Bouncer 
        {
            get { return bouncer; }
            set { bouncer = value; }
        }
        public RotatorScene Rotator
        {
            get { return rotator; }
            set { rotator = value; }
        }
        public ScalerScene Scaler 
        { 
            get { return scaler; }
            set { scaler = value; }
        }
        public StarScene Star 
        {
            get { return star; } 
            set { star = value; } 
        }

        public void Initialize()
        {
            bouncer = new BouncersScene(this);
            rotator = new RotatorScene(this);
            scaler = new ScalerScene(this);
            star = new StarScene(this);

            allScenes.Add(bouncer);
            allScenes.Add(rotator); 
            allScenes.Add(scaler);
            allScenes.Add(star);

            for (int i = 0; i < allScenes.Count; i++)
            {
                allScenes[i].Initialize();
            }
            currentScene = bouncer;

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
