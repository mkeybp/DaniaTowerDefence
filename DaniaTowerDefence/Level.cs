using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DaniaTowerDefence
{
    class Level
    {
        int[,] map = new int[,] //Level layout.
        {
            {0,1,0,0,0,0,0,0},
            {0,1,0,0,0,1,1,0},
            {0,1,1,1,1,0,0,1},
            {0,0,0,0,0,0,0,1},
            {0,0,0,1,1,1,1,0},
            {0,1,1,0,0,0,0,0},
            {1,0,0,0,1,1,1,0},
            {1,0,0,1,0,0,1,0},
            {1,0,0,1,0,0,1,0},
            {0,1,1,0,0,0,1,0}
        };

        public int Width //Banens bredde.
        { get { return map.GetLength(1); } }

        public int Height //Banens Højde
        {
            get { return map.GetLength(0); }
        }

        private List<Texture2D> tileTextures = new List<Texture2D>(); // dette er en liste over de textures vi skal bruge til banen.

        public void AddTexture(Texture2D texture) // med denne metode kan vi adde textures til vores liste.
        {
            tileTextures.Add(texture);
        }

        public void Draw(SpriteBatch spriteBatch) // denne funktion placere vores tiles udfra det layout der blev lavet tidligere. Den kører et for loop inde i et for loop.
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    int textureIndex = map[y, x];
                    if (textureIndex == -1)
                        continue;
                    Texture2D texture = tileTextures[textureIndex];
                    spriteBatch.Draw(texture, new Rectangle(x * 32, y * 32, 32, 32), Color.White);
                }
            }
        }

    }
}
