using ComponentDesignPattern.Assignment4;
using cSharpExpert.Framework;
using cSharpExpert.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace cSharpExpert.scenes
{
    public class ColorShifterScene : Scene
    {
        readonly GraphicsDeviceManager graphics;
        public ColorShifterScene(SceneManager _scene, GraphicsDeviceManager _graphics) : base(_scene)
        {
            graphics = _graphics;
        }

        public override void Initialize()
        {
            base.Initialize();

            for (int i = 0; i < 3; i++)
            {
                Transform transform = CreateTransform(new Vector2(200 + 200 * i, graphics.PreferredBackBufferHeight / 2), 0, 1, 1);
                SpriteRenderer spriteRenderer = CreateSpriterenderer(transform, "LittleStar", Color.White, 1, SpriteEffects.None);
                ColorShifterObject star1 = createShifter(transform, spriteRenderer, 0.5f + 0.5f * i);

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
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad4))
            {
                SceneManager.ChangeScene(SceneManager.RotatorScene);
            }
        }
        public override void Draw(SpriteBatch _spriteBatch)
        {
            base.Draw(_spriteBatch);
            _spriteBatch.DrawString(SpriteFont, "ColorShift test: shiftspeed = 0.5 + 0.5 each star", new Vector2(10, 10), Color.Black, 0, Vector2.Zero, 1.25f, SpriteEffects.None, 1);
            _spriteBatch.DrawString(SpriteFont, "press NumPad4 to go to next scene", new Vector2(450, 440), Color.Black, 0, Vector2.Zero, 1.25f, SpriteEffects.None, 1);

        }
        public Transform CreateTransform(Vector2 position, float rotation, float scale, float layerdepth)
        {
            return new Transform(position, rotation, scale, layerdepth);
        }
        public SpriteRenderer CreateSpriterenderer(Transform transform, string name, Color color, float layerDepth, SpriteEffects spriteEffects)
        {
            return new SpriteRenderer(transform, name, color, layerDepth, spriteEffects);
        }
        public ColorShifterObject createShifter(Transform transform, SpriteRenderer spriteRenderer, float shiftspeed)
        {
            return new ColorShifterObject(spriteRenderer, transform, graphics) { ShiftSpeed = shiftspeed };
        }
    }
}
