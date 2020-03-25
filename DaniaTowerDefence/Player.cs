using DaniaTowerDefence.Towers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaniaTowerDefence
{
    public class Player
    {

        private Texture2D bulletTexture;

        private int money = 50;
        private int lives = 30;

        private List<Tower> towers = new List<Tower>();

        private MouseState mouseState; // Mouse state for the current frame
        private MouseState oldState; // Mouse state for the previous frame

        public int Money
        {
            get { return money; }
        }
        public int Lives
        {
            get { return lives; }
        }
        private Level level;

        public Player(Level level, Texture2D towerTexture, Texture2D bulletTexture)
        {
            this.level = level;

            this.towerTexture = towerTexture;
            this.bulletTexture = bulletTexture;
        }

        private int cellX;
        private int cellY;

        private int tileX;
        private int tileY;
        private Texture2D towerTexture;

        public void Update(GameTime gameTime, List<Student> students)
        {
            mouseState = Mouse.GetState();

            cellX = (int)(mouseState.X / 32); // Convert the position of the mouse
            cellY = (int)(mouseState.Y / 32); // from array space to level space

            tileX = cellX * 32; // Convert from array space to level space
            tileY = cellY * 32; // Convert from array space to level space

            oldState = mouseState; // Set the oldState so it becomes the state of the previous frame.
            HealingTower tower = new HealingTower(towerTexture,
bulletTexture, new Vector2(tileX, tileY));
        }

    }
}
