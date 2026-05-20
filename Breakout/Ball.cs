using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class Ball
    {
        private Rectangle _rect;
        private Texture2D _texture;
        private Vector2 _speed;

        public Ball(Rectangle rect, Texture2D texture)
        {
            _rect = rect;
            _texture = texture;
            _speed = Vector2.Zero;
        }

        public Rectangle rect { get { return _rect; } }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
