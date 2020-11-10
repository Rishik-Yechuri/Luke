using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Luke
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D backgroundTexture;
        Rectangle backgroundRectangle;
        SoundEffect effecet1;
        SoundEffect effecet2;
        SoundEffect effecet3;
        SoundEffect effecet4;
        SoundEffect effecet5;
        SoundEffect effecet6;
        SpriteFont font1;
        KeyboardState oldKb = Keyboard.GetState();
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            backgroundRectangle = new Rectangle(0, 0, 800, 480);
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            effecet1 = Content.Load<SoundEffect>("900YEARS");
            effecet2 = Content.Load<SoundEffect>("ACKBAR");
            effecet3 = Content.Load<SoundEffect>("AckForce");
            effecet4 = Content.Load<SoundEffect>("blaster-firing");
            effecet5 = Content.Load<SoundEffect>("CARGO");
            effecet6 = Content.Load<SoundEffect>("chewycry");
            backgroundTexture = Content.Load<Texture2D>("Star Wars #0");
            font1 = Content.Load<SpriteFont>("SpriteFont1");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            KeyboardState kb = Keyboard.GetState();
            if (kb.IsKeyDown(Keys.Q)) {
                effecet1.Play();
            } else if (kb.IsKeyDown(Keys.W)) {
                effecet2.Play();
            }
            else if (kb.IsKeyDown(Keys.E))
            {
                effecet3.Play();
            }
            else if (kb.IsKeyDown(Keys.R))
            {
                effecet4.Play();
            }
            else if (kb.IsKeyDown(Keys.T))
            {
                effecet5.Play();
            }
            else if (kb.IsKeyDown(Keys.Y))
            {
                effecet6.Play();
            }
            oldKb = kb;
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(backgroundTexture, backgroundRectangle, Color.White);
            spriteBatch.DrawString(font1,"Q=900YEARS",new Vector2(20,30),Color.White);
            spriteBatch.DrawString(font1, "W=ACKBAR", new Vector2(20, 60), Color.White);
            spriteBatch.DrawString(font1, "E=AckForce", new Vector2(20, 90), Color.White);
            spriteBatch.DrawString(font1, "R=blaster-firing", new Vector2(20, 120), Color.White);
            spriteBatch.DrawString(font1, "T=CARGO", new Vector2(20, 150), Color.White);
            spriteBatch.DrawString(font1, "Y=chewycry", new Vector2(20, 180), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
