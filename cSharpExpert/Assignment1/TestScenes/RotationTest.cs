using Assignment1.Framework;
using Assignment1.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Assignment1.TestScenes
{
    public class RotationTest : Scene
    {
        readonly GraphicsDeviceManager graphics;
        readonly ContentManager content;

        SpriteRenderer spriteRenderer;
        Transform transform;

        private Star gameObject;
        private BouncerObject bounce;
        private RotatorObject rotate;
        private ScalerObject scale;

        public RotationTest(SceneManager _scene) : base(_scene)
        {

        }

        public override void Initialize()
        {
            base.Initialize();

            for (int i = 0; i < 5; i++)
            {
                Transform transform = CreateTransform(new Vector2(100 + 145 * i, 160), MathHelper.ToRadians(0 + 45 * i), 0.80f);
                SpriteRenderer spriteRenderer = CreateSpriterenderer(transform, "LittleStar", Color.White, 1, SpriteEffects.None);
                Star star1 = createStar(transform, spriteRenderer);
                stars.Add(star1);
            }
            for (int i = 0; i < 5; i++)
            {
                Transform transform = CreateTransform(new Vector2(100 + 145 * i, 340), MathHelper.ToRadians(180 + 45 * i), 0.80f);
                SpriteRenderer spriteRenderer = CreateSpriterenderer(transform, "LittleStar", Color.White, 1, SpriteEffects.None);
                Star star1 = createStar(transform, spriteRenderer);
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
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad3))
            {
                SceneManager.ChangeScene(SceneManager.ScaleTest);

            }
        }
        public override void Draw(SpriteBatch _spriteBatch)
        {
            base.Draw(_spriteBatch);
            _spriteBatch.DrawString(SpriteFont, "Rotation test scene: starts at 0 degrees, adds 45 degrees each star ", new Vector2(10, 10), Color.Black, 0, Vector2.Zero, 1.25f, SpriteEffects.None, 1);
            _spriteBatch.DrawString(SpriteFont, "press NumPad3 to go to next scene", new Vector2(450, 440), Color.Black, 0, Vector2.Zero, 1.25f, SpriteEffects.None, 1);

        }
        public Transform CreateTransform(Vector2 position, float rotation, float scale)
        {
            return new Transform(position, rotation, scale);

        }
        public SpriteRenderer CreateSpriterenderer(Transform transform, string name, Color color, float layerDepth, SpriteEffects spriteEffects)
        {
            return new SpriteRenderer(transform, name, color, layerDepth, spriteEffects);
        }
        public Star createStar(Transform transform, SpriteRenderer spriteRenderer)
        {
            return new Star(spriteRenderer, transform, graphics) { };
        }
    }
}