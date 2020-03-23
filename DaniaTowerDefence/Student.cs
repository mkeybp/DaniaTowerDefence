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

        public Student()
        {
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

        }

        internal static void Add(Student student)
        {
        }
    }
}
