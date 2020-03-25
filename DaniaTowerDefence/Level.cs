using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaniaTowerDefence
{
    public class Level
    {
        int[,] map = new int[,]
{
    {0,0,1,0,0,0,0,0,},
    {0,0,1,1,0,0,0,0,},
    {0,0,0,1,1,0,0,0,},
    {0,0,0,0,1,0,0,0,},
    {0,0,0,1,1,0,0,0,},
    {0,0,1,1,0,0,0,0,},
    {0,0,1,0,0,0,0,0,},
    {0,0,1,1,1,1,1,1,},
};
        private List<Texture2D> tileTextures = new List<Texture2D>();

        public void AddTexture(Texture2D texture)
        {
            tileTextures.Add(texture);
        }
        public int Width
        {
            get { return map.GetLength(1); }
        }
        public int Height
        {
            get { return map.GetLength(0); }
        }
        public void Draw(SpriteBatch batch)
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    int textureIndex = map[y, x];
                    if (textureIndex == -1)
                        continue;

                    Texture2D texture = tileTextures[textureIndex];
                    batch.Draw(texture, new Rectangle(
                        x * 32, y * 32, 32, 32), Color.White);
                }
            }
        }


    }
}
