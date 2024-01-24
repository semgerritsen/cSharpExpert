using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace cSharpExpert.Framework
{
    public class SpriteRenderer
    {
        private Texture2D texture;
        private Color color = Color.White;
        private float layerDepth = 1;
        private SpriteEffects spriteEffects;
        private string textureString;

        public Transform transform;

        public SpriteRenderer(Transform _transform, string _textureString, Color _color, float _layerDepth, SpriteEffects _spriteEffects)
        {
            transform = _transform;
            color = _color;
            textureString = _textureString;
            layerDepth = _layerDepth;
            spriteEffects = _spriteEffects;
        }

        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }
        public Transform Transform
        {
            get { return transform; }

        }
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        public float LayerDepth
        {
            get { return layerDepth; }
            set { layerDepth = value; }
        }
        public SpriteEffects SpriteEffects
        {
            get { return spriteEffects; }
            set { spriteEffects = value; }
        }

        public string TextureString
        {
            get { return textureString; }
            set { textureString = value; }
        }


        public void LoadContent(ContentManager _content)
        {
            texture = _content.Load<Texture2D>(textureString);
            Transform.Origin = new Vector2(Texture.Width / 2, Texture.Height / 2);
        }


        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(texture, Transform.Position, null, color, Transform.Rotation, Transform.Origin, Transform.Scale, spriteEffects, layerDepth);
        }
    }
}
