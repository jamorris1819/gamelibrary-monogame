// Author(s): Jacob Morris
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameLibrary;
using GameLibrary.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace _08343
{
    public abstract partial class BaseGameState : GameState
    {
        protected Game1 GameRef;
        protected ControlManager ControlManager;
        protected SpriteFont MainFont;

        protected BaseGameState(Game game, GameStateManager manager) : base(game, manager)
        {
            GameRef = (Game1) game;
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            ContentManager content = Game.Content;

            MainFont = content.Load<SpriteFont>("Fonts/mainFont");

            ControlManager = new ControlManager(MainFont);
        }

        protected override void StateChange(object sender, EventArgs e)
        {
            base.StateChange(sender, e);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            Vector2 point = new Vector2(InputHandler.Mouse.X, InputHandler.Mouse.Y);
        }
    }
}
