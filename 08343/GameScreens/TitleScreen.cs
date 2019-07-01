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

namespace _08343.GameScreens
{
    public class TitleScreen : BaseGameState
    {
        private Label title;
        private LinkLabel play;
        private LinkLabel options;
        private LinkLabel credits;
        private LinkLabel exit;
        private PictureBox background;

        public TitleScreen(Game game, GameStateManager manager) : base(game, manager)
        {

        }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            ContentManager content = Game.Content;

            Texture2D backgroundImage = content.Load<Texture2D>("Images/bg");

            background = new PictureBox(backgroundImage, Vector2.Zero);
            ControlManager.Add(background);

            title = new Label()
            {
                Text = "title",
                SpriteFont = MainFont,
                Outline = true
            };
            title.Position = new Vector2((1024 - MainFont.MeasureString(title.Text).X) / 2, 50);
            ControlManager.Add(title);

            play = new LinkLabel()
            {
                Text = "Play Game",
                SpriteFont = MainFont,
                Position = new Vector2(85, 200),
                Color = Color.Red,
                SelectedColor = Color.DarkGray,
                Outline = true
            };
            play.SetRegion();
            play.Selected += Start_Selected;
            ControlManager.Add(play);

            options = new LinkLabel()
            {
                Text = "Options",
                SpriteFont = MainFont,
                Position = new Vector2(85, 300),
                Color = Color.Red,
                SelectedColor = Color.DarkGray
            };
            options.SetRegion();
            options.Selected += Options_Clicked;
            ControlManager.Add(options);

            credits = new LinkLabel()
            {
                Text = "Credits",
                SpriteFont = MainFont,
                Position = new Vector2(85, 400),
                Color = Color.Red,
                SelectedColor = Color.DarkGray
            };
            credits.SetRegion();
            ControlManager.Add(credits);

            exit = new LinkLabel()
            {
                Text = "Exit",
                SpriteFont = MainFont,
                Position = new Vector2(85, 500),
                Color = Color.Red,
                SelectedColor = Color.Red
            };
            exit.SetRegion();
            exit.Selected += Exit_Clicked;
            ControlManager.Add(exit);
        }

        private void Start_Selected(object sender, EventArgs eventArgs)
        {

        }

        private void Exit_Clicked(object sender, EventArgs eventArgs)
        {
            GameRef.Exit();
        }

        private void Options_Clicked(object sender, EventArgs eventArgs)
        {

        }

        public override void Draw(GameTime gameTime)
        {
            ControlManager.Draw(GameRef.spriteBatch);
            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {
            ControlManager.Update(gameTime);
            base.Update(gameTime);
        }
    }
}
