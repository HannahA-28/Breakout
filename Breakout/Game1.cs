using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Breakout
{
    enum Screen
    {
        Intro,
        Game,
        Win,
        Lose
    }
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Screen screen;
        Rectangle window;
        Texture2D introTexture;
        Texture2D gameTexture;
        Texture2D winTexture;
        Texture2D loseTexture;
        Texture2D paddleTexture;
        Rectangle paddleRect;
        Texture2D ballTexture;
        Rectangle ballRect;
        MouseState mouseState;
        KeyboardState keyboardState;
        SpriteFont spriteFont;
        Vector2 ballSpeed;
        Vector2 paddleSpeed;
        Paddle paddle;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            paddle = new Paddle(paddleTexture, new Rectangle(350, 350, 75, 20);

            screen = Screen.Intro;
          
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            introTexture = Content.Load<Texture2D>("intro");
            gameTexture = Content.Load<Texture2D>("game");
            winTexture = Content.Load<Texture2D>("win");
            loseTexture = Content.Load<Texture2D>("lose");
            spriteFont = Content.Load<SpriteFont>("spriteFont");
            paddleTexture = Content.Load<Texture2D>("paddle");
            ballTexture = Content.Load<Texture2D>("circle");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            keyboardState = Keyboard.GetState();
            paddle.Update(keyboardState);

            if (screen == Screen.Intro)
            {
                if (keyboardState.IsKeyDown(Keys.Enter))
                {
                    screen = Screen.Game;
                }
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            if (screen == Screen.Intro)
            {
                _spriteBatch.Draw(introTexture, window, Color.White);
                _spriteBatch.DrawString(spriteFont, "Click ENTER to play the game.", new Vector2(225, 440), Color.White);
            }
            else if (screen == Screen.Game)
            {
                _spriteBatch.Draw(gameTexture, window, Color.White);
                _spriteBatch.Draw(paddleTexture, paddleRect, Color.White);
                _spriteBatch.Draw(ballTexture, ballRect, Color.White);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}