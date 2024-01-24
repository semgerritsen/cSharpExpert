using cSharpExpert.Framework;
using cSharpExpert.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace cSharpExpert.scenes
{
    public class ScalerScene : Scene
    {
        readonly GraphicsDeviceManager graphics;

        public ScalerScene(SceneManager _scene) : base(_scene)
        {

        }

        public override void Initialize()
        {
            base.Initialize();

            for (int i = 0; i < 3; i++)
            {
                Transform transform = CreateTransform(new Vector2(150 + 225 * i, 240), 0, 1);
                SpriteRenderer spriteRenderer = CreateSpriterenderer(transform, "LittleStar", Color.White, 1, SpriteEffects.None);
                ScalerObject star1 = CreateScaler(transform, spriteRenderer, 1, 1 + 0.25f * i);
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
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad6))
            {
                SceneManager.ChangeScene(SceneManager.ColorShifter);
            }
        }
        public override void Draw(SpriteBatch _spriteBatch)
        {
            base.Draw(_spriteBatch);
            _spriteBatch.DrawString(SpriteFont, "scaler test scene: ScaleSpeed = 1 , scaleAmplitude is 1 + 0.25", new Vector2(10, 10), Color.Black, 0, Vector2.Zero, 1.25f, SpriteEffects.None, 1);
            _spriteBatch.DrawString(SpriteFont, "press NumPad6 to go to next scene", new Vector2(450, 440), Color.Black, 0, Vector2.Zero, 1.25f, SpriteEffects.None, 1);
        }
        public Transform CreateTransform(Vector2 position, float rotation, float scale)
        {
            return new Transform(position, rotation, scale);
        }
        public SpriteRenderer CreateSpriterenderer(Transform transform, string name, Color color, float layerDepth, SpriteEffects spriteEffects)
        {
            return new SpriteRenderer(transform, name, color, layerDepth, spriteEffects);
        }
        public ScalerObject CreateScaler(Transform transform, SpriteRenderer spriteRenderer, float speed, float amplitude)
        {
            return new ScalerObject(spriteRenderer, transform, graphics) { ScaleSpeed = speed, ScaleAmplitude = amplitude };
        }
    }
}
