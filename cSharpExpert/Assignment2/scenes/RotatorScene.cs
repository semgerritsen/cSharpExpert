using Assignment2.Framework;
using Assignment2.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Assignment2.scenes
{
    public class RotatorScene : Scene
    {
        readonly GraphicsDeviceManager graphics;
        public RotatorScene(SceneManager _scene) : base(_scene)
        {

        }

        public override void Initialize()
        {
            base.Initialize();

            for (int i = 0; i < 3; i++)
            {
                Transform transform = CreateTransform(new Vector2(150 + 225 * i, 120), 0, 1);
                SpriteRenderer spriteRenderer = CreateSpriterenderer(transform, "LittleStar", Color.White, 1, SpriteEffects.None);
                RotatorObject star1 = CreateRotator(transform, spriteRenderer, 0.5f + 0.25f * i, "right");
                stars.Add(star1);
            }
            for (int i = 0; i < 3; i++)
            {
                Transform transform = CreateTransform(new Vector2(150 + 225 * i, 360), 0, 1);
                SpriteRenderer spriteRenderer = CreateSpriterenderer(transform, "LittleStar", Color.White, 1, SpriteEffects.None);
                RotatorObject star1 = CreateRotator(transform, spriteRenderer, 0.5f + 0.25f * i, "left");

                stars.Add(star1);
            }
        }

        public override void LoadContent(SpriteBatch _spriteBatch, ContentManager _content)
        {
            for (int i = 0; i < stars.Count; i++)
            {
                stars[i].Spriterenderer.LoadContent(_content);
            }
            base.LoadContent(_spriteBatch, _content);
        }

        public override void Update(GameTime _gameTime)
        {
            base.Update(_gameTime);
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad2))
            {
                SceneManager.ChangeScene(SceneManager.ScalerScene);
            }
        }
        public override void Draw(SpriteBatch _spriteBatch)
        {
            base.Draw(_spriteBatch);
            _spriteBatch.DrawString(SpriteFont, "rotator test scene: Rotatespeed = 1 + 0.25, direction is rechts", new Vector2(10, 10), Color.Black, 0, Vector2.Zero, 1.25f, SpriteEffects.None, 1);
            _spriteBatch.DrawString(SpriteFont, "rotator test scene: Rotatespeed = 1 + 0.25, direction is links", new Vector2(10, 250), Color.Black, 0, Vector2.Zero, 1.25f, SpriteEffects.None, 1);
            _spriteBatch.DrawString(SpriteFont, "press NumPad2 to go to next scene", new Vector2(450, 440), Color.Black, 0, Vector2.Zero, 1.25f, SpriteEffects.None, 1);

        }
        public Transform CreateTransform(Vector2 position, float rotation, float scale)
        {
            return new Transform(position, rotation, scale);
        }
        public SpriteRenderer CreateSpriterenderer(Transform transform, string name, Color color, float layerDepth, SpriteEffects spriteEffects)
        {
            return new SpriteRenderer(transform, name, color, layerDepth, spriteEffects);
        }
        public RotatorObject CreateRotator(Transform transform, SpriteRenderer spriteRenderer, float speed, string direction)
        {
            return new RotatorObject(spriteRenderer, transform, graphics) { RotationsPerSecond = speed, Direction = direction };
        }
    }
}
