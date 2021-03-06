﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaniaTowerDefence
{
    public abstract class GameObject
    {
        protected Texture2D[] sprites;

        protected Texture2D sprite;

        protected Vector2 position;

        protected Vector2 origin;

        protected Vector2 center;

        protected float rotation;

        protected int fps;

        protected float attackSpeed;

        protected Texture2D Texture2D;

        protected Texture2D texture;

        protected Vector2 velocity;


        protected GameObject(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
        }

        public abstract void LoadContent(ContentManager content);

        public abstract void Update(GameTime gameTime);

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, null, Color.White, 0, origin, 1, SpriteEffects.None, 1);
        }

    }
}
