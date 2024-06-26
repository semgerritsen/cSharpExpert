﻿using Assignment1.Framework;
using Assignment1.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Assignment1.TestScenes
{
    public class ScaleTest : Scene
    {
        readonly GraphicsDeviceManager graphics;
        readonly ContentManager content;
        public ScaleTest(SceneManager _scene) : base(_scene)
        {

        }

        public override void Initialize()
        {
            base.Initialize();

            for (int i = 0; i < 3; i++)
            {
                Transform transform = CreateTransform(new Vector2(150 + 225 * i, 240), MathHelper.ToRadians(0), 1 + 0.25f * i);
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
        }
        public override void Draw(SpriteBatch _spriteBatch)
        {
            base.Draw(_spriteBatch);
            _spriteBatch.DrawString(SpriteFont, "Scale test scene: stars at 1, adds 0.25 each star", new Vector2(10, 10), Color.Black, 0, Vector2.Zero, 1.25f, SpriteEffects.None, 1);
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