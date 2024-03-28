using Assignment3.Framework;
using Microsoft.Xna.Framework;
using System;

namespace Assignment3.GameObjects
{
    public class BouncerComponent : MonoBehaviour
    {
        private float bounceSpeed = 1;
        private float bounceAmplitude = 1;
        private Vector2 bounceMid;

        public BouncerComponent(Transform _transfrom, GraphicsDeviceManager _graphics) : base(_transfrom, _graphics)
        {
            bounceMid = _transfrom.Position;
        }

        //public BouncerComponent(SpriteRenderer _renderer, Transform _transfrom, GraphicsDeviceManager _graphics) : base(_renderer, _transfrom, _graphics)
        //{
        //}

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

            //Transform.Position = bounceMid + new Vector2(0, -sinValue);
        }
    }
}
