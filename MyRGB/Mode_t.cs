using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Unclassified.Drawing;

namespace MyRGB
{
    class ZoneMode_t
    {
        public Mode_t Name { get; set; }

        public ColorWheel_t StaticColor { get; set; }
        public ColorWheel_t[] SpecificLed { get; set; }

        public ColorWheel_t TheaterChaseColor { get; set; } 
        public int TheaterChaseDelay { get; set; } = 100;
        public bool TheaterChaseRainbow { get; set; }

        public int RainbowDelay { get; set; } = 10;
        public bool RainbowCycle { get; set; }

        public int WipeDelay { get; set; } = 50;
        public ColorWheel_t WipeColor { get; set; }

        //public ZoneMode_t()
        //{
        //    WipeDelay = 50;
        //    TheaterChaseRainbow = false;
        //    TheaterChaseDelay = 50;
        //    RainbowCycle = false;
        //    StaticColor = new ColorWheel_t();
        //    TheaterChaseColor = new ColorWheel_t();
        //    WipeColor = new ColorWheel_t();
        //}
    }

    enum Mode_t : byte
    {
        Static = 1,
        Theaterchase,
        Rainbow,
        Wipe,
        Flash,
        Audio
    }

    [StructLayout(LayoutKind.Sequential)]
    class ColorWheel_t
    {
        public HslColor HSL { get; set; } 

        //public ColorWheel_t(Unclassified.UI.ColorWheel colorWheelControl)
        //{
        //    Hue = colorWheelControl.Hue;
        //    Saturation = colorWheelControl.Saturation;
        //    Lightness = colorWheelControl.Lightness;
        //}

        public ColorWheel_t()
        {
            HSL = new HslColor(0, 255, 128);

        }

        public ColorWheel_t(byte h, byte s, byte l)
        {
            HSL = new HslColor(h, s, l);
        }

        public void ToColor_t(ref Color_t color)
        {
            double h = (double)HSL.H / 256;
            double s = (double)HSL.S / 255;
            double l = (double)HSL.L / 255;
            double q;
            if (l < 0.5)
                q = l * (1 + s);
            else
                q = l + s - l * s;
            double p = 2 * l - q;
            double[] t = new double[] { h + 1.0 / 3, h, h - 1.0 / 3 };
            byte[] rgb = new byte[3];
            for (int i = 0; i < 3; i++)
            {
                if (t[i] < 0) t[i]++;
                if (t[i] > 1) t[i]--;
                if (t[i] < 1.0 / 6)
                    rgb[i] = (byte)Math.Round((p + ((q - p) * 6 * t[i])) * 255);
                else if (t[i] < 1.0 / 2)
                    rgb[i] = (byte)Math.Round(q * 255);
                else if (t[i] < 2.0 / 3)
                    rgb[i] = (byte)Math.Round((p + ((q - p) * 6 * (2.0 / 3 - t[i]))) * 255);
                else
                    rgb[i] = (byte)Math.Round(p * 255);
            }
            color.R = rgb[0];
            color.G = rgb[1];
            color.B = rgb[2];
        }

        public override string ToString()
        {
            return $"H: {HSL.H} S: {HSL.S} L: {HSL.L}";
        }
    }

    public enum StaticOptions : byte
    {
        AllLed = 0,
        SpecificLED
    }

    public enum TheaterOptions : byte
    {
        Static = 1,
        Rainbow
    }
}
