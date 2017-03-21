using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorFromBook
{
    class Color
    {
        private byte redValue;
        private byte greenValue;
        private byte blueValue;
        private byte alphaValue;

        public Color(byte redValue, byte greenValue, byte blueValue, byte alphaValue)
        {
            this.redValue = redValue;
            this.greenValue = greenValue;
            this.blueValue = blueValue;
            this.alphaValue = alphaValue;
        }

        public Color(byte redValue, byte greenValue, byte blueValue)
        {
            this.redValue = redValue;
            this.greenValue = greenValue;
            this.blueValue = blueValue;
            this.alphaValue = 255;
        }

        public byte GetRedValue()
        {
            return redValue;
        }

        public byte GetGreenValue()
        {
            return greenValue;
        }

        public byte GetBlueValue()
        {
            return blueValue;
        }

        public byte GetAlphaValue()
        {
            return alphaValue;
        }

        public void SetRedValue(byte redValue)
        {
            this.redValue = redValue;
        }

        public void SetGreenValue(byte greenValue)
        {
            this.greenValue = greenValue;
        }

        public void SetBlueValue(byte blueValue)
        {
            this.blueValue = blueValue;
        }

        public void SetAlphaValue(byte alphaValue)
        {
            this.alphaValue = alphaValue;
        }

        public int GetGrayscaleValue(byte redValue, byte greenValue, byte blueValue)
        {
            int sum = redValue + greenValue + blueValue;
            int grayscaleValue = sum / 3;
            return grayscaleValue;
        }
    }
}
