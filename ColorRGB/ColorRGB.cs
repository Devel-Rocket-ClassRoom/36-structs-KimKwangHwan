using System;
using System.Collections.Generic;
using System.Text;

struct ColorRGB
{
    public int R; public int G; public int B;
    public ColorRGB(int r, int g, int b)
    {
        R = r; G = g; B = b;
    }
    public int GetBrightness()
    {
        return (R + G + B) / 3;
    }
}