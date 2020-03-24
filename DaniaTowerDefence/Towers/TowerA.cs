using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DaniaTowerDefence.Towers
{
    public class TowerA : GameObject
    {
        //Targets student.
        protected Student target;

        public Student Target
        {
            get { return target; }
        }

        //Amount students are healed.
        protected int heal; 

        //Radius of the tower.
        protected float radius;

        public TowerA()
        {
            radius = 1000;
            this.position.X = 400;
            this.position.Y = 150;
        }
        public bool IsInRange(Vector2 position)
        {
            if (Vector2.Distance(center, position) <= radius)
                return true;

            return false;
        }

        public int Heal
        {
            get { return heal; }
        }
        public float Radius
        {
            get { return radius; }
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
            Vector2 direction = Center - target.Center;
            direction.Normalize();

            rotation = (float)Math.Atan2(-direction.X, direction.Y);
        }






        public override void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("Tower_aim");
        }

        public override void Update(GameTime gameTime)
        {
            if (target != null)
                FaceTarget();
        }
    }
}
