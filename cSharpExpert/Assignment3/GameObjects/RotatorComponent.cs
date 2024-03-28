using Assignment3.Framework;
using Microsoft.Xna.Framework;

namespace Assignment3.GameObjects
{
    public class RotatorComponent : MonoBehaviour
    {
        private float rotationsPerSecond = 1;
        private string direction = "right";

        public RotatorComponent(Transform _transfrom, GraphicsDeviceManager _graphics) : base(_transfrom, _graphics)
        {
        }

        //public RotatorComponent(SpriteRenderer _renderer, Transform _transfrom, GraphicsDeviceManager _graphics) : base(_renderer, _transfrom, _graphics)
        //{

        //}

        public float RotationsPerSecond
        {
            get { return rotationsPerSecond; }
            set { rotationsPerSecond = value; }
        }
        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public override void Update(GameTime _gameTime)
        {
            base.Update(_gameTime);

            switch (direction)
            {
                case "left":

                    //Transform.Rotation = -rotationsPerSecond * (float)_gameTime.TotalGameTime.TotalSeconds * 360;
                    break;

                case "right":
                    //Transform.Rotation = +rotationsPerSecond * (float)_gameTime.TotalGameTime.TotalSeconds * 360;
                    break;
            }
        }
    }
}
