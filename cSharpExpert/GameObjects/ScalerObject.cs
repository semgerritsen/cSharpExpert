using cSharpExpert.Framework;
using Microsoft.Xna.Framework;
using System;

namespace cSharpExpert.GameObjects
{
    public class ScalerObject : GameObject
    {
        private float scaleSpeed = 1;
        private float scaleAmplitude = 1;
        private float defaultScale = 1;
        private float time = 0;
        public ScalerObject(SpriteRenderer _renderer, Transform _transfrom, GraphicsDeviceManager _graphics) : base(_renderer, _transfrom, _graphics)
        {
            defaultScale = Transform.Scale;
        }
        public float ScaleSpeed
        {
            get { return scaleSpeed; }
            set { scaleSpeed = value; }
        }
        public float ScaleAmplitude
        {
            get { return scaleAmplitude; }
            set { scaleAmplitude = value; }
        }
        public override void Update(GameTime _gameTime)
        {
            base.Update(_gameTime);

            time += (float)_gameTime.ElapsedGameTime.TotalSeconds;
            float sinValue = ((MathF.Sin(time * (scaleSpeed * MathHelper.TwoPi)) + 1) * 0.5f) * scaleAmplitude;

            Transform.Scale = defaultScale * sinValue;
        }
    }
}
