﻿using cSharpExpert.Framework;
using cSharpExpert.GameObjects;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpExpert.scenes
{
    public class BouncersScene : Scene
    {
        readonly GraphicsDeviceManager graphics;
        public BouncersScene(SceneManager _scene) : base(_scene)
        {
        }

        public override void Initialize()
        {
            base.Initialize();

            for (int i = 0; i < 3; i++)
            {
                Transform transform = CreateTransform(new Vector2(150 + 225 * i, 240), 0, 1, 1);
                SpriteRenderer spriteRenderer = CreateSpriterenderer(transform, "LittleStar", Color.White, 1, SpriteEffects.None);
                BouncerObject star1 = createBounce(transform, spriteRenderer, 1, 2 + 3 * i);

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
                SceneManager.ChangeScene(SceneManager.Rotator);
            }
        }
        public override void Draw(SpriteBatch _spriteBatch)
        {
            base.Draw(_spriteBatch);
            _spriteBatch.DrawString(SpriteFont, "Bouncer test scene: bouncespeed = 1 , amplitude = 2 + 3", new Vector2(10, 10), Color.Black, 0, Vector2.Zero, 1.25f, SpriteEffects.None,1);
            _spriteBatch.DrawString(SpriteFont, "press NumPad2 to go to next scene", new Vector2(450, 440), Color.Black, 0, Vector2.Zero, 1.25f, SpriteEffects.None,1);

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
            return new Star(spriteRenderer, transform, graphics);
        }
        public BouncerObject createBounce(Transform transform, SpriteRenderer spriteRenderer, float speed, float amplitude)
        {
            return new BouncerObject(spriteRenderer, transform, graphics) { BounceSpeed = speed, BounceAmplitude = amplitude };
        }
    }
}
