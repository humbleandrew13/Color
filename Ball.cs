using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorFromBook
{
    class Ball
    {
        private float size;
        private string color;
        private int timesThrown;
        
        public Ball(float size, string color)
        {
            this.size = size;
            this.color = color;
            this.timesThrown = 0;
        }

        public float GetSize()
        {
            return size;
        }

        public void SetSize(float size)
        {
            this.size = size;
        }

        public string GetColor()
        {
            return color;
        }

    }
}
