using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace cSharpExpert.Framework
{
    public class Transform
    {
        private Vector2 position = new Vector2(100,100);
        private Vector2 origin;
        private float rotation = 0;
        private float scale;

        public Transform()
        {
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
            set { rotation = value; }
        }

        public float Scale
        {
            get { return scale; }
            set { scale = value; }
        }

        /// <summary>
        /// Method to calculate rotation in degrees and convert it to radians
        /// </summary>
        /// <param name="_rotation">Add amount of rotation in degrees, preferably [0, 360]</param>
        public void CalculateDegrees(float _rotation)
        {
            rotation = MathHelper.ToRadians(_rotation);
        }
    }

}
