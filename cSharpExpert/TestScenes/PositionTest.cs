using cSharpExpert.Framework;
using cSharpExpert.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace cSharpExpert.TestScenes
{
    public class PositionTest : Scene
    {
        readonly GraphicsDeviceManager graphics;
        readonly ContentManager content;

        SpriteRenderer spriteRenderer;
        Transform transform;

        private Star gameObject;
        private BouncerObject bounce;
        private RotatorObject rotate;
        private ScalerObject scale;

        public PositionTest(SceneManager _scene, GraphicsDeviceManager _graphics) : base(_scene)
        {
            graphics = _graphics;
        }

        public override void Initialize()
        {
            base.Initialize();

            for (int i = 0; i < 2; i++)
            {
                Transform transform = CreateTransform(new Vector2(graphics.PreferredBackBufferWidth / graphics.PreferredBackBufferWidth + graphics.PreferredBackBufferWidth * i, 0), MathHelper.ToRadians(0), 1, 1);
                SpriteRenderer spriteRenderer = CreateSpriterenderer(transform, "LittleStar", Color.White, 1, SpriteEffects.None);
                Star star1 = createStar(transform, spriteRenderer);
                stars.Add(star1);
            }
            for (int i = 0; i < 2; i++)
            {
                Transform transform = CreateTransform(new Vector2(graphics.PreferredBackBufferWidth / graphics.PreferredBackBufferWidth + graphics.PreferredBackBufferWidth * i, graphics.PreferredBackBufferHeight), MathHelper.ToRadians(0), 1, 1);
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
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad1))
            {
                SceneManager.ChangeScene(SceneManager.RotationTest);

            }
        }
        public override void Draw(SpriteBatch _spriteBatch)
        {
            base.Draw(_spriteBatch);
            _spriteBatch.DrawString(SpriteFont, "Position test scene: \n\neach star is placed at the corner of the screen using PreferredBackBufferWidth / Height", new Vector2(10, graphics.PreferredBackBufferHeight / 2), Color.Black, 0, Vector2.Zero, 1.25f, SpriteEffects.None, 1);
            _spriteBatch.DrawString(SpriteFont, "press NumPad1 to go to next scene", new Vector2(250, 10), Color.Black, 0, Vector2.Zero, 1.25f, SpriteEffects.None, 1);

        }
        public Transform CreateTransform(Vector2 position, float rotation, float scale, float layerdepth)
        {
            return new Transform(position, rotation, scale, layerdepth);
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