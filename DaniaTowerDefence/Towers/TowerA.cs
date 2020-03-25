using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaniaTowerDefence.Towers
{
    public class Tower : GameObject
    {
        protected float bulletTimer; // How long ago was a bullet fired
        protected List<Bullet> bulletList = new List<Bullet>();

        protected int cost; // How much will the tower cost to make
        protected int damage; // The damage done to enemy's

        protected float radius; // How far the tower can shoot

        protected Texture2D bulletTexture;

        protected Student target;



        public Student Target
        {
            get { return target; }
        }


        public int Cost
        {
            get { return cost; }
        }
        public int Damage
        {
            get { return damage; }
        }

        public float Radius
        {
            get { return radius; }
        }

        public Tower(Texture2D texture, Texture2D bulletTexture, Vector2 position)
        : base(texture, position)
        {
            radius = 1000;
            this.position.X = 500;
            this.position.Y = 100;
            this.bulletTexture = bulletTexture;
        }

        public Towers(Texture2D texture, Vector2 position)
        {

            this.texture = texture;
            this.position = position;

        }

        public bool IsInRange(Vector2 position)
        {
            if (Vector2.Distance(center, position) <= radius)
                return true;

            return false;
        }
        public void GetClosestEnemy(List<Student> students)
        {
            target = null;
            float smallestRange = radius;

            foreach (Student student in students)
            {
                if (Vector2.Distance(center, student.Center) < smallestRange)
                {
                    smallestRange = Vector2.Distance(center, student.Center);
                    target = student;
                }
            }
        }
        protected void FaceTarget()
        {
            Vector2 direction = center - target.Center;
            direction.Normalize();

            rotation = (float)Math.Atan2(-direction.X, direction.Y);
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            bulletTimer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (target != null)
            {
                FaceTarget();

                if (!IsInRange(target.Center))
                {
                    target = null;
                    bulletTimer = 0;
                }
            }
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (Bullet bullet in bulletList)
            {
                bullet.Draw(spriteBatch);
            }

            base.Draw(spriteBatch);
        }
    }
}
