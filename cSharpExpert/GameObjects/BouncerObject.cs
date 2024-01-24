using cSharpExpert.Framework;
using Microsoft.Xna.Framework;
using System;

namespace cSharpExpert.GameObjects
{
    public class BouncerObject : GameObject
    {
        private float bounceSpeed = 1;
        private float bounceAmplitude = 1;
        private Vector2 bounceMid;
        public BouncerObject(SpriteRenderer _renderer, Transform _transfrom, GraphicsDeviceManager _graphics) : base(_renderer, _transfrom, _graphics)
        {
            bounceMid = Transform.Position;
        }

        public float BounceSpeed
        {
            get { return bounceSpeed; }
            set { bounceSpeed = value; }
        }
        public float BounceAmplitude
        {
            get { return bounceAmplitude; }
            set { bounceAmplitude = value; }
        }

        public override void Update(GameTime _gameTime)
        {
            base.Update(_gameTime);

            float time = +(float)_gameTime.TotalGameTime.TotalSeconds * BounceSpeed;
            float sinValue = (float)Math.Sin(time * MathHelper.TwoPi) * bounceAmplitude;

            Transform.Position = bounceMid + new Vector2(0, -sinValue);
        }
    }
}
