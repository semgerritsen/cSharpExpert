using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace cSharpExpert.Framework
{
    public class Transform
    {
        private Vector2 position;
        private Vector2 origin;

        public float rotation;
        public float scale;
        public Transform()
        {
           
        }
        public void CalculateDegrees(float _rotation)
        {
            rotation = MathHelper.ToRadians(_rotation);
        }
        
    }
}
