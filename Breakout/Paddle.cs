using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class Paddle
    {
        private Rectangle _rect;
        private Texture2D _texture;
        private Vector2 _speed;
        private Rectangle _window;

        public Paddle(Texture2D texture, Rectangle rect, Rectangle window)
        {
            _texture = texture;
            _window = window;
            _rect = rect;
            _speed = Vector2.Zero;
        }

        public Rectangle rect { get { return _rect; } }

        public Rectangle window { get { return _window; } }

        public void Draw(SpriteBatch spriteBatch)
        {

        }

    }
}
