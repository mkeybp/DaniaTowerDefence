using DaniaTowerDefence.Towers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace DaniaTowerDefence
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameWorld : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Student student1;
        Tower tower;
        Level level = new Level();
        Bullet bullet;
        HealingTower healingtower;
        Player player;
        public Texture2D towerTexture;

        public GameWorld()
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
            Texture2D enemyTexture = Content.Load<Texture2D>("Student_Test");
            student1 = new Student(enemyTexture, Vector2.Zero, 100, 10, 0.5f);
            Texture2D towerTexture = Content.Load<Texture2D>("Tower_aim");
            Texture2D bulletTexture = Content.Load<Texture2D>("Healing_Test");
            tower = new Tower(towerTexture, bulletTexture, Vector2.Zero);
            healingtower = new HealingTower(towerTexture, bulletTexture, Vector2.Zero);
            player = new Player(level, towerTexture, bulletTexture);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here
            //student1.CurrentHealth -= 1;
            student1.Update(gameTime);
            if (tower.Target == null)
            {
                List<Student> students = new List<Student>();
                students.Add(student1);

                tower.GetClosestEnemy(students);
            }
            //bullet.Update(gameTime);
            tower.Update(gameTime);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            student1.Draw(spriteBatch);
            tower.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
