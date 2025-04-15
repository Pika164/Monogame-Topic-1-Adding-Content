using System;
using System.Threading.Channels;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Topic_1_Adding_Content
{
    
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D foxTexture, catTexture, livingroomTexture, snakeTexture, forestTexture, dogTexture;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();

            this.Window.Title = "First time :0";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            forestTexture = Content.Load<Texture2D>("forest");

            livingroomTexture = Content.Load<Texture2D>("livingroom");

            foxTexture = Content.Load<Texture2D>("fox");
            
            catTexture = Content.Load<Texture2D>("cat");

            snakeTexture = Content.Load<Texture2D>("snake");

            dogTexture = Content.Load<Texture2D>("dog");

            Random generator = new Random();

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightSlateGray);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(forestTexture, new Vector2(0,0), Color.White);
            
            _spriteBatch.Draw(livingroomTexture, new Vector2(0, 0), Color.White);

            _spriteBatch.Draw(foxTexture, new Vector2(375, 175), Color.White);

            _spriteBatch.Draw(catTexture, new Vector2(185, 200), Color.White);

            _spriteBatch.Draw(snakeTexture, new Vector2(25,15), Color.White);

            _spriteBatch.Draw(dogTexture, new Vector2(550,0), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);

        }
    }
}
