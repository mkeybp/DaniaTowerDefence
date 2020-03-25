using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaniaTowerDefence
{
    class WaveManager
    {
        private int numberOfWaves; 
        //hvor mange waves spillet skal have.
        private float timeSinceLastWave; 
        //hvor langt der går efter den sidste wave sluttede.
        private Queue<Wave> waves = new Queue<Wave>();
        //skaber en kø med alle vores waves i.
        private Texture2D studentTexture;
        //Texture til vores studerende.
        private bool finishedWave = false;
        //er den nuværende bølge ovre.


    }
}
