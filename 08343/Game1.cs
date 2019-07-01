// Author(s): Jacob Morris
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Xml;
using GameLibrary;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Xml.Linq;
using GameLibrary.Graphics;
using Microsoft.Xna.Framework.Input.Touch;
using _08343.GameScreens;

namespace _08343
{
    public class Game1 : Game
    {
        public GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;

        public Resolution Resolution;

        private GameStateManager manager;
        public TitleScreen TitleScreen;
        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);

            Window.Title = "some game";

            IsMouseVisible = true;
            TouchPanel.EnableMouseTouchPoint = true;

            Content.RootDirectory = "Content";
            Components.Add(new InputHandler(this));
            manager = new GameStateManager(this);
            Components.Add(manager);

            TitleScreen = new TitleScreen(this, manager);

            manager.ChangeState(TitleScreen);
        }
        
        protected override void Initialize()
        {
            base.Initialize();
        }
        
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            graphics.ApplyChanges();
        }

        protected override void UnloadContent()
        {

        }
        
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if(InputHandler.KeyDown(Keys.W))
            {
                // do something
            }

            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            base.Draw(gameTime);
            InputHandler.Draw(spriteBatch);
            spriteBatch.End();
        }
    }
}
