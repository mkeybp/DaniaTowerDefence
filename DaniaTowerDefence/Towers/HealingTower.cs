using DaniaTowerDefence.Towers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaniaTowerDefence
{
    public class HealingTower : Tower
    {
        public HealingTower(Texture2D texture, Texture2D bulletTexture, Vector2 position)
    : base(texture, bulletTexture, position)
        {
            this.damage = 15; // Set the damage
            this.cost = 0;   // Set the initial cost

            this.radius = 1000; // Set the radius
        }
        public override void Update(GameTime gameTime)
        {
            if (bulletTimer >= 0.75f && target != null)
            {
                Bullet bullet = new Bullet(bulletTexture, Vector2.Subtract(center,
                    new Vector2(bulletTexture.Width / 2)), rotation, 6, damage);

                bulletList.Add(bullet);
                bulletTimer = 0;
            }
            for (int i = 0; i < bulletList.Count; i++)
            {
                Bullet bullet = bulletList[i];

                bullet.SetRotation(rotation);
                bullet.Update(gameTime);

                if (!IsInRange(bullet.Center))
                    bullet.Kill();

                if (bullet.IsDead())
                {
                    bulletList.Remove(bullet);
                    i--;
                }
            }
            base.Update(gameTime);
        }
    }
}
