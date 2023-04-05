﻿using Murder.Core.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Murder.Core.Graphics
{
    /// <summary>
    /// Generic struct for drawing things without cluttering methods full of arguments.
    /// Note that not all fields are supported by all methods.
    /// Tip: Create a new one like this: <code>new DrawInfo(){ Color = Color.Red, Sort = 0.2f}</code>
    /// </summary> 
    public readonly struct DrawInfo
    {
        /// <summary>
        /// The origin of the image. From 0 to 1. Vector2.Center is the center.
        /// </summary>
        public Vector2 Origin { get; init; } = Vector2.Zero;
        
        /// <summary>
        /// In degrees.
        /// </summary>
        public float Rotation { get; init; } = 0;
        public Color Color { get; init; } = Color.White;
        public float Sort { get; init; } = 0.5f;
        public DrawInfo()
        {
        }
    }
}
