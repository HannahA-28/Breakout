using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakout
{
    public class Brick
    {
        private Rectangle _rect;
        private Texture2D _texture;

        public Brick(Rectangle rect, Texture2D texture)
        {
            _rect = rect;
            _texture = texture;
        }

        public Rectangle rect {  get { return _rect; } }

        public void Draw (SpriteBatch spriteBatch)
        {

        }
    }
}
