using Microsoft.Xna.Framework;

namespace Assignment3.Framework
{
    public class Transform
    {
        private Vector2 position;
        private Vector2 origin;
        private float rotation;
        private float scale;


        public Transform(Vector2 _position, float _rotation, float _scale /*Vector2 _origin,*/)
        {
            position = _position;
            rotation = _rotation;
            scale = _scale;
            //origin = _origin;
        }

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public Vector2 Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public float Rotation
        {
            get { return rotation; }
            set { rotation = MathHelper.ToRadians(value); }
        }

        public float Scale
        {
            get { return scale; }
            set { scale = value; }
        }
    }
}
