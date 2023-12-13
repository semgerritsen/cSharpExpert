using cSharpExpert.Framework;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace cSharpExpert
{
    public class Game1 : Game
    {
        readonly GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //position for the star
        private Vector2 position;

        //textures
        private Texture2D texture;
        private Texture2D Circle;

        Transform transform;


        public Game1()
        {

            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            position = new Vector2(_graphics.PreferredBackBufferWidth /2, _graphics.PreferredBackBufferHeight /2);

            transform = new Transform();
            transform.CalculateDegrees(0);

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            texture = Content.Load<Texture2D>("LittleStar");
            Circle = Content.Load<Texture2D>("CircleTransparent");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here's
            _spriteBatch.Begin();
            _spriteBatch.Draw(texture, position, null, Color.White,transform.rotation, new Vector2(texture.Width / 2, texture.Height / 2), 1, SpriteEffects.None, 0);
            _spriteBatch.Draw(Circle, position, null, Color.White, 0, new Vector2(texture.Width / 2, texture.Height / 2), 1, SpriteEffects.None, 0.1f);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
