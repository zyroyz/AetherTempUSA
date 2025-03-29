using System;
using UnityEngine;

namespace StupidTemplate.Classes
{
    public class ExtGradient1
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(Color.green, 1f),
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}
