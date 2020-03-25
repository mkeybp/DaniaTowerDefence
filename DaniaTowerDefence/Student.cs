using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DaniaTowerDefence
{
    public class Student : GameObject
    {
        float startHealth;
        float currentHealth;
        bool isAlive = true;
        float speed = 0.5f;
        int buffGiven;

        public float CurrentHealth
        {
            get { return currentHealth; }
            set { currentHealth = value; }

        }

        public bool IsDead
        {
            get { return currentHealth <= 0; }
        }

        public int BuffGiven
        {
            get { return buffGiven; }

        }
        public Student(Texture2D texture, Vector2 position, float health, int buffGiven, float speed) : base(texture, position)
        {
            this.startHealth = health;
            this.currentHealth = startHealth;
            this.buffGiven = buffGiven;
            this.speed = speed;
            this.position.X = 10;
            this.position.Y = 150;

        }

        public Vector2 Center { get; internal set; }

        public override void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("Student_test");
        }

        public override void Update(GameTime gameTime)
        {
            if (currentHealth <= 0)
                isAlive = false;
        }



        internal static void Add(Student student)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (isAlive)
            {
                float healthPercentage = (float)currentHealth / (float)startHealth;

            }
        }


    }



}
