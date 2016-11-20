using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mono2DLearning
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D star;
        private Texture2D earth;
        private Texture2D shuttle;
        private SpriteFont fonts;
        private int score = 0;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.IsFullScreen = true;
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 480;
            graphics.SupportedOrientations = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            star = Content.Load<Texture2D>("stars");
            earth = Content.Load<Texture2D>("earth");
            shuttle = Content.Load<Texture2D>("shuttle");
            spriteBatch = new SpriteBatch(GraphicsDevice);
            fonts = Content.Load<SpriteFont>("SpriteFont");
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                Exit();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(star, new Rectangle(0, 0, 800, 480), Color.White);
            spriteBatch.DrawString(fonts, "Hello Mono! " + gameTime.TotalGameTime.TotalMilliseconds, new Vector2(graphics.PreferredBackBufferWidth / 2, graphics.PreferredBackBufferHeight / 2), Color.WhiteSmoke);
            spriteBatch.Draw(earth, new Vector2(10, 10), Color.White);
            spriteBatch.Draw(shuttle, new Vector2(100, 100), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
