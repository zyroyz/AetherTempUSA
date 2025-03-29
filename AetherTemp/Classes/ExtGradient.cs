using System;
using UnityEngine;

namespace StupidTemplate.Classes
{
    public class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(new Color(0.137f, 0.055f, 0.169f), 0f),
            new GradientColorKey(new Color(0.384f, 0.110f, 0.478f), 0.5f),
            new GradientColorKey(new Color(0.137f, 0.055f, 0.169f), 1f)
        };

        public GradientColorKey[] colors1 = new GradientColorKey[]
        {
            new GradientColorKey(Color.green, 1f),
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}
